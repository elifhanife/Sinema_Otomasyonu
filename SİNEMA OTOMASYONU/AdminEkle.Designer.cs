namespace SİNEMA_OTOMASYONU
{
    partial class AdminEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEkle));
            this.txtYeniŞifre = new System.Windows.Forms.TextBox();
            this.txtYeniAdmin = new System.Windows.Forms.TextBox();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtYeniMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAdminSil = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdminGüncelle = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.listViewAdmin = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSil = new System.Windows.Forms.Label();
            this.txtSil = new System.Windows.Forms.TextBox();
            this.txtGüncelle = new System.Windows.Forms.TextBox();
            this.lblGüncelle = new System.Windows.Forms.Label();
            this.checkŞifreyiGöster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtYeniŞifre
            // 
            this.txtYeniŞifre.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniŞifre.Location = new System.Drawing.Point(143, 73);
            this.txtYeniŞifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniŞifre.Name = "txtYeniŞifre";
            this.txtYeniŞifre.PasswordChar = '*';
            this.txtYeniŞifre.Size = new System.Drawing.Size(249, 34);
            this.txtYeniŞifre.TabIndex = 12;
            // 
            // txtYeniAdmin
            // 
            this.txtYeniAdmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniAdmin.Location = new System.Drawing.Point(143, 33);
            this.txtYeniAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniAdmin.Name = "txtYeniAdmin";
            this.txtYeniAdmin.Size = new System.Drawing.Size(249, 34);
            this.txtYeniAdmin.TabIndex = 11;
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifre.Location = new System.Drawing.Point(86, 76);
            this.lblŞifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(69, 26);
            this.lblŞifre.TabIndex = 10;
            this.lblŞifre.Text = "Şifre:";
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(21, 36);
            this.lblKullanıcıAdı.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(158, 26);
            this.lblKullanıcıAdı.TabIndex = 9;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdminEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEkle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminEkle.ImageIndex = 0;
            this.btnAdminEkle.ImageList = this.ımageList1;
            this.btnAdminEkle.Location = new System.Drawing.Point(40, 187);
            this.btnAdminEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Size = new System.Drawing.Size(106, 55);
            this.btnAdminEkle.TabIndex = 8;
            this.btnAdminEkle.Text = "EKLE";
            this.btnAdminEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminEkle.UseVisualStyleBackColor = false;
            this.btnAdminEkle.Click += new System.EventHandler(this.btnAdminEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "adminekle_icon.png");
            // 
            // txtYeniMail
            // 
            this.txtYeniMail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniMail.Location = new System.Drawing.Point(143, 118);
            this.txtYeniMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtYeniMail.Name = "txtYeniMail";
            this.txtYeniMail.Size = new System.Drawing.Size(249, 34);
            this.txtYeniMail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(78, 121);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 26);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // btnAdminSil
            // 
            this.btnAdminSil.BackColor = System.Drawing.Color.Salmon;
            this.btnAdminSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminSil.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminSil.ImageIndex = 0;
            this.btnAdminSil.ImageList = this.ımageList2;
            this.btnAdminSil.Location = new System.Drawing.Point(164, 187);
            this.btnAdminSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminSil.Name = "btnAdminSil";
            this.btnAdminSil.Size = new System.Drawing.Size(91, 55);
            this.btnAdminSil.TabIndex = 15;
            this.btnAdminSil.Text = "SİL";
            this.btnAdminSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminSil.UseVisualStyleBackColor = false;
            this.btnAdminSil.Click += new System.EventHandler(this.btnAdminSil_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "çöp_icon.png");
            // 
            // btnAdminGüncelle
            // 
            this.btnAdminGüncelle.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAdminGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGüncelle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminGüncelle.ImageIndex = 0;
            this.btnAdminGüncelle.ImageList = this.ımageList3;
            this.btnAdminGüncelle.Location = new System.Drawing.Point(270, 187);
            this.btnAdminGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminGüncelle.Name = "btnAdminGüncelle";
            this.btnAdminGüncelle.Size = new System.Drawing.Size(153, 55);
            this.btnAdminGüncelle.TabIndex = 16;
            this.btnAdminGüncelle.Text = "GÜNCELLE";
            this.btnAdminGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminGüncelle.UseVisualStyleBackColor = false;
            this.btnAdminGüncelle.Click += new System.EventHandler(this.btnAdminGüncelle_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "güncelleme_icon.png");
            // 
            // listViewAdmin
            // 
            this.listViewAdmin.BackColor = System.Drawing.SystemColors.Info;
            this.listViewAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewAdmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewAdmin.HideSelection = false;
            this.listViewAdmin.Location = new System.Drawing.Point(554, 12);
            this.listViewAdmin.Name = "listViewAdmin";
            this.listViewAdmin.Size = new System.Drawing.Size(382, 181);
            this.listViewAdmin.TabIndex = 17;
            this.listViewAdmin.UseCompatibleStateImageBehavior = false;
            this.listViewAdmin.View = System.Windows.Forms.View.Details;
            this.listViewAdmin.SelectedIndexChanged += new System.EventHandler(this.listViewAdmin_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kullanıcı Adı";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Şifre";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 136;
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSil.Location = new System.Drawing.Point(491, 215);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(145, 26);
            this.lblSil.TabIndex = 18;
            this.lblSil.Text = "Silinecek ID:";
            // 
            // txtSil
            // 
            this.txtSil.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSil.Location = new System.Drawing.Point(606, 208);
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(50, 34);
            this.txtSil.TabIndex = 19;
            this.txtSil.Text = "0";
            // 
            // txtGüncelle
            // 
            this.txtGüncelle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGüncelle.Location = new System.Drawing.Point(825, 208);
            this.txtGüncelle.Name = "txtGüncelle";
            this.txtGüncelle.Size = new System.Drawing.Size(46, 34);
            this.txtGüncelle.TabIndex = 21;
            this.txtGüncelle.Text = "0";
            // 
            // lblGüncelle
            // 
            this.lblGüncelle.AutoSize = true;
            this.lblGüncelle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGüncelle.Location = new System.Drawing.Point(662, 215);
            this.lblGüncelle.Name = "lblGüncelle";
            this.lblGüncelle.Size = new System.Drawing.Size(202, 26);
            this.lblGüncelle.TabIndex = 20;
            this.lblGüncelle.Text = "Güncellenecek ID:";
            // 
            // checkŞifreyiGöster
            // 
            this.checkŞifreyiGöster.AutoSize = true;
            this.checkŞifreyiGöster.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkŞifreyiGöster.Location = new System.Drawing.Point(396, 78);
            this.checkŞifreyiGöster.Margin = new System.Windows.Forms.Padding(2);
            this.checkŞifreyiGöster.Name = "checkŞifreyiGöster";
            this.checkŞifreyiGöster.Size = new System.Drawing.Size(144, 26);
            this.checkŞifreyiGöster.TabIndex = 22;
            this.checkŞifreyiGöster.Text = "Şifreyi Göster";
            this.checkŞifreyiGöster.UseVisualStyleBackColor = true;
            this.checkŞifreyiGöster.CheckedChanged += new System.EventHandler(this.checkŞifreyiGöster_CheckedChanged);
            // 
            // AdminEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(958, 262);
            this.Controls.Add(this.checkŞifreyiGöster);
            this.Controls.Add(this.txtGüncelle);
            this.Controls.Add(this.lblGüncelle);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.lblSil);
            this.Controls.Add(this.listViewAdmin);
            this.Controls.Add(this.btnAdminGüncelle);
            this.Controls.Add(this.btnAdminSil);
            this.Controls.Add(this.txtYeniMail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtYeniŞifre);
            this.Controls.Add(this.txtYeniAdmin);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.btnAdminEkle);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AdminEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminEkle_FormClosing);
            this.Load += new System.EventHandler(this.AdminEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYeniŞifre;
        private System.Windows.Forms.TextBox txtYeniAdmin;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Button btnAdminEkle;
        private System.Windows.Forms.TextBox txtYeniMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdminSil;
        private System.Windows.Forms.Button btnAdminGüncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ListView listViewAdmin;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblSil;
        private System.Windows.Forms.TextBox txtSil;
        private System.Windows.Forms.TextBox txtGüncelle;
        private System.Windows.Forms.Label lblGüncelle;
        private System.Windows.Forms.CheckBox checkŞifreyiGöster;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList3;
    }
}