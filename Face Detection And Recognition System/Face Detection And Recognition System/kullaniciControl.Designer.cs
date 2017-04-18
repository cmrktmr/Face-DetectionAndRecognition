namespace Face_Detection_And_Recognition_System
{
    partial class kullaniciControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pic_Resim = new Emgu.CV.UI.ImageBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblBaba = new System.Windows.Forms.Label();
            this.lblAnne = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdi
            // 
            this.lblAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAdi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(152, 4);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(321, 22);
            this.lblAdi.TabIndex = 1;
            this.lblAdi.Text = "Ramazan AYDIN";
            this.lblAdi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(152, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tc No : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(152, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cinsiyet  :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(152, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Anne :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(152, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Baba :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(152, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Doğum Tarihi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pic_Resim
            // 
            this.pic_Resim.Location = new System.Drawing.Point(4, 4);
            this.pic_Resim.Name = "pic_Resim";
            this.pic_Resim.Size = new System.Drawing.Size(147, 147);
            this.pic_Resim.TabIndex = 0;
            this.pic_Resim.TabStop = false;
            this.pic_Resim.Click += new System.EventHandler(this.pic_Resim_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(152, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Adres :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAdres
            // 
            this.lblAdres.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(270, 130);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(203, 21);
            this.lblAdres.TabIndex = 13;
            this.lblAdres.Text = "Adres :";
            this.lblAdres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(270, 109);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(203, 21);
            this.lblDogumTarihi.TabIndex = 12;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            this.lblDogumTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBaba
            // 
            this.lblBaba.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaba.Location = new System.Drawing.Point(270, 88);
            this.lblBaba.Name = "lblBaba";
            this.lblBaba.Size = new System.Drawing.Size(203, 21);
            this.lblBaba.TabIndex = 11;
            this.lblBaba.Text = "Baba :";
            this.lblBaba.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAnne
            // 
            this.lblAnne.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnne.Location = new System.Drawing.Point(270, 67);
            this.lblAnne.Name = "lblAnne";
            this.lblAnne.Size = new System.Drawing.Size(203, 21);
            this.lblAnne.TabIndex = 10;
            this.lblAnne.Text = "Anne :";
            this.lblAnne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(270, 46);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(203, 21);
            this.lblCinsiyet.TabIndex = 9;
            this.lblCinsiyet.Text = "Cinsiyet  :";
            this.lblCinsiyet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTcNo
            // 
            this.lblTcNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcNo.Location = new System.Drawing.Point(270, 25);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(203, 21);
            this.lblTcNo.TabIndex = 8;
            this.lblTcNo.Text = "Tc No : ";
            this.lblTcNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kullaniciControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblBaba);
            this.Controls.Add(this.lblAnne);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblTcNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.pic_Resim);
            this.Name = "kullaniciControl";
            this.Size = new System.Drawing.Size(476, 158);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblAdres;
        public System.Windows.Forms.Label lblDogumTarihi;
        public System.Windows.Forms.Label lblBaba;
        public System.Windows.Forms.Label lblAnne;
        public System.Windows.Forms.Label lblCinsiyet;
        public System.Windows.Forms.Label lblTcNo;
        public System.Windows.Forms.Label lblAdi;
        public Emgu.CV.UI.ImageBox pic_Resim;
    }
}
