namespace SİNEMA_OTOMASYONU
{
    partial class KullanıcıGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıGiriş));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.pnlQR = new System.Windows.Forms.Panel();
            this.comboBoxKamera = new System.Windows.Forms.ComboBox();
            this.pictureBoxKamera = new System.Windows.Forms.PictureBox();
            this.btnQRTara = new System.Windows.Forms.Button();
            this.btnKameraAç = new System.Windows.Forms.Button();
            this.lblKamera = new System.Windows.Forms.Label();
            this.timerQR = new System.Windows.Forms.Timer(this.components);
            this.checkŞifreyiGöster = new System.Windows.Forms.CheckBox();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.btnŞifremiUnuttum = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.pnlQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kullanıcıgiriş_icon.png");
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(32, 48);
            this.lblKullanıcıAdı.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(158, 26);
            this.lblKullanıcıAdı.TabIndex = 1;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifre.Location = new System.Drawing.Point(98, 90);
            this.lblŞifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(69, 26);
            this.lblŞifre.TabIndex = 2;
            this.lblŞifre.Text = "Şifre:";
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(154, 45);
            this.txtKullanıcıAdı.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(188, 34);
            this.txtKullanıcıAdı.TabIndex = 3;
            // 
            // pnlQR
            // 
            this.pnlQR.Controls.Add(this.comboBoxKamera);
            this.pnlQR.Controls.Add(this.pictureBoxKamera);
            this.pnlQR.Controls.Add(this.btnQRTara);
            this.pnlQR.Controls.Add(this.btnKameraAç);
            this.pnlQR.Controls.Add(this.lblKamera);
            this.pnlQR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlQR.Location = new System.Drawing.Point(37, 236);
            this.pnlQR.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQR.Name = "pnlQR";
            this.pnlQR.Size = new System.Drawing.Size(366, 269);
            this.pnlQR.TabIndex = 5;
            // 
            // comboBoxKamera
            // 
            this.comboBoxKamera.FormattingEnabled = true;
            this.comboBoxKamera.Location = new System.Drawing.Point(117, 19);
            this.comboBoxKamera.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKamera.Name = "comboBoxKamera";
            this.comboBoxKamera.Size = new System.Drawing.Size(188, 33);
            this.comboBoxKamera.TabIndex = 7;
            // 
            // pictureBoxKamera
            // 
            this.pictureBoxKamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxKamera.Location = new System.Drawing.Point(141, 74);
            this.pictureBoxKamera.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxKamera.Name = "pictureBoxKamera";
            this.pictureBoxKamera.Size = new System.Drawing.Size(148, 118);
            this.pictureBoxKamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKamera.TabIndex = 5;
            this.pictureBoxKamera.TabStop = false;
            // 
            // btnQRTara
            // 
            this.btnQRTara.BackColor = System.Drawing.Color.White;
            this.btnQRTara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRTara.Location = new System.Drawing.Point(218, 223);
            this.btnQRTara.Margin = new System.Windows.Forms.Padding(2);
            this.btnQRTara.Name = "btnQRTara";
            this.btnQRTara.Size = new System.Drawing.Size(99, 31);
            this.btnQRTara.TabIndex = 3;
            this.btnQRTara.Text = "QR Tara";
            this.btnQRTara.UseVisualStyleBackColor = false;
            this.btnQRTara.Click += new System.EventHandler(this.btnQRTara_Click);
            // 
            // btnKameraAç
            // 
            this.btnKameraAç.BackColor = System.Drawing.Color.White;
            this.btnKameraAç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKameraAç.Location = new System.Drawing.Point(100, 223);
            this.btnKameraAç.Margin = new System.Windows.Forms.Padding(2);
            this.btnKameraAç.Name = "btnKameraAç";
            this.btnKameraAç.Size = new System.Drawing.Size(114, 31);
            this.btnKameraAç.TabIndex = 2;
            this.btnKameraAç.Text = "Kamera Aç";
            this.btnKameraAç.UseVisualStyleBackColor = false;
            this.btnKameraAç.Click += new System.EventHandler(this.btnKameraAç_Click);
            // 
            // lblKamera
            // 
            this.lblKamera.AutoSize = true;
            this.lblKamera.Location = new System.Drawing.Point(32, 22);
            this.lblKamera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKamera.Name = "lblKamera";
            this.lblKamera.Size = new System.Drawing.Size(104, 26);
            this.lblKamera.TabIndex = 0;
            this.lblKamera.Text = "Kamera:";
            // 
            // timerQR
            // 
            this.timerQR.Tick += new System.EventHandler(this.timerQR_Tick);
            // 
            // checkŞifreyiGöster
            // 
            this.checkŞifreyiGöster.AutoSize = true;
            this.checkŞifreyiGöster.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkŞifreyiGöster.Location = new System.Drawing.Point(346, 92);
            this.checkŞifreyiGöster.Margin = new System.Windows.Forms.Padding(2);
            this.checkŞifreyiGöster.Name = "checkŞifreyiGöster";
            this.checkŞifreyiGöster.Size = new System.Drawing.Size(144, 26);
            this.checkŞifreyiGöster.TabIndex = 6;
            this.checkŞifreyiGöster.Text = "Şifreyi Göster";
            this.checkŞifreyiGöster.UseVisualStyleBackColor = true;
            this.checkŞifreyiGöster.CheckedChanged += new System.EventHandler(this.checkŞifreyiGöster_CheckedChanged);
            // 
            // txtQR
            // 
            this.txtQR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQR.Location = new System.Drawing.Point(154, 82);
            this.txtQR.Margin = new System.Windows.Forms.Padding(2);
            this.txtQR.Name = "txtQR";
            this.txtQR.PasswordChar = '*';
            this.txtQR.Size = new System.Drawing.Size(188, 34);
            this.txtQR.TabIndex = 7;
            // 
            // btnŞifremiUnuttum
            // 
            this.btnŞifremiUnuttum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnŞifremiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnŞifremiUnuttum.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnŞifremiUnuttum.Location = new System.Drawing.Point(178, 190);
            this.btnŞifremiUnuttum.Margin = new System.Windows.Forms.Padding(2);
            this.btnŞifremiUnuttum.Name = "btnŞifremiUnuttum";
            this.btnŞifremiUnuttum.Size = new System.Drawing.Size(141, 35);
            this.btnŞifremiUnuttum.TabIndex = 9;
            this.btnŞifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnŞifremiUnuttum.UseVisualStyleBackColor = false;
            this.btnŞifremiUnuttum.Click += new System.EventHandler(this.btnŞifremiUnuttum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SİNEMA_OTOMASYONU.Properties.Resources.BaCHelSinema;
            this.pictureBox1.Location = new System.Drawing.Point(385, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnGiriş
            // 
            this.btnGiriş.BackColor = System.Drawing.Color.White;
            this.btnGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiriş.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriş.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiriş.ImageIndex = 0;
            this.btnGiriş.ImageList = this.ımageList1;
            this.btnGiriş.Location = new System.Drawing.Point(178, 131);
            this.btnGiriş.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(141, 55);
            this.btnGiriş.TabIndex = 0;
            this.btnGiriş.Text = "Giriş Yap";
            this.btnGiriş.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiriş.UseVisualStyleBackColor = false;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // KullanıcıGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 516);
            this.Controls.Add(this.btnŞifremiUnuttum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.checkŞifreyiGöster);
            this.Controls.Add(this.pnlQR);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.btnGiriş);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "KullanıcıGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullanıcıGiriş_FormClosing);
            this.Load += new System.EventHandler(this.KullanıcıGiriş_Load_1);
            this.pnlQR.ResumeLayout(false);
            this.pnlQR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.Panel pnlQR;
        private System.Windows.Forms.PictureBox pictureBoxKamera;
        private System.Windows.Forms.Button btnQRTara;
        private System.Windows.Forms.Button btnKameraAç;
        private System.Windows.Forms.Label lblKamera;
        private System.Windows.Forms.Timer timerQR;
        private System.Windows.Forms.CheckBox checkŞifreyiGöster;
        private System.Windows.Forms.ComboBox comboBoxKamera;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnŞifremiUnuttum;
    }
}

