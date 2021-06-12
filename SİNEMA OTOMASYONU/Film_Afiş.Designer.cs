namespace SİNEMA_OTOMASYONU
{
    partial class Film_Afiş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film_Afiş));
            this.comboFilmler = new System.Windows.Forms.ComboBox();
            this.lblFilmAfişleri = new System.Windows.Forms.Label();
            this.lblFragman = new System.Windows.Forms.Label();
            this.pctrFilmAfişleri = new System.Windows.Forms.PictureBox();
            this.axFragman = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblFilmİsimleri = new System.Windows.Forms.Label();
            this.lblIMDB = new System.Windows.Forms.Label();
            this.pctrIMDB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrFilmAfişleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFragman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrIMDB)).BeginInit();
            this.SuspendLayout();
            // 
            // comboFilmler
            // 
            this.comboFilmler.FormattingEnabled = true;
            this.comboFilmler.Location = new System.Drawing.Point(94, 152);
            this.comboFilmler.Margin = new System.Windows.Forms.Padding(7);
            this.comboFilmler.Name = "comboFilmler";
            this.comboFilmler.Size = new System.Drawing.Size(219, 43);
            this.comboFilmler.TabIndex = 0;
            this.comboFilmler.SelectedIndexChanged += new System.EventHandler(this.comboFilmler_SelectedIndexChanged);
            // 
            // lblFilmAfişleri
            // 
            this.lblFilmAfişleri.AutoSize = true;
            this.lblFilmAfişleri.Location = new System.Drawing.Point(472, 53);
            this.lblFilmAfişleri.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFilmAfişleri.Name = "lblFilmAfişleri";
            this.lblFilmAfişleri.Size = new System.Drawing.Size(172, 35);
            this.lblFilmAfişleri.TabIndex = 1;
            this.lblFilmAfişleri.Text = "Film Afişleri";
            // 
            // lblFragman
            // 
            this.lblFragman.AutoSize = true;
            this.lblFragman.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFragman.Location = new System.Drawing.Point(936, 53);
            this.lblFragman.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFragman.Name = "lblFragman";
            this.lblFragman.Size = new System.Drawing.Size(204, 35);
            this.lblFragman.TabIndex = 2;
            this.lblFragman.Text = "Film Fragmanı";
            // 
            // pctrFilmAfişleri
            // 
            this.pctrFilmAfişleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrFilmAfişleri.Location = new System.Drawing.Point(349, 106);
            this.pctrFilmAfişleri.Name = "pctrFilmAfişleri";
            this.pctrFilmAfişleri.Size = new System.Drawing.Size(390, 429);
            this.pctrFilmAfişleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrFilmAfişleri.TabIndex = 3;
            this.pctrFilmAfişleri.TabStop = false;
            // 
            // axFragman
            // 
            this.axFragman.Enabled = true;
            this.axFragman.Location = new System.Drawing.Point(770, 106);
            this.axFragman.Name = "axFragman";
            this.axFragman.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFragman.OcxState")));
            this.axFragman.Size = new System.Drawing.Size(491, 429);
            this.axFragman.TabIndex = 4;
            // 
            // lblFilmİsimleri
            // 
            this.lblFilmİsimleri.AutoSize = true;
            this.lblFilmİsimleri.Location = new System.Drawing.Point(10, 155);
            this.lblFilmİsimleri.Name = "lblFilmİsimleri";
            this.lblFilmİsimleri.Size = new System.Drawing.Size(84, 35);
            this.lblFilmİsimleri.TabIndex = 5;
            this.lblFilmİsimleri.Text = "Film:";
            // 
            // lblIMDB
            // 
            this.lblIMDB.AutoSize = true;
            this.lblIMDB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIMDB.Location = new System.Drawing.Point(77, 345);
            this.lblIMDB.Name = "lblIMDB";
            this.lblIMDB.Size = new System.Drawing.Size(236, 26);
            this.lblIMDB.TabIndex = 6;
            this.lblIMDB.Text = "Daha Fazla Bilgi İçin:";
            // 
            // pctrIMDB
            // 
            this.pctrIMDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrIMDB.Location = new System.Drawing.Point(82, 385);
            this.pctrIMDB.Name = "pctrIMDB";
            this.pctrIMDB.Size = new System.Drawing.Size(180, 150);
            this.pctrIMDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrIMDB.TabIndex = 7;
            this.pctrIMDB.TabStop = false;
            // 
            // Film_Afiş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1287, 574);
            this.Controls.Add(this.pctrIMDB);
            this.Controls.Add(this.lblIMDB);
            this.Controls.Add(this.lblFilmİsimleri);
            this.Controls.Add(this.axFragman);
            this.Controls.Add(this.pctrFilmAfişleri);
            this.Controls.Add(this.lblFragman);
            this.Controls.Add(this.lblFilmAfişleri);
            this.Controls.Add(this.comboFilmler);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Film_Afiş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİLM GÖRSELLERİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Film_Afiş_FormClosing);
            this.Load += new System.EventHandler(this.Film_Afiş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrFilmAfişleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFragman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrIMDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFilmler;
        private System.Windows.Forms.Label lblFilmAfişleri;
        private System.Windows.Forms.Label lblFragman;
        private System.Windows.Forms.PictureBox pctrFilmAfişleri;
        private AxWMPLib.AxWindowsMediaPlayer axFragman;
        private System.Windows.Forms.Label lblFilmİsimleri;
        private System.Windows.Forms.Label lblIMDB;
        private System.Windows.Forms.PictureBox pctrIMDB;
    }
}