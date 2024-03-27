using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bileti_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=SinemaBiletiOtomasyonu;Integrated Security=True");
        int sayac = 0;

        private void FilmveSalonGetir(ComboBox combo, string sql1, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        private void FilmAfişiGöster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from FilmBilgileri where FilmAdi='"+comboFilmAdi.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["Resim"].ToString();
            }
            baglanti.Close();
        }

        private void VeritabaniDoluKoltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from SatisBilgileri where FilmAdi='"+comboFilmAdi.SelectedItem+"' and SalonAdi='"
                +comboSalonAdi.Text+"' and Tarih='"+comboFilmTarihi.SelectedItem+"' and Saat='"+comboFilmSeansı.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (read["KoltukNo"].ToString()==item.Text) // Koltuk dinamik butonlara eşit ise bu işlemleri yapsın
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
            ComboDoluKoltuklar(); // Dolu koltukları comboKoltukİptal ComboBox'ına yansıt
        }

        private void ComboDoluKoltuklar()
        {
            comboKoltukİptal.Items.Clear();
            // CHATGPT BURADAKİ comboKoltukİptal.Text = ""; KODUNU SİLDİ
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    Button button = (Button)item; // CHATGPT
                    if (item.BackColor==Color.Red)
                    {
                        comboKoltukİptal.Items.Add(button.Text); // CHATGPT İTEM.TEXT YERİNE BUTTON.TEXT YAZDIRDI
                    }
                }
            }
        }

        private void YenidenRenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            BoşKoltuklar();
            FilmveSalonGetir(comboFilmAdi, "select *from FilmBilgileri", "FilmAdi");
            FilmveSalonGetir(comboSalonAdi, "select *from SalonBilgileri", "SalonAdi");
            // comboFilmAdi için SelectedIndexChanged olayına FilmTarihiGetir işlevini bağlayın
            comboFilmAdi.SelectedIndexChanged += comboFilmAdi_SelectedIndexChanged;
        }

        private void BoşKoltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor==Color.White) // arka plan rengi beyazsa bu işlemi yap
            {
                txtKoltukNo.Text = b.Text;
            }
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            frmSalonEkle ekle = new frmSalonEkle();
            ekle.Show();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            frmFilmEkle ekle = new frmFilmEkle();
            ekle.Show();
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            frmSeansEkle ekle = new frmSeansEkle();
            ekle.Show();
        }

        private void btnSeansListele_Click(object sender, EventArgs e)
        {
            frmSeansListeleme listeleme = new frmSeansListeleme();
            listeleme.Show();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            frmSatısListeleme listeleme = new frmSatısListeleme();
            listeleme.Show();
        }

        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFilmSeansı.Items.Clear();
            comboFilmTarihi.Items.Clear();
            comboFilmSeansı.Text = "";
            comboFilmTarihi.Text = "";
            comboSalonAdi.Text = "";
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            FilmAfişiGöster();
            YenidenRenklendir();
            ComboDoluKoltuklar();
            FilmTarihiGetir(); // ChatGPT
        }

        sinemaTableAdapters.SatisBilgileriTableAdapter satis=new sinemaTableAdapters.SatisBilgileriTableAdapter();

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text!="")
            {
                try
                {
                    satis.SatışYap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text, comboFilmTarihi.Text, comboFilmSeansı.Text,
                        txtAd.Text, txtSoyad.Text, comboUcret.Text, DateTime.Now.ToString());
                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    YenidenRenklendir();
                    VeritabaniDoluKoltuklar();
                    ComboDoluKoltuklar();
                    // Bilet satışı tamamlandıktan sonra bilgileri temizleme
                    txtKoltukNo.Text = "";
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    comboUcret.Text = "";
                    // groupBox2 içindeki diğer kontrolleri temizleme
                    foreach (Control control in groupBox2.Controls)
                    {
                        if (control is TextBox)
                        {
                            TextBox textBox = (TextBox)control;
                            textBox.Text = "";
                        }
                    }

                    // Başarılı mesajını gösterme
                    MessageBox.Show("BİLET SATILDI ^o^", "BAŞARILI");
                }
                catch (Exception hata)
                {

                    MessageBox.Show("HATA OLUŞTU"+hata.Message, "UYARI !!!");
                } 
            }
            else
            {
                MessageBox.Show("KOLTUK SEÇİMİ YAPMADINIZ -.-", "UYARI !!!");
            }
        }

        private void FilmTarihiGetir()
        {
            comboFilmTarihi.Text = "";
            comboFilmSeansı.Text = "";
            comboFilmTarihi.Items.Clear(); // içeriğini temizler
            comboFilmSeansı.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from SeansBilgileri where FilmAdi='" + comboFilmAdi.SelectedItem + "' " +
                " and SalonAdi='" + comboSalonAdi.SelectedItem + "'", baglanti);
            SqlDataReader read= komut.ExecuteReader();  
            while (read.Read())
            {
                if (DateTime.Parse(read["Tarih"].ToString())>=DateTime.Parse(DateTime.Now.ToString())) 
                {
                    if (!comboFilmTarihi.Items.Contains(read["Tarih"].ToString()))
                    {
                        comboFilmTarihi.Items.Add(read["Tarih"].ToString()); // veritabanındaki tarihi getirecek
                    }
                }
            }
            baglanti.Close();
        }

        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmTarihiGetir();
        } 

        private void FilmSeansıGetir()
        {
            comboFilmSeansı.Text = "";
            comboFilmSeansı.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from SeansBilgileri where FilmAdi='" + comboFilmAdi.SelectedItem + "' " +
                " and SalonAdi='" + comboSalonAdi.SelectedItem + "' and Tarih='"+comboFilmTarihi.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["Tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToString()))
                {
                    if (DateTime.Parse(read["Seans"].ToString()) > DateTime.Parse(DateTime.Now.ToString())) // eğer seansın saati şuanki saatten büyükse bu işlemi yap
                    {
                        comboFilmSeansı.Items.Add(read["Seans"].ToString()); // veritabanındaki tarihi getirecek
                    }    
                }
                else if (DateTime.Parse(read["Tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToString()))
                {
                    comboFilmSeansı.Items.Add(read["Seans"].ToString()); // veritabanındaki tarihi getirecek
                }
            }
            baglanti.Close();
        }

        private void comboFilmTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmSeansıGetir();
        }

        private void comboFilmSeansı_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            VeritabaniDoluKoltuklar();
            ComboDoluKoltuklar();
        }

        private void comboKoltukİptal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSeat = comboKoltukİptal.SelectedItem.ToString();
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    Button button = (Button)item;
                    if (button.Text == selectedSeat)
                    {
                        button.BackColor = Color.White;
                        break;
                    }
                }
            }
        }

        private void btnBiletİptal_Click(object sender, EventArgs e)
        {
            if (comboKoltukİptal.Text!="")
            {
                try
                {
                    satis.Satışİptal(comboFilmAdi.Text, comboSalonAdi.Text, comboFilmTarihi.Text, comboFilmSeansı.Text, comboKoltukİptal.Text);
                    YenidenRenklendir();
                    VeritabaniDoluKoltuklar();
                    ComboDoluKoltuklar();
                }
                catch (Exception Hata)
                {
                    MessageBox.Show("HATA OLUŞTU !!!"+Hata.Message, "UYARI !!!");
                }
            }
            else
            {
                MessageBox.Show("KOLTUK SEÇİMİ YAPMADINIZ -_-", "UYARI !!!");
            }
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            frmFilmSil sil = new frmFilmSil();
            sil.ShowDialog();
        }
    }
}
