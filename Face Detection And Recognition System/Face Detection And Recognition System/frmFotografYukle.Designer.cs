namespace Face_Detection_And_Recognition_System
{
    partial class frmFotografYukle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFotgrafKaydet = new MetroFramework.Controls.MetroButton();
            this.btnFotografGozAt = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(35, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 174);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnFotgrafKaydet
            // 
            this.btnFotgrafKaydet.Location = new System.Drawing.Point(35, 270);
            this.btnFotgrafKaydet.Name = "btnFotgrafKaydet";
            this.btnFotgrafKaydet.Size = new System.Drawing.Size(117, 23);
            this.btnFotgrafKaydet.TabIndex = 2;
            this.btnFotgrafKaydet.Text = "Kaydet";
            // 
            // btnFotografGozAt
            // 
            this.btnFotografGozAt.Location = new System.Drawing.Point(209, 270);
            this.btnFotografGozAt.Name = "btnFotografGozAt";
            this.btnFotografGozAt.Size = new System.Drawing.Size(115, 23);
            this.btnFotografGozAt.TabIndex = 3;
            this.btnFotografGozAt.Text = "Gözat";
            // 
            // frmFotografYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 342);
            this.Controls.Add(this.btnFotografGozAt);
            this.Controls.Add(this.btnFotgrafKaydet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmFotografYukle";
            this.Text = "Fotograf Yukle";
            this.Load += new System.EventHandler(this.frmFotografYukle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnFotgrafKaydet;
        private MetroFramework.Controls.MetroButton btnFotografGozAt;
    }
}