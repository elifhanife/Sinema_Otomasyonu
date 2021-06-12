using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;


namespace SİNEMA_OTOMASYONU
{
    public partial class ŞifremiUnuttum : Form
    {
        OleDbConnection bağlantı = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\hanif\\OneDrive\\Desktop\\Kullanıcı Giriş 2002-2003.mdb");
        public ŞifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kullanıcı_Giriş Where k_ad = '" + txtKullanıcı.Text.ToString() + "' and email = '" + txtmail.Text.ToString() + "'", bağlantı);
            OleDbDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                try
                {
                    SmtpClient smptserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    String mailadresin = ("bachelsinema@gmail.com");
                    String şifre = ("bachel2019");
                    String smptsrvr = "smtp.gmail.com";
                    String kime = (read["email"]).ToString();
                    String konu = ("Şifre hatırlatma maili");
                    String yaz = ("Sayın " + read["k_ad"].ToString() + "\n" + "Bizden " + tarih + " Tarihinde Şifre Hatırlatma Talebinde Bulundunuz." + "\n" + "Parolanız: " + read["k_sifre"].ToString() + "\nİyi Günler");
                    smptserver.Credentials = new NetworkCredential(mailadresin, şifre);
                    smptserver.Port = 587;
                    smptserver.Host = smptsrvr;
                    smptserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smptserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Bilgiler uyuşuyor şifreniz mail adresinize gönderildi.","Şifre Hatırlatma",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Hata)
                {
                    MessageBox.Show(Hata.Message,"Mail gönderme hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            bağlantı.Close();
        }

        private void ŞifremiUnuttum_FormClosing(object sender, FormClosingEventArgs e)
        {
            KullanıcıGiriş yeni = new KullanıcıGiriş();
            yeni.Show();
        }
    }
}