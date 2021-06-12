namespace SİNEMA_OTOMASYONU
{
    partial class QR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR));
            this.btnQROluştur = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.QRKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtQROluştur = new System.Windows.Forms.TextBox();
            this.lblQROluştur = new System.Windows.Forms.Label();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.lblQRBİLGİ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQROluştur
            // 
            this.btnQROluştur.BackColor = System.Drawing.Color.Crimson;
            this.btnQROluştur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQROluştur.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQROluştur.ForeColor = System.Drawing.Color.White;
            this.btnQROluştur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQROluştur.ImageIndex = 0;
            this.btnQROluştur.ImageList = this.ımageList2;
            this.btnQROluştur.Location = new System.Drawing.Point(266, 45);
            this.btnQROluştur.Margin = new System.Windows.Forms.Padding(2);
            this.btnQROluştur.Name = "btnQROluştur";
            this.btnQROluştur.Size = new System.Drawing.Size(105, 36);
            this.btnQROluştur.TabIndex = 0;
            this.btnQROluştur.Text = "Oluştur";
            this.btnQROluştur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQROluştur.UseVisualStyleBackColor = false;
            this.btnQROluştur.Click += new System.EventHandler(this.btnQROluştur_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "QRoluştur_icon.png");
            // 
            // QRKaydet
            // 
            this.QRKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.QRKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QRKaydet.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QRKaydet.ForeColor = System.Drawing.Color.White;
            this.QRKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QRKaydet.ImageIndex = 0;
            this.QRKaydet.ImageList = this.ımageList1;
            this.QRKaydet.Location = new System.Drawing.Point(223, 229);
            this.QRKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.QRKaydet.Name = "QRKaydet";
            this.QRKaydet.Size = new System.Drawing.Size(112, 38);
            this.QRKaydet.TabIndex = 1;
            this.QRKaydet.Text = "Kaydet";
            this.QRKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QRKaydet.UseVisualStyleBackColor = false;
            this.QRKaydet.Click += new System.EventHandler(this.QRKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "QRKaydet_icon.png");
            // 
            // txtQROluştur
            // 
            this.txtQROluştur.Location = new System.Drawing.Point(21, 47);
            this.txtQROluştur.Margin = new System.Windows.Forms.Padding(2);
            this.txtQROluştur.Name = "txtQROluştur";
            this.txtQROluştur.Size = new System.Drawing.Size(232, 34);
            this.txtQROluştur.TabIndex = 2;
            // 
            // lblQROluştur
            // 
            this.lblQROluştur.AutoSize = true;
            this.lblQROluştur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQROluştur.Location = new System.Drawing.Point(17, 108);
            this.lblQROluştur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQROluştur.Name = "lblQROluştur";
            this.lblQROluştur.Size = new System.Drawing.Size(96, 23);
            this.lblQROluştur.TabIndex = 3;
            this.lblQROluştur.Text = "QR KOD:";
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQR.Location = new System.Drawing.Point(20, 133);
            this.pictureBoxQR.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(164, 134);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQR.TabIndex = 4;
            this.pictureBoxQR.TabStop = false;
            // 
            // lblQRBİLGİ
            // 
            this.lblQRBİLGİ.AutoSize = true;
            this.lblQRBİLGİ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQRBİLGİ.Location = new System.Drawing.Point(16, 9);
            this.lblQRBİLGİ.Name = "lblQRBİLGİ";
            this.lblQRBİLGİ.Size = new System.Drawing.Size(106, 23);
            this.lblQRBİLGİ.TabIndex = 5;
            this.lblQRBİLGİ.Text = "URL Girin:";
            // 
            // QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(415, 310);
            this.Controls.Add(this.lblQRBİLGİ);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.lblQROluştur);
            this.Controls.Add(this.txtQROluştur);
            this.Controls.Add(this.QRKaydet);
            this.Controls.Add(this.btnQROluştur);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "QR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR İŞLEMLERİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QR_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQROluştur;
        private System.Windows.Forms.Button QRKaydet;
        private System.Windows.Forms.TextBox txtQROluştur;
        private System.Windows.Forms.Label lblQROluştur;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.Label lblQRBİLGİ;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}