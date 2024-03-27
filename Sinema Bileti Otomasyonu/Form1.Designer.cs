namespace Sinema_Bileti_Otomasyonu
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnSeansListele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.comboUcret = new System.Windows.Forms.ComboBox();
            this.comboFilmSeansı = new System.Windows.Forms.ComboBox();
            this.comboFilmTarihi = new System.Windows.Forms.ComboBox();
            this.comboSalonAdi = new System.Windows.Forms.ComboBox();
            this.comboFilmAdi = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboKoltukİptal = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBiletİptal = new System.Windows.Forms.Button();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalonEkle.ImageIndex = 0;
            this.btnSalonEkle.ImageList = this.ımageList1;
            this.btnSalonEkle.Location = new System.Drawing.Point(48, 35);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(195, 127);
            this.btnSalonEkle.TabIndex = 0;
            this.btnSalonEkle.Text = "SALON EKLE";
            this.btnSalonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalonEkle.UseVisualStyleBackColor = true;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Salon Ekle Butonu.png");
            this.ımageList1.Images.SetKeyName(1, "Film Ekle Butonu.png");
            this.ımageList1.Images.SetKeyName(2, "Seans Ekle Butonu.png");
            this.ımageList1.Images.SetKeyName(3, "Seans Listele Butonu.png");
            this.ımageList1.Images.SetKeyName(4, "Çıkış Butonu.png");
            this.ımageList1.Images.SetKeyName(5, "Satışlar Butonu.png");
            this.ımageList1.Images.SetKeyName(6, "Sil Butonu Ana Sayfa.png");
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilmEkle.ImageIndex = 1;
            this.btnFilmEkle.ImageList = this.ımageList1;
            this.btnFilmEkle.Location = new System.Drawing.Point(292, 35);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(188, 127);
            this.btnFilmEkle.TabIndex = 1;
            this.btnFilmEkle.Text = "FİLM EKLE";
            this.btnFilmEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeansEkle.ImageIndex = 2;
            this.btnSeansEkle.ImageList = this.ımageList1;
            this.btnSeansEkle.Location = new System.Drawing.Point(766, 34);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(203, 128);
            this.btnSeansEkle.TabIndex = 2;
            this.btnSeansEkle.Text = "SEANS EKLE";
            this.btnSeansEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansEkle.UseVisualStyleBackColor = true;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // btnSeansListele
            // 
            this.btnSeansListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeansListele.ImageIndex = 3;
            this.btnSeansListele.ImageList = this.ımageList1;
            this.btnSeansListele.Location = new System.Drawing.Point(1018, 35);
            this.btnSeansListele.Name = "btnSeansListele";
            this.btnSeansListele.Size = new System.Drawing.Size(247, 128);
            this.btnSeansListele.TabIndex = 3;
            this.btnSeansListele.Text = "SEANS LİSTELE";
            this.btnSeansListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansListele.UseVisualStyleBackColor = true;
            this.btnSeansListele.Click += new System.EventHandler(this.btnSeansListele_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(55, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 368);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(64, 616);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(466, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "BOŞ KOLTUKLAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(92, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOLU KOLTUKLAR";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(393, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 46);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 46);
            this.label1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(27, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 363);
            this.label5.TabIndex = 8;
            this.label5.Text = "P\r\n\r\nE\r\n\r\nR\r\n\r\nD\r\n\r\nE";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(469, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 59);
            this.label6.TabIndex = 9;
            this.label6.Text = "F İ L M   A F İ Ş İ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBiletSat);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.txtKoltukNo);
            this.groupBox2.Controls.Add(this.comboUcret);
            this.groupBox2.Controls.Add(this.comboFilmSeansı);
            this.groupBox2.Controls.Add(this.comboFilmTarihi);
            this.groupBox2.Controls.Add(this.comboSalonAdi);
            this.groupBox2.Controls.Add(this.comboFilmAdi);
            this.groupBox2.Location = new System.Drawing.Point(782, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 444);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BİLET SATIŞ İŞLEMLERİ";
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletSat.Location = new System.Drawing.Point(198, 386);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(132, 43);
            this.btnBiletSat.TabIndex = 16;
            this.btnBiletSat.Text = "BİLET SAT";
            this.btnBiletSat.UseVisualStyleBackColor = true;
            this.btnBiletSat.Click += new System.EventHandler(this.btnBiletSat_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(22, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 23);
            this.label14.TabIndex = 15;
            this.label14.Text = "ÜCRET";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(22, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "SOYAD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(22, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "AD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(22, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "KOLTUK NO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(22, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "FİLM SEANSI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(22, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "FİLM TARİHİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(22, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "SALON ADI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(22, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "FİLM ADI";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(176, 302);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(172, 30);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(176, 264);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(172, 30);
            this.txtAd.TabIndex = 6;
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKoltukNo.Location = new System.Drawing.Point(176, 217);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(172, 30);
            this.txtKoltukNo.TabIndex = 5;
            // 
            // comboUcret
            // 
            this.comboUcret.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboUcret.FormattingEnabled = true;
            this.comboUcret.Items.AddRange(new object[] {
            "60",
            "65",
            "70",
            "75"});
            this.comboUcret.Location = new System.Drawing.Point(176, 343);
            this.comboUcret.Name = "comboUcret";
            this.comboUcret.Size = new System.Drawing.Size(172, 31);
            this.comboUcret.Sorted = true;
            this.comboUcret.TabIndex = 4;
            // 
            // comboFilmSeansı
            // 
            this.comboFilmSeansı.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboFilmSeansı.FormattingEnabled = true;
            this.comboFilmSeansı.Location = new System.Drawing.Point(176, 166);
            this.comboFilmSeansı.Name = "comboFilmSeansı";
            this.comboFilmSeansı.Size = new System.Drawing.Size(172, 31);
            this.comboFilmSeansı.Sorted = true;
            this.comboFilmSeansı.TabIndex = 3;
            this.comboFilmSeansı.SelectedIndexChanged += new System.EventHandler(this.comboFilmSeansı_SelectedIndexChanged);
            // 
            // comboFilmTarihi
            // 
            this.comboFilmTarihi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboFilmTarihi.FormattingEnabled = true;
            this.comboFilmTarihi.Location = new System.Drawing.Point(176, 121);
            this.comboFilmTarihi.Name = "comboFilmTarihi";
            this.comboFilmTarihi.Size = new System.Drawing.Size(172, 31);
            this.comboFilmTarihi.Sorted = true;
            this.comboFilmTarihi.TabIndex = 2;
            this.comboFilmTarihi.SelectedIndexChanged += new System.EventHandler(this.comboFilmTarihi_SelectedIndexChanged);
            // 
            // comboSalonAdi
            // 
            this.comboSalonAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboSalonAdi.FormattingEnabled = true;
            this.comboSalonAdi.Location = new System.Drawing.Point(176, 76);
            this.comboSalonAdi.Name = "comboSalonAdi";
            this.comboSalonAdi.Size = new System.Drawing.Size(172, 31);
            this.comboSalonAdi.Sorted = true;
            this.comboSalonAdi.TabIndex = 1;
            this.comboSalonAdi.SelectedIndexChanged += new System.EventHandler(this.comboSalonAdi_SelectedIndexChanged);
            // 
            // comboFilmAdi
            // 
            this.comboFilmAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboFilmAdi.FormattingEnabled = true;
            this.comboFilmAdi.Location = new System.Drawing.Point(176, 30);
            this.comboFilmAdi.Name = "comboFilmAdi";
            this.comboFilmAdi.Size = new System.Drawing.Size(172, 31);
            this.comboFilmAdi.Sorted = true;
            this.comboFilmAdi.TabIndex = 0;
            this.comboFilmAdi.SelectedIndexChanged += new System.EventHandler(this.comboFilmAdi_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboKoltukİptal);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btnBiletİptal);
            this.groupBox3.Location = new System.Drawing.Point(1179, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 137);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BİLET İPTAL";
            // 
            // comboKoltukİptal
            // 
            this.comboKoltukİptal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.comboKoltukİptal.FormattingEnabled = true;
            this.comboKoltukİptal.Location = new System.Drawing.Point(153, 36);
            this.comboKoltukİptal.Name = "comboKoltukİptal";
            this.comboKoltukİptal.Size = new System.Drawing.Size(172, 31);
            this.comboKoltukİptal.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(16, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 23);
            this.label15.TabIndex = 18;
            this.label15.Text = "KOLTUK NO";
            // 
            // btnBiletİptal
            // 
            this.btnBiletİptal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletİptal.Location = new System.Drawing.Point(153, 78);
            this.btnBiletİptal.Name = "btnBiletİptal";
            this.btnBiletİptal.Size = new System.Drawing.Size(172, 42);
            this.btnBiletİptal.TabIndex = 17;
            this.btnBiletİptal.Text = "BİLET İPTAL";
            this.btnBiletİptal.UseVisualStyleBackColor = true;
            this.btnBiletİptal.Click += new System.EventHandler(this.btnBiletİptal_Click);
            // 
            // btnSatislar
            // 
            this.btnSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatislar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatislar.ImageIndex = 5;
            this.btnSatislar.ImageList = this.ımageList1;
            this.btnSatislar.Location = new System.Drawing.Point(1314, 35);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(176, 128);
            this.btnSatislar.TabIndex = 12;
            this.btnSatislar.Text = "SATIŞLAR";
            this.btnSatislar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatislar.UseVisualStyleBackColor = true;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(483, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFilmSil.ImageIndex = 6;
            this.btnFilmSil.ImageList = this.ımageList1;
            this.btnFilmSil.Location = new System.Drawing.Point(529, 36);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(188, 127);
            this.btnFilmSil.TabIndex = 14;
            this.btnFilmSil.Text = "FİLM SİLME";
            this.btnFilmSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmSil.UseVisualStyleBackColor = true;
            this.btnFilmSil.Click += new System.EventHandler(this.btnFilmSil_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 753);
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSeansListele);
            this.Controls.Add(this.btnSeansEkle);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.btnSalonEkle);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinema Bilet Satış Otomasyonu";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnSeansListele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBiletSat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.ComboBox comboUcret;
        private System.Windows.Forms.ComboBox comboFilmSeansı;
        private System.Windows.Forms.ComboBox comboFilmTarihi;
        private System.Windows.Forms.ComboBox comboSalonAdi;
        private System.Windows.Forms.ComboBox comboFilmAdi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBiletİptal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboKoltukİptal;
        private System.Windows.Forms.Button btnFilmSil;
    }
}

