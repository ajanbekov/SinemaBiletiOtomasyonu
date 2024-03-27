using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bileti_Otomasyonu
{
    public partial class frmFilmSil : Form
    {
        public frmFilmSil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=SinemaBiletiOtomasyonu;Integrated Security=True");
        DataTable tablo = new DataTable();

        private void FilmListesi(string sql)
        {
            baglanti.Open();
            SqlDataAdapter adtr= new SqlDataAdapter();
            tablo.Clear();
            adtr.SelectCommand = new SqlCommand(sql, baglanti); // SelectCommand'ı başlatma
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void frmFilmSil_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            string sql = ("select *from FilmBilgileri");
            SqlDataAdapter adtr = new SqlDataAdapter(sql,baglanti);
            adtr.SelectCommand = new SqlCommand(sql,baglanti); // SelectCommand'ı başlatma
            adtr.Fill(tablo);
            dataGridView1.DataSource=tablo;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult Sonuc = MessageBox.Show("FİLMİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "FİLM SİLME", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                if (Sonuc == DialogResult.Yes)
                {
                    int SeciliIndeks = dataGridView1.SelectedRows[0].Index;
                    string FilmAdi = dataGridView1.Rows[SeciliIndeks].Cells["FilmAdi"].Value.ToString();

                    baglanti.Open();
                    string Sql = "delete from FilmBilgileri where FilmAdi = @FilmAdi";
                    SqlCommand komut = new SqlCommand(Sql, baglanti);
                    komut.Parameters.AddWithValue("FilmAdi", FilmAdi);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("FİLM SİLİNDİ ^_^");
                    // FilmListesi metoduyla DataGridView'i güncelleyebilirsiniz
                    tablo.Clear();
                    FilmListesi("select *from FilmBilgileri");
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN SİLMEK İSTEDİĞİNİZ FİLMİ SEÇİNİZ", "UYARI !!!");
            }
        }
    }
}
