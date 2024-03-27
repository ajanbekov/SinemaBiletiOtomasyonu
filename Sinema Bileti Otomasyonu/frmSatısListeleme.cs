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
    public partial class frmSatısListeleme : Form
    {
        public frmSatısListeleme()
        {
            InitializeComponent();
        }

        sinemaTableAdapters.SatisBilgileriTableAdapter SatisListesi = new sinemaTableAdapters.SatisBilgileriTableAdapter();

        private void frmSatısListeleme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SatisListesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void ToplamUcretHesapla()
        {
            dataGridView1.DataSource = SatisListesi.SatışListesi2();
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(dataGridView1.Rows[i].Cells["Ucret"].Value);
            }
            label1.Text = "TOPLAM SATIŞ = " + ucrettoplami + " TL";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SatisListesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SatisListesi.SatışListesi2();
            ToplamUcretHesapla();
        }
    }
}
