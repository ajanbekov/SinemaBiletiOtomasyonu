using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bileti_Otomasyonu
{
    public partial class frmSeansEkle : Form
    {
        public frmSeansEkle()
        {
            InitializeComponent();
        }

        string seans = "";

        private void RadioButonSeçiliyse()
        {
            if(radioButton1.Checked==true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            RadioButonSeçiliyse();
            if (seans != "")
            {
                string film = comboFilm.Text;
                string salon = comboSalon.Text;
                string tarih = dateTimePicker1.Text;

                string insertQuery = "INSERT INTO SeansBilgileri (FilmAdi, SalonAdi, tarih, seans) " +
                                     "VALUES (@film, @salon, @tarih, @seans)";
                using (SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=SinemaBiletiOtomasyonu;Integrated Security=True"))
                {
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@film", film);
                    command.Parameters.AddWithValue("@salon", salon);
                    command.Parameters.AddWithValue("@tarih", tarih);
                    command.Parameters.AddWithValue("@seans", seans);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("SEANS EKLEME İŞLEMİ YAPILDI ^_____^", "KAYIT");
                
                comboSalon.Text = "";
                comboFilm.Text = "";
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }   
            else 
            {
                MessageBox.Show("SEANS SEÇİMİ YAPPMADINIZ -.-", "UYARI !!!");
            }
            comboSalon.Text = "";
            comboFilm.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        sinemaTableAdapters.SeansBilgileriTableAdapter filmseansi = new sinemaTableAdapters.SeansBilgileriTableAdapter();
        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=SinemaBiletiOtomasyonu;Integrated Security=True");

        private void frmSeansEkle_Load(object sender, EventArgs e)
        {
            SilinmesiGerekenSeanslariSil();
            FilmveSalonGoster(comboFilm,"select * from FilmBilgileri", "FilmAdi");
            FilmveSalonGoster(comboSalon, "select * from SalonBilgileri", "SalonAdi");
        }

        private void FilmveSalonGoster (ComboBox combo, string sql, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()==true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SilinmesiGerekenSeanslariSil();
            foreach (Control item3 in panel1.Controls)
            {
                item3.Enabled = true;
            }
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (yeni==bugün)
            {
                foreach (Control item in panel1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false; // eğer şuanki saat groupBox içindeki radiolardan fazla ise diğerlerini pasif yapıcaz
                    }
                }
                TarihiKarşılaştır();
            }
            else if (yeni>bugün)
            {
                TarihiKarşılaştır();
            }
            else if (yeni<bugün)
            {
                MessageBox.Show("GERİYE DÖNÜK İŞLEM YAPILAMAZ +_+", "UYARI !!!");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void TarihiKarşılaştır()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from SeansBilgileri where SalonAdi='" + comboSalon.Text + "'" +
                "and tarih='" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in panel1.Controls)
                {
                    if (read["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglanti.Close();
        }

        private void comboSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void SilinmesiGerekenSeanslariSil()
        {
            string SimdikiZaman = DateTime.Now.ToShortDateString();
            string SeansSil = "delete from SeansBilgileri where Tarih < @SimdikiZaman";
            using (SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=SinemaBiletiOtomasyonu;Integrated " +
                "Security=True"))
            {
                SqlCommand komut = new SqlCommand(SeansSil, baglanti);
                komut.Parameters.AddWithValue("@SimdikiZaman", SimdikiZaman);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close() ;
            }
        }
    }
}
