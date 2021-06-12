namespace SİNEMA_OTOMASYONU
{
    partial class ŞifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ŞifremiUnuttum));
            this.lblKullanıcı = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btnGönder = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblKullanıcı
            // 
            this.lblKullanıcı.AutoSize = true;
            this.lblKullanıcı.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcı.Location = new System.Drawing.Point(19, 33);
            this.lblKullanıcı.Name = "lblKullanıcı";
            this.lblKullanıcı.Size = new System.Drawing.Size(186, 32);
            this.lblKullanıcı.TabIndex = 2;
            this.lblKullanıcı.Text = "Kullanıcı Adı:";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmail.Location = new System.Drawing.Point(90, 78);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(95, 32);
            this.lblmail.TabIndex = 3;
            this.lblmail.Text = "Email:";
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcı.Location = new System.Drawing.Point(162, 30);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(238, 39);
            this.txtKullanıcı.TabIndex = 4;
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Location = new System.Drawing.Point(162, 75);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(238, 39);
            this.txtmail.TabIndex = 5;
            // 
            // btnGönder
            // 
            this.btnGönder.BackColor = System.Drawing.Color.White;
            this.btnGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGönder.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGönder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGönder.ImageIndex = 0;
            this.btnGönder.ImageList = this.ımageList1;
            this.btnGönder.Location = new System.Drawing.Point(184, 145);
            this.btnGönder.Margin = new System.Windows.Forms.Padding(2);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(154, 62);
            this.btnGönder.TabIndex = 6;
            this.btnGönder.Text = "GÖNDER";
            this.btnGönder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGönder.UseVisualStyleBackColor = false;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "şifre_icon.png");
            // 
            // ŞifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 230);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.lblKullanıcı);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "ŞifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Hatırlatma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ŞifremiUnuttum_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKullanıcı;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.ImageList ımageList1;
    }
}