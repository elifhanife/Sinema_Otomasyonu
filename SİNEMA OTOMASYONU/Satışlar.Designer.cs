namespace SİNEMA_OTOMASYONU
{
    partial class Satışlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satışlar));
            this.listViewSatışlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblGünlükSatış = new System.Windows.Forms.Label();
            this.lblBiletToplam = new System.Windows.Forms.Label();
            this.lblSatış = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePickerToplamSatış2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToplamSatış1 = new System.Windows.Forms.DateTimePicker();
            this.btnTümSatış = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePickerToplamSatış3 = new System.Windows.Forms.DateTimePicker();
            this.btnAralık = new System.Windows.Forms.Button();
            this.ımageList4 = new System.Windows.Forms.ImageList(this.components);
            this.lblAranan = new System.Windows.Forms.Label();
            this.btnAranan = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.comboFilmAdı = new System.Windows.Forms.ComboBox();
            this.lblBiletSayısı = new System.Windows.Forms.Label();
            this.lblSatılanBilet = new System.Windows.Forms.Label();
            this.lblBüfeToplam = new System.Windows.Forms.Label();
            this.lblBüfeSatış = new System.Windows.Forms.Label();
            this.lblToplamKazanç = new System.Windows.Forms.Label();
            this.lblSatışToplam = new System.Windows.Forms.Label();
            this.btnFilm = new System.Windows.Forms.Button();
            this.lblTL1 = new System.Windows.Forms.Label();
            this.lblTL2 = new System.Windows.Forms.Label();
            this.lblTL3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewSatışlar
            // 
            this.listViewSatışlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewSatışlar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewSatışlar.HideSelection = false;
            this.listViewSatışlar.Location = new System.Drawing.Point(23, 21);
            this.listViewSatışlar.Name = "listViewSatışlar";
            this.listViewSatışlar.Size = new System.Drawing.Size(1300, 289);
            this.listViewSatışlar.TabIndex = 0;
            this.listViewSatışlar.UseCompatibleStateImageBehavior = false;
            this.listViewSatışlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bilet ID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Adı";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salon Adı";
            this.columnHeader3.Width = 166;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarih";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Saat";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Koltuk No";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ad";
            this.columnHeader7.Width = 61;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Soyad";
            this.columnHeader8.Width = 102;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ücret";
            this.columnHeader9.Width = 109;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Büfe Fiyat";
            this.columnHeader10.Width = 132;
            // 
            // lblGünlükSatış
            // 
            this.lblGünlükSatış.AutoSize = true;
            this.lblGünlükSatış.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGünlükSatış.Location = new System.Drawing.Point(12, 421);
            this.lblGünlükSatış.Name = "lblGünlükSatış";
            this.lblGünlükSatış.Size = new System.Drawing.Size(214, 26);
            this.lblGünlükSatış.TabIndex = 1;
            this.lblGünlükSatış.Text = "Günlük Bilet Satışı:";
            // 
            // lblBiletToplam
            // 
            this.lblBiletToplam.AutoSize = true;
            this.lblBiletToplam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBiletToplam.Location = new System.Drawing.Point(496, 339);
            this.lblBiletToplam.Name = "lblBiletToplam";
            this.lblBiletToplam.Size = new System.Drawing.Size(24, 26);
            this.lblBiletToplam.TabIndex = 20;
            this.lblBiletToplam.Text = "0";
            // 
            // lblSatış
            // 
            this.lblSatış.AutoSize = true;
            this.lblSatış.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatış.Location = new System.Drawing.Point(356, 339);
            this.lblSatış.Name = "lblSatış";
            this.lblSatış.Size = new System.Drawing.Size(151, 26);
            this.lblSatış.TabIndex = 19;
            this.lblSatış.Text = "Bilet Toplam:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Thistle;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapla.ImageIndex = 0;
            this.btnHesapla.ImageList = this.ımageList1;
            this.btnHesapla.Location = new System.Drawing.Point(423, 415);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(112, 44);
            this.btnHesapla.TabIndex = 23;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "hesapla_icon.png");
            // 
            // dateTimePickerToplamSatış2
            // 
            this.dateTimePickerToplamSatış2.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerToplamSatış2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerToplamSatış2.Location = new System.Drawing.Point(930, 418);
            this.dateTimePickerToplamSatış2.Name = "dateTimePickerToplamSatış2";
            this.dateTimePickerToplamSatış2.Size = new System.Drawing.Size(216, 34);
            this.dateTimePickerToplamSatış2.TabIndex = 22;
            // 
            // dateTimePickerToplamSatış1
            // 
            this.dateTimePickerToplamSatış1.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerToplamSatış1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerToplamSatış1.Location = new System.Drawing.Point(190, 419);
            this.dateTimePickerToplamSatış1.Name = "dateTimePickerToplamSatış1";
            this.dateTimePickerToplamSatış1.Size = new System.Drawing.Size(216, 34);
            this.dateTimePickerToplamSatış1.TabIndex = 21;
            // 
            // btnTümSatış
            // 
            this.btnTümSatış.BackColor = System.Drawing.Color.Thistle;
            this.btnTümSatış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTümSatış.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTümSatış.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTümSatış.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnTümSatış.ImageIndex = 0;
            this.btnTümSatış.ImageList = this.ımageList3;
            this.btnTümSatış.Location = new System.Drawing.Point(35, 499);
            this.btnTümSatış.Name = "btnTümSatış";
            this.btnTümSatış.Size = new System.Drawing.Size(171, 58);
            this.btnTümSatış.TabIndex = 24;
            this.btnTümSatış.Text = "Toplam Gelir";
            this.btnTümSatış.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTümSatış.UseVisualStyleBackColor = false;
            this.btnTümSatış.Click += new System.EventHandler(this.btnTümSatış_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "tümsatışlar_icon2.png");
            // 
            // dateTimePickerToplamSatış3
            // 
            this.dateTimePickerToplamSatış3.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerToplamSatış3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerToplamSatış3.Location = new System.Drawing.Point(708, 418);
            this.dateTimePickerToplamSatış3.Name = "dateTimePickerToplamSatış3";
            this.dateTimePickerToplamSatış3.Size = new System.Drawing.Size(216, 34);
            this.dateTimePickerToplamSatış3.TabIndex = 25;
            // 
            // btnAralık
            // 
            this.btnAralık.BackColor = System.Drawing.Color.Thistle;
            this.btnAralık.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAralık.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAralık.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAralık.ImageIndex = 0;
            this.btnAralık.ImageList = this.ımageList4;
            this.btnAralık.Location = new System.Drawing.Point(1164, 403);
            this.btnAralık.Name = "btnAralık";
            this.btnAralık.Size = new System.Drawing.Size(182, 62);
            this.btnAralık.TabIndex = 27;
            this.btnAralık.Text = "Aralığa Göre Hesapla";
            this.btnAralık.UseVisualStyleBackColor = false;
            this.btnAralık.Click += new System.EventHandler(this.btnAralık_Click);
            // 
            // ımageList4
            // 
            this.ımageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList4.ImageStream")));
            this.ımageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList4.Images.SetKeyName(0, "ikitarih_icon.png");
            // 
            // lblAranan
            // 
            this.lblAranan.AutoSize = true;
            this.lblAranan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAranan.Location = new System.Drawing.Point(711, 473);
            this.lblAranan.Name = "lblAranan";
            this.lblAranan.Size = new System.Drawing.Size(152, 26);
            this.lblAranan.TabIndex = 28;
            this.lblAranan.Text = "Aranan Film:";
            // 
            // btnAranan
            // 
            this.btnAranan.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAranan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAranan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAranan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAranan.ImageIndex = 0;
            this.btnAranan.ImageList = this.ımageList2;
            this.btnAranan.Location = new System.Drawing.Point(747, 515);
            this.btnAranan.Name = "btnAranan";
            this.btnAranan.Size = new System.Drawing.Size(177, 68);
            this.btnAranan.TabIndex = 30;
            this.btnAranan.Text = "Film ve Tarihe Göre Ara";
            this.btnAranan.UseVisualStyleBackColor = false;
            this.btnAranan.Click += new System.EventHandler(this.btnAranan_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "arama_icon.png");
            // 
            // comboFilmAdı
            // 
            this.comboFilmAdı.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboFilmAdı.FormattingEnabled = true;
            this.comboFilmAdı.Location = new System.Drawing.Point(838, 469);
            this.comboFilmAdı.Name = "comboFilmAdı";
            this.comboFilmAdı.Size = new System.Drawing.Size(308, 33);
            this.comboFilmAdı.TabIndex = 31;
            // 
            // lblBiletSayısı
            // 
            this.lblBiletSayısı.AutoSize = true;
            this.lblBiletSayısı.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBiletSayısı.Location = new System.Drawing.Point(61, 339);
            this.lblBiletSayısı.Name = "lblBiletSayısı";
            this.lblBiletSayısı.Size = new System.Drawing.Size(213, 26);
            this.lblBiletSayısı.TabIndex = 32;
            this.lblBiletSayısı.Text = "Satılan Bilet Sayısı:";
            // 
            // lblSatılanBilet
            // 
            this.lblSatılanBilet.AutoSize = true;
            this.lblSatılanBilet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatılanBilet.Location = new System.Drawing.Point(250, 339);
            this.lblSatılanBilet.Name = "lblSatılanBilet";
            this.lblSatılanBilet.Size = new System.Drawing.Size(24, 26);
            this.lblSatılanBilet.TabIndex = 33;
            this.lblSatılanBilet.Text = "0";
            // 
            // lblBüfeToplam
            // 
            this.lblBüfeToplam.AutoSize = true;
            this.lblBüfeToplam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBüfeToplam.Location = new System.Drawing.Point(789, 339);
            this.lblBüfeToplam.Name = "lblBüfeToplam";
            this.lblBüfeToplam.Size = new System.Drawing.Size(24, 26);
            this.lblBüfeToplam.TabIndex = 35;
            this.lblBüfeToplam.Text = "0";
            // 
            // lblBüfeSatış
            // 
            this.lblBüfeSatış.AutoSize = true;
            this.lblBüfeSatış.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBüfeSatış.Location = new System.Drawing.Point(650, 339);
            this.lblBüfeSatış.Name = "lblBüfeSatış";
            this.lblBüfeSatış.Size = new System.Drawing.Size(149, 26);
            this.lblBüfeSatış.TabIndex = 34;
            this.lblBüfeSatış.Text = "Büfe Toplam:";
            // 
            // lblToplamKazanç
            // 
            this.lblToplamKazanç.AutoSize = true;
            this.lblToplamKazanç.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKazanç.Location = new System.Drawing.Point(1085, 339);
            this.lblToplamKazanç.Name = "lblToplamKazanç";
            this.lblToplamKazanç.Size = new System.Drawing.Size(24, 26);
            this.lblToplamKazanç.TabIndex = 37;
            this.lblToplamKazanç.Text = "0";
            // 
            // lblSatışToplam
            // 
            this.lblSatışToplam.AutoSize = true;
            this.lblSatışToplam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatışToplam.Location = new System.Drawing.Point(937, 339);
            this.lblSatışToplam.Name = "lblSatışToplam";
            this.lblSatışToplam.Size = new System.Drawing.Size(157, 26);
            this.lblSatışToplam.TabIndex = 36;
            this.lblSatışToplam.Text = "Satış Toplam :";
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilm.ImageIndex = 0;
            this.btnFilm.ImageList = this.ımageList2;
            this.btnFilm.Location = new System.Drawing.Point(942, 515);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(168, 67);
            this.btnFilm.TabIndex = 38;
            this.btnFilm.Text = "Filme Göre Ara";
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click_1);
            // 
            // lblTL1
            // 
            this.lblTL1.AutoSize = true;
            this.lblTL1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTL1.Location = new System.Drawing.Point(556, 339);
            this.lblTL1.Name = "lblTL1";
            this.lblTL1.Size = new System.Drawing.Size(24, 26);
            this.lblTL1.TabIndex = 40;
            this.lblTL1.Text = "₺";
            // 
            // lblTL2
            // 
            this.lblTL2.AutoSize = true;
            this.lblTL2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTL2.Location = new System.Drawing.Point(839, 339);
            this.lblTL2.Name = "lblTL2";
            this.lblTL2.Size = new System.Drawing.Size(24, 26);
            this.lblTL2.TabIndex = 41;
            this.lblTL2.Text = "₺";
            // 
            // lblTL3
            // 
            this.lblTL3.AutoSize = true;
            this.lblTL3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTL3.Location = new System.Drawing.Point(1145, 339);
            this.lblTL3.Name = "lblTL3";
            this.lblTL3.Size = new System.Drawing.Size(24, 26);
            this.lblTL3.TabIndex = 42;
            this.lblTL3.Text = "₺";
            // 
            // Satışlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1358, 593);
            this.Controls.Add(this.lblTL3);
            this.Controls.Add(this.lblTL2);
            this.Controls.Add(this.lblTL1);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.lblToplamKazanç);
            this.Controls.Add(this.lblSatışToplam);
            this.Controls.Add(this.lblBüfeToplam);
            this.Controls.Add(this.lblBüfeSatış);
            this.Controls.Add(this.lblSatılanBilet);
            this.Controls.Add(this.lblBiletSayısı);
            this.Controls.Add(this.comboFilmAdı);
            this.Controls.Add(this.btnAranan);
            this.Controls.Add(this.lblAranan);
            this.Controls.Add(this.btnAralık);
            this.Controls.Add(this.dateTimePickerToplamSatış3);
            this.Controls.Add(this.btnTümSatış);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dateTimePickerToplamSatış2);
            this.Controls.Add(this.dateTimePickerToplamSatış1);
            this.Controls.Add(this.lblBiletToplam);
            this.Controls.Add(this.lblSatış);
            this.Controls.Add(this.lblGünlükSatış);
            this.Controls.Add(this.listViewSatışlar);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Satışlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Satışlar_FormClosing);
            this.Load += new System.EventHandler(this.Satışlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSatışlar;
        private System.Windows.Forms.Label lblGünlükSatış;
        private System.Windows.Forms.Label lblBiletToplam;
        private System.Windows.Forms.Label lblSatış;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DateTimePicker dateTimePickerToplamSatış2;
        private System.Windows.Forms.DateTimePicker dateTimePickerToplamSatış1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnTümSatış;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.DateTimePicker dateTimePickerToplamSatış3;
        private System.Windows.Forms.Button btnAralık;
        private System.Windows.Forms.Label lblAranan;
        private System.Windows.Forms.Button btnAranan;
        private System.Windows.Forms.ComboBox comboFilmAdı;
        private System.Windows.Forms.Label lblBiletSayısı;
        private System.Windows.Forms.Label lblSatılanBilet;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label lblBüfeToplam;
        private System.Windows.Forms.Label lblBüfeSatış;
        private System.Windows.Forms.Label lblToplamKazanç;
        private System.Windows.Forms.Label lblSatışToplam;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Label lblTL1;
        private System.Windows.Forms.Label lblTL2;
        private System.Windows.Forms.Label lblTL3;
    }
}