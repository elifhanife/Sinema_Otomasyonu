namespace SİNEMA_OTOMASYONU
{
    partial class Büfe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Büfe));
            this.btnBüfeGüncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBüfeEkle = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblBüfeFiyat = new System.Windows.Forms.Label();
            this.lblBüfeÜrün = new System.Windows.Forms.Label();
            this.txtBüfeÜrün = new System.Windows.Forms.TextBox();
            this.txtBüfeFiyat = new System.Windows.Forms.TextBox();
            this.listViewBüfe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBüfeGüncelle
            // 
            this.btnBüfeGüncelle.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBüfeGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBüfeGüncelle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBüfeGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBüfeGüncelle.ImageIndex = 0;
            this.btnBüfeGüncelle.ImageList = this.ımageList1;
            this.btnBüfeGüncelle.Location = new System.Drawing.Point(180, 178);
            this.btnBüfeGüncelle.Name = "btnBüfeGüncelle";
            this.btnBüfeGüncelle.Size = new System.Drawing.Size(163, 49);
            this.btnBüfeGüncelle.TabIndex = 0;
            this.btnBüfeGüncelle.Text = "DEĞİŞTİR";
            this.btnBüfeGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBüfeGüncelle.UseVisualStyleBackColor = false;
            this.btnBüfeGüncelle.Click += new System.EventHandler(this.btnBüfeGüncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "çöp_icon.png");
            // 
            // btnBüfeEkle
            // 
            this.btnBüfeEkle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBüfeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBüfeEkle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBüfeEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBüfeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBüfeEkle.ImageIndex = 0;
            this.btnBüfeEkle.ImageList = this.ımageList2;
            this.btnBüfeEkle.Location = new System.Drawing.Point(26, 178);
            this.btnBüfeEkle.Name = "btnBüfeEkle";
            this.btnBüfeEkle.Size = new System.Drawing.Size(133, 49);
            this.btnBüfeEkle.TabIndex = 1;
            this.btnBüfeEkle.Text = "EKLE";
            this.btnBüfeEkle.UseVisualStyleBackColor = false;
            this.btnBüfeEkle.Click += new System.EventHandler(this.btnBüfeEkle_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "BüfeEkle_icon.png");
            // 
            // lblBüfeFiyat
            // 
            this.lblBüfeFiyat.AutoSize = true;
            this.lblBüfeFiyat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBüfeFiyat.Location = new System.Drawing.Point(41, 97);
            this.lblBüfeFiyat.Name = "lblBüfeFiyat";
            this.lblBüfeFiyat.Size = new System.Drawing.Size(87, 32);
            this.lblBüfeFiyat.TabIndex = 2;
            this.lblBüfeFiyat.Text = "Fiyat:";
            // 
            // lblBüfeÜrün
            // 
            this.lblBüfeÜrün.AutoSize = true;
            this.lblBüfeÜrün.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBüfeÜrün.Location = new System.Drawing.Point(42, 45);
            this.lblBüfeÜrün.Name = "lblBüfeÜrün";
            this.lblBüfeÜrün.Size = new System.Drawing.Size(88, 32);
            this.lblBüfeÜrün.TabIndex = 3;
            this.lblBüfeÜrün.Text = "Ürün:";
            // 
            // txtBüfeÜrün
            // 
            this.txtBüfeÜrün.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBüfeÜrün.Location = new System.Drawing.Point(107, 43);
            this.txtBüfeÜrün.Name = "txtBüfeÜrün";
            this.txtBüfeÜrün.Size = new System.Drawing.Size(193, 39);
            this.txtBüfeÜrün.TabIndex = 4;
            // 
            // txtBüfeFiyat
            // 
            this.txtBüfeFiyat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBüfeFiyat.Location = new System.Drawing.Point(107, 95);
            this.txtBüfeFiyat.Name = "txtBüfeFiyat";
            this.txtBüfeFiyat.Size = new System.Drawing.Size(193, 39);
            this.txtBüfeFiyat.TabIndex = 5;
            // 
            // listViewBüfe
            // 
            this.listViewBüfe.BackColor = System.Drawing.SystemColors.Info;
            this.listViewBüfe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewBüfe.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewBüfe.ForeColor = System.Drawing.Color.Black;
            this.listViewBüfe.HideSelection = false;
            this.listViewBüfe.Location = new System.Drawing.Point(374, 23);
            this.listViewBüfe.Name = "listViewBüfe";
            this.listViewBüfe.Size = new System.Drawing.Size(264, 204);
            this.listViewBüfe.TabIndex = 11;
            this.listViewBüfe.UseCompatibleStateImageBehavior = false;
            this.listViewBüfe.View = System.Windows.Forms.View.Details;
            this.listViewBüfe.SelectedIndexChanged += new System.EventHandler(this.listViewBüfe_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.Width = 79;
            // 
            // Büfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(662, 252);
            this.Controls.Add(this.listViewBüfe);
            this.Controls.Add(this.txtBüfeFiyat);
            this.Controls.Add(this.txtBüfeÜrün);
            this.Controls.Add(this.lblBüfeÜrün);
            this.Controls.Add(this.lblBüfeFiyat);
            this.Controls.Add(this.btnBüfeEkle);
            this.Controls.Add(this.btnBüfeGüncelle);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Büfe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Büfe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Büfe_FormClosing);
            this.Load += new System.EventHandler(this.Büfe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBüfeGüncelle;
        private System.Windows.Forms.Button btnBüfeEkle;
        private System.Windows.Forms.Label lblBüfeFiyat;
        private System.Windows.Forms.Label lblBüfeÜrün;
        private System.Windows.Forms.TextBox txtBüfeÜrün;
        private System.Windows.Forms.TextBox txtBüfeFiyat;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ListView listViewBüfe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}