namespace Face_Detection_And_Recognition_System
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yuzeklebtn = new System.Windows.Forms.Button();
            this.kamerakisisayisilabel = new System.Windows.Forms.Label();
            this.kamerakisisayisigosterlabel = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.kameradakikimlabel = new System.Windows.Forms.Label();
            this.kameradakikisilabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtKisiDuzenle = new MetroFramework.Controls.MetroTile();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.yuzeklebtn);
            this.groupBox1.Controls.Add(this.kamerakisisayisilabel);
            this.groupBox1.Controls.Add(this.kamerakisisayisigosterlabel);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.kameradakikimlabel);
            this.groupBox1.Controls.Add(this.kameradakikisilabel);
            this.groupBox1.Location = new System.Drawing.Point(588, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 563);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Islem";
            // 
            // yuzeklebtn
            // 
            this.yuzeklebtn.Location = new System.Drawing.Point(9, 308);
            this.yuzeklebtn.Name = "yuzeklebtn";
            this.yuzeklebtn.Size = new System.Drawing.Size(175, 80);
            this.yuzeklebtn.TabIndex = 6;
            this.yuzeklebtn.Text = "YÜZ EKLE";
            this.yuzeklebtn.UseVisualStyleBackColor = true;
            this.yuzeklebtn.Click += new System.EventHandler(this.yuzeklebtn_Click);
            // 
            // kamerakisisayisilabel
            // 
            this.kamerakisisayisilabel.AutoSize = true;
            this.kamerakisisayisilabel.Location = new System.Drawing.Point(151, 243);
            this.kamerakisisayisilabel.Name = "kamerakisisayisilabel";
            this.kamerakisisayisilabel.Size = new System.Drawing.Size(14, 13);
            this.kamerakisisayisilabel.TabIndex = 4;
            this.kamerakisisayisilabel.Text = "0";
            // 
            // kamerakisisayisigosterlabel
            // 
            this.kamerakisisayisigosterlabel.AutoSize = true;
            this.kamerakisisayisigosterlabel.Location = new System.Drawing.Point(6, 243);
            this.kamerakisisayisigosterlabel.Name = "kamerakisisayisigosterlabel";
            this.kamerakisisayisigosterlabel.Size = new System.Drawing.Size(128, 13);
            this.kamerakisisayisigosterlabel.TabIndex = 3;
            this.kamerakisisayisigosterlabel.Text = "Yakalanan Kişi Sayısı";
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(6, 19);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(184, 156);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // kameradakikimlabel
            // 
            this.kameradakikimlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kameradakikimlabel.ForeColor = System.Drawing.Color.Red;
            this.kameradakikimlabel.Location = new System.Drawing.Point(6, 482);
            this.kameradakikimlabel.Name = "kameradakikimlabel";
            this.kameradakikimlabel.Size = new System.Drawing.Size(184, 72);
            this.kameradakikimlabel.TabIndex = 1;
            this.kameradakikimlabel.Text = "Tanınmıyor";
            // 
            // kameradakikisilabel
            // 
            this.kameradakikisilabel.AutoSize = true;
            this.kameradakikisilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kameradakikisilabel.Location = new System.Drawing.Point(6, 447);
            this.kameradakikisilabel.Name = "kameradakikisilabel";
            this.kameradakikisilabel.Size = new System.Drawing.Size(143, 16);
            this.kameradakikisilabel.TabIndex = 0;
            this.kameradakikisilabel.Text = "KAMERADAKİ KİŞİ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtKisiDuzenle);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 98);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Secenekler";
            // 
            // mtKisiDuzenle
            // 
            this.mtKisiDuzenle.Location = new System.Drawing.Point(6, 18);
            this.mtKisiDuzenle.Name = "mtKisiDuzenle";
            this.mtKisiDuzenle.Size = new System.Drawing.Size(561, 73);
            this.mtKisiDuzenle.TabIndex = 2;
            this.mtKisiDuzenle.Text = "Kisi Duzenle";
            this.mtKisiDuzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtKisiDuzenle.TileImage = global::Face_Detection_And_Recognition_System.Properties.Resources.pencil_icon;
            this.mtKisiDuzenle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtKisiDuzenle.UseTileImage = true;
            this.mtKisiDuzenle.Click += new System.EventHandler(this.mtKisiDuzenle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.imageBoxFrameGrabber);
            this.groupBox4.Location = new System.Drawing.Point(12, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 462);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kamera";
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(3, 16);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(567, 443);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 1;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(789, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(427, 563);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 637);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Text = "Face Detection And Recognition System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtKisiDuzenle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label kameradakikimlabel;
        private System.Windows.Forms.Label kameradakikisilabel;
        private System.Windows.Forms.Button yuzeklebtn;
        private System.Windows.Forms.Label kamerakisisayisilabel;
        private System.Windows.Forms.Label kamerakisisayisigosterlabel;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    }
}

