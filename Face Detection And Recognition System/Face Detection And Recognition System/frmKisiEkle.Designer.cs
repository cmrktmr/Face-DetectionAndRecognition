namespace Face_Detection_And_Recognition_System
{
    partial class frmKisiEkle
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richtxtAdres = new System.Windows.Forms.RichTextBox();
            this.btnKisiEkle = new MetroFramework.Controls.MetroButton();
            this.txtBabaAdiSoyadi = new MetroFramework.Controls.MetroTextBox();
            this.txtAnaAdiSoyadi = new MetroFramework.Controls.MetroTextBox();
            this.txtDogumYeri = new MetroFramework.Controls.MetroTextBox();
            this.cbCinsiyet = new MetroFramework.Controls.MetroComboBox();
            this.dateTimePickerDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdSoyad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtKimlikNo = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cmbKullaniciListesi = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richtxtAdres);
            this.groupBox3.Controls.Add(this.btnKisiEkle);
            this.groupBox3.Controls.Add(this.txtBabaAdiSoyadi);
            this.groupBox3.Controls.Add(this.txtAnaAdiSoyadi);
            this.groupBox3.Controls.Add(this.txtDogumYeri);
            this.groupBox3.Controls.Add(this.cbCinsiyet);
            this.groupBox3.Controls.Add(this.dateTimePickerDogumTarihi);
            this.groupBox3.Controls.Add(this.txtAdSoyad);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.txtKimlikNo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(6, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 382);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kişi Bilgileri";
            // 
            // richtxtAdres
            // 
            this.richtxtAdres.Location = new System.Drawing.Point(166, 248);
            this.richtxtAdres.Name = "richtxtAdres";
            this.richtxtAdres.Size = new System.Drawing.Size(285, 84);
            this.richtxtAdres.TabIndex = 17;
            this.richtxtAdres.Text = "";
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(166, 338);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(285, 38);
            this.btnKisiEkle.TabIndex = 16;
            this.btnKisiEkle.Text = "Kişi Ekle / Güncelle";
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // txtBabaAdiSoyadi
            // 
            this.txtBabaAdiSoyadi.Location = new System.Drawing.Point(166, 219);
            this.txtBabaAdiSoyadi.Name = "txtBabaAdiSoyadi";
            this.txtBabaAdiSoyadi.Size = new System.Drawing.Size(285, 23);
            this.txtBabaAdiSoyadi.TabIndex = 15;
            // 
            // txtAnaAdiSoyadi
            // 
            this.txtAnaAdiSoyadi.Location = new System.Drawing.Point(166, 186);
            this.txtAnaAdiSoyadi.Name = "txtAnaAdiSoyadi";
            this.txtAnaAdiSoyadi.Size = new System.Drawing.Size(285, 23);
            this.txtAnaAdiSoyadi.TabIndex = 14;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(166, 151);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(285, 23);
            this.txtDogumYeri.TabIndex = 12;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.ItemHeight = 23;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.cbCinsiyet.Location = new System.Drawing.Point(166, 109);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(285, 29);
            this.cbCinsiyet.TabIndex = 11;
            // 
            // dateTimePickerDogumTarihi
            // 
            this.dateTimePickerDogumTarihi.Location = new System.Drawing.Point(166, 83);
            this.dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            this.dateTimePickerDogumTarihi.Size = new System.Drawing.Size(285, 20);
            this.dateTimePickerDogumTarihi.TabIndex = 10;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(166, 57);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(285, 23);
            this.txtAdSoyad.TabIndex = 9;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(21, 219);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(123, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Baba Adı - Soyadı :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(21, 186);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(116, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Ana Adı - Soyadı :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 243);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Adres :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 151);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Doğum Yeri   :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Cinsiyet :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 85);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Doğum Tarhi :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Ad Soyad               :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "T.C Kimlik Numarası :";
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(166, 28);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(285, 23);
            this.txtKimlikNo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.cmbKullaniciListesi);
            this.groupBox1.Location = new System.Drawing.Point(6, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 53);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Listesi";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(21, 22);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(59, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Kullanıcı ";
            // 
            // cmbKullaniciListesi
            // 
            this.cmbKullaniciListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKullaniciListesi.FormattingEnabled = true;
            this.cmbKullaniciListesi.Location = new System.Drawing.Point(166, 20);
            this.cmbKullaniciListesi.Name = "cmbKullaniciListesi";
            this.cmbKullaniciListesi.Size = new System.Drawing.Size(285, 21);
            this.cmbKullaniciListesi.TabIndex = 0;
            this.cmbKullaniciListesi.SelectedIndexChanged += new System.EventHandler(this.cmbKullaniciListesi_SelectedIndexChanged);
            // 
            // frmKisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKisiEkle";
            this.Text = "Kisi Ekle";
            this.Load += new System.EventHandler(this.frmKisiEkle_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnKisiEkle;
        private MetroFramework.Controls.MetroTextBox txtBabaAdiSoyadi;
        private MetroFramework.Controls.MetroTextBox txtAnaAdiSoyadi;
        private MetroFramework.Controls.MetroTextBox txtDogumYeri;
        private MetroFramework.Controls.MetroComboBox cbCinsiyet;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTarihi;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.RichTextBox richtxtAdres;
        public MetroFramework.Controls.MetroTextBox txtAdSoyad;
        public MetroFramework.Controls.MetroTextBox txtKimlikNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ComboBox cmbKullaniciListesi;
    }
}