using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bileti_Otomasyonu
{
    public partial class frmFilmEkle : Form
    {
        private DataTable filmTable;

        public frmFilmEkle()
        {
            InitializeComponent();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName; // seçilen resmi pictureBox'a aktaracak
        }

        sinemaTableAdapters.FilmBilgileriTableAdapter film = new sinemaTableAdapters.FilmBilgileriTableAdapter();

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                film.FilmEkleme(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtSure.Text, dateTimePicker1.Text, txtYapimYili.Text, 
                    pictureBox1.ImageLocation);
                MessageBox.Show("FİLM BİLGİLERİ EKLENDİ (●'◡'●)", "KAYIT");
            }
            catch (Exception)
            {
                MessageBox.Show("BU FİLM DAHA ÖNCE EKLENDİ O_O", "UYARI !!!");
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            comboFilmTuru.Text = "";
            pictureBox1.ImageLocation = "";
        }
    }
}
