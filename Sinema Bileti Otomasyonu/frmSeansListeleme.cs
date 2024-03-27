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
    public partial class frmSeansListeleme : Form
    {
        public frmSeansListeleme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=SinemaBiletiOtomasyonu;Integrated Security=True");
        DataTable tablo = new DataTable();
        string GuncelTarih;

        private void SeansListesi(string sql)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            tablo.Clear();
            adtr.Fill(tablo); // Veritabanındaki kayıtları tabloya aktaralım
            dataGridView1.DataSource = tablo; // dataGridView1'de tabloyu gösterme 
            baglanti.Close();
        }

        private void OtomatikSeansSil() // ChatGPT
        {
            string GuncelTarih = DateTime.Now.ToShortDateString();

            string SeansSil = "DELETE FROM SeansBilgileri WHERE tarih < @currentDate";
            using (SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=SinemaBiletiOtomasyonu;Integrated Security=True"))
            {
                SqlCommand komut = new SqlCommand(SeansSil, baglanti);
                komut.Parameters.AddWithValue("@currentDate", GuncelTarih);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void frmSeansListeleme_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            GuncelTarih=DateTime.Now.ToShortDateString(); // ChatGPT
            OtomatikSeansSil(); // ChatGPT
            // SeansListesi("select *from SeansBilgileri where tarih like '" + dateTimePicker1.Text + "'");
            SeansListesi("select *from SeansBilgileri where tarih >= '" + GuncelTarih + "' and tarih like '" + dateTimePicker1.Text + "'"); //ChatGPT
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            GuncelTarih = DateTime.Now.ToShortDateString(); // ChatGPT
            OtomatikSeansSil(); // ChatGPT
            SeansListesi("select *from SeansBilgileri where tarih like '" + dateTimePicker1.Text + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            GuncelTarih = DateTime.Now.ToShortDateString(); // ChatGPT
            OtomatikSeansSil(); // ChatGPT
            // SeansListesi("SELECT * FROM SeansBilgileri");
            SeansListesi("SELECT * FROM SeansBilgileri WHERE tarih >= '" + GuncelTarih + "'");
            dataGridView1.Refresh(); // dataGridView1'i güncel verilerle yeniden yükle
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
