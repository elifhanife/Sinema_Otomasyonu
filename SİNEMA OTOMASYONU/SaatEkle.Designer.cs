namespace SİNEMA_OTOMASYONU
{
    partial class SaatEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaatEkle));
            this.txtSaatEkle = new System.Windows.Forms.TextBox();
            this.lblSaatEkle = new System.Windows.Forms.Label();
            this.btnSaatEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSaatDeğiştir = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.listViewSaatEkle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtSaatEkle
            // 
            this.txtSaatEkle.ForeColor = System.Drawing.Color.Black;
            this.txtSaatEkle.Location = new System.Drawing.Point(139, 78);
            this.txtSaatEkle.Name = "txtSaatEkle";
            this.txtSaatEkle.Size = new System.Drawing.Size(134, 27);
            this.txtSaatEkle.TabIndex = 6;
            // 
            // lblSaatEkle
            // 
            this.lblSaatEkle.AutoSize = true;
            this.lblSaatEkle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaatEkle.Location = new System.Drawing.Point(80, 76);
            this.lblSaatEkle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaatEkle.Name = "lblSaatEkle";
            this.lblSaatEkle.Size = new System.Drawing.Size(65, 26);
            this.lblSaatEkle.TabIndex = 5;
            this.lblSaatEkle.Text = "Saat:";
            // 
            // btnSaatEkle
            // 
            this.btnSaatEkle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSaatEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaatEkle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaatEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSaatEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaatEkle.ImageIndex = 0;
            this.btnSaatEkle.ImageList = this.ımageList1;
            this.btnSaatEkle.Location = new System.Drawing.Point(56, 144);
            this.btnSaatEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaatEkle.Name = "btnSaatEkle";
            this.btnSaatEkle.Size = new System.Drawing.Size(125, 52);
            this.btnSaatEkle.TabIndex = 4;
            this.btnSaatEkle.Text = "EKLE";
            this.btnSaatEkle.UseVisualStyleBackColor = false;
            this.btnSaatEkle.Click += new System.EventHandler(this.btnSaatEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle_icon1.png");
            // 
            // btnSaatDeğiştir
            // 
            this.btnSaatDeğiştir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaatDeğiştir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaatDeğiştir.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaatDeğiştir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaatDeğiştir.ImageIndex = 0;
            this.btnSaatDeğiştir.ImageList = this.ımageList2;
            this.btnSaatDeğiştir.Location = new System.Drawing.Point(189, 144);
            this.btnSaatDeğiştir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaatDeğiştir.Name = "btnSaatDeğiştir";
            this.btnSaatDeğiştir.Size = new System.Drawing.Size(148, 52);
            this.btnSaatDeğiştir.TabIndex = 7;
            this.btnSaatDeğiştir.Text = "GÜNCELLE";
            this.btnSaatDeğiştir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaatDeğiştir.UseVisualStyleBackColor = false;
            this.btnSaatDeğiştir.Click += new System.EventHandler(this.btnSaatDeğiştir_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "güncelleme_icon.png");
            // 
            // listViewSaatEkle
            // 
            this.listViewSaatEkle.BackColor = System.Drawing.SystemColors.Info;
            this.listViewSaatEkle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSaatEkle.ForeColor = System.Drawing.Color.Black;
            this.listViewSaatEkle.HideSelection = false;
            this.listViewSaatEkle.Location = new System.Drawing.Point(366, 21);
            this.listViewSaatEkle.Name = "listViewSaatEkle";
            this.listViewSaatEkle.Size = new System.Drawing.Size(178, 243);
            this.listViewSaatEkle.TabIndex = 10;
            this.listViewSaatEkle.UseCompatibleStateImageBehavior = false;
            this.listViewSaatEkle.View = System.Windows.Forms.View.Details;
            this.listViewSaatEkle.SelectedIndexChanged += new System.EventHandler(this.listViewSaatEkle_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Saatler";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 99;
            // 
            // SaatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(578, 288);
            this.Controls.Add(this.listViewSaatEkle);
            this.Controls.Add(this.btnSaatDeğiştir);
            this.Controls.Add(this.txtSaatEkle);
            this.Controls.Add(this.lblSaatEkle);
            this.Controls.Add(this.btnSaatEkle);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SaatEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaatEkle_FormClosing);
            this.Load += new System.EventHandler(this.SaatEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaatEkle;
        private System.Windows.Forms.Label lblSaatEkle;
        private System.Windows.Forms.Button btnSaatEkle;
        private System.Windows.Forms.Button btnSaatDeğiştir;
        private System.Windows.Forms.ListView listViewSaatEkle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}