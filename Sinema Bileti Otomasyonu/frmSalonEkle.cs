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
    public partial class frmSalonEkle : Form
    {
        public frmSalonEkle()
        {
            InitializeComponent();
        }

        private void frmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.ShowDialog();
        }

        sinemaTableAdapters.SalonBilgileriTableAdapter salon = new sinemaTableAdapters.SalonBilgileriTableAdapter();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(txtSalonAdi.Text);
                MessageBox.Show("SALON EKLENDİ ^.^", "KAYIT");
            }
            catch (Exception)
            {
                MessageBox.Show("AYNI SALONU DAHA ÖNCE EKLEDİNİZ -_-", "UYARI !!!");
            }
            txtSalonAdi.Text = "";
        }
    }
}
