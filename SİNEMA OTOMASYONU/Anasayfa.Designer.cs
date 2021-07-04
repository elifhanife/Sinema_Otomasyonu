namespace SİNEMA_OTOMASYONU
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btnFilm = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSeans = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnBilet = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.ımageList4 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.White;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.ImageIndex = 0;
            this.btnFilm.ImageList = this.ımageList1;
            this.btnFilm.Location = new System.Drawing.Point(6, 68);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(218, 215);
            this.btnFilm.TabIndex = 0;
            this.btnFilm.Text = "FİLM";
            this.btnFilm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "film_icon.png");
            this.ımageList1.Images.SetKeyName(1, "seans_icon2.png");
            this.ımageList1.Images.SetKeyName(2, "seans_icon1.png");
            // 
            // btnSeans
            // 
            this.btnSeans.BackColor = System.Drawing.Color.White;
            this.btnSeans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeans.ImageIndex = 0;
            this.btnSeans.ImageList = this.ımageList3;
            this.btnSeans.Location = new System.Drawing.Point(238, 68);
            this.btnSeans.Name = "btnSeans";
            this.btnSeans.Size = new System.Drawing.Size(223, 215);
            this.btnSeans.TabIndex = 1;
            this.btnSeans.Text = "SEANS";
            this.btnSeans.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeans.UseVisualStyleBackColor = false;
            this.btnSeans.Click += new System.EventHandler(this.btnSeans_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "seans_icon2.png");
            // 
            // btnBilet
            // 
            this.btnBilet.BackColor = System.Drawing.Color.White;
            this.btnBilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilet.ImageIndex = 4;
            this.btnBilet.ImageList = this.ımageList2;
            this.btnBilet.Location = new System.Drawing.Point(476, 68);
            this.btnBilet.Name = "btnBilet";
            this.btnBilet.Size = new System.Drawing.Size(220, 215);
            this.btnBilet.TabIndex = 2;
            this.btnBilet.Text = "BİLET";
            this.btnBilet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBilet.UseVisualStyleBackColor = false;
            this.btnBilet.Click += new System.EventHandler(this.btnBilet_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "film_icon.png");
            this.ımageList2.Images.SetKeyName(1, "seans_icon2.png");
            this.ımageList2.Images.SetKeyName(2, "seans_icon1.png");
            this.ımageList2.Images.SetKeyName(3, "ticket.jpg");
            this.ımageList2.Images.SetKeyName(4, "bilet_icon.png");
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.BackColor = System.Drawing.Color.White;
            this.btnÇıkış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÇıkış.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.ImageIndex = 0;
            this.btnÇıkış.ImageList = this.ımageList4;
            this.btnÇıkış.Location = new System.Drawing.Point(704, 68);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(230, 215);
            this.btnÇıkış.TabIndex = 4;
            this.btnÇıkış.Text = "ÇIKIŞ";
            this.btnÇıkış.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnÇıkış.UseVisualStyleBackColor = false;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // ımageList4
            // 
            this.ımageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList4.ImageStream")));
            this.ımageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList4.Images.SetKeyName(0, "cıkıs_icon.png");
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SİNEMA_OTOMASYONU.Properties.Resources.anasayfa_arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 353);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnBilet);
            this.Controls.Add(this.btnSeans);
            this.Controls.Add(this.btnFilm);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anasayfa_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnSeans;
        private System.Windows.Forms.Button btnBilet;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList4;
    }
}