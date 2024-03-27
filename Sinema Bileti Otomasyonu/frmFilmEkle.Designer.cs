namespace Sinema_Bileti_Otomasyonu
{
    partial class frmFilmEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtYapimYili = new System.Windows.Forms.TextBox();
            this.comboFilmTuru = new System.Windows.Forms.ComboBox();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(69, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FİLM ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(69, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "YÖNETMEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(69, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "FİLM TÜRÜ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(69, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "SÜRE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(69, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "YAPIM YILI";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.txtFilmAdi.Location = new System.Drawing.Point(252, 71);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(226, 31);
            this.txtFilmAdi.TabIndex = 5;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.txtYonetmen.Location = new System.Drawing.Point(252, 119);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(226, 31);
            this.txtYonetmen.TabIndex = 6;
            // 
            // txtSure
            // 
            this.txtSure.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.txtSure.Location = new System.Drawing.Point(252, 215);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(226, 31);
            this.txtSure.TabIndex = 7;
            // 
            // txtYapimYili
            // 
            this.txtYapimYili.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.txtYapimYili.Location = new System.Drawing.Point(252, 263);
            this.txtYapimYili.Name = "txtYapimYili";
            this.txtYapimYili.Size = new System.Drawing.Size(226, 31);
            this.txtYapimYili.TabIndex = 8;
            // 
            // comboFilmTuru
            // 
            this.comboFilmTuru.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.comboFilmTuru.FormattingEnabled = true;
            this.comboFilmTuru.Items.AddRange(new object[] {
            "AKSİYON",
            "BİLİM KURGU",
            "DRAM",
            "KOMEDİ",
            "KORKU",
            "MACERA",
            "SUÇ"});
            this.comboFilmTuru.Location = new System.Drawing.Point(252, 167);
            this.comboFilmTuru.Name = "comboFilmTuru";
            this.comboFilmTuru.Size = new System.Drawing.Size(226, 31);
            this.comboFilmTuru.TabIndex = 9;
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnFilmEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmEkle.ImageIndex = 0;
            this.btnFilmEkle.ImageList = this.ımageList1;
            this.btnFilmEkle.Location = new System.Drawing.Point(258, 394);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(210, 55);
            this.btnFilmEkle.TabIndex = 10;
            this.btnFilmEkle.Text = "FİLM EKLE";
            this.btnFilmEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Film Ekle Butonu 2.png");
            this.ımageList1.Images.SetKeyName(1, "Afiş Seç Butonu.png");
            // 
            // btnResimSec
            // 
            this.btnResimSec.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnResimSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResimSec.ImageIndex = 1;
            this.btnResimSec.ImageList = this.ımageList1;
            this.btnResimSec.Location = new System.Drawing.Point(598, 394);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(187, 55);
            this.btnResimSec.TabIndex = 11;
            this.btnResimSec.Text = "AFİŞ SEÇ";
            this.btnResimSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(553, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 311);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 34);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(69, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "TARİH";
            // 
            // frmFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 509);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.comboFilmTuru);
            this.Controls.Add(this.txtYapimYili);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFilmEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Ekleme Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtYapimYili;
        private System.Windows.Forms.ComboBox comboFilmTuru;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
    }
}