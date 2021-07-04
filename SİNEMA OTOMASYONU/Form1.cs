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
using System.IO;
using AForge; //Bilgisayar kamera sistemine erişim
using AForge.Video; //için kullanılan
using AForge.Video.DirectShow; //kütüphaneler
using ZXing; //Kod taratmak için 
using ZXing.Aztec; //kullanılan kütüphaneler
using MessagingToolkit.QRCode; //QR oluşturmak için
using MessagingToolkit.QRCode.Codec; //gerekli kütüphaneler

namespace SİNEMA_OTOMASYONU
{
    public partial class KullanıcıGiriş : Form
    {

        FilterInfoCollection webcam;//bilgisayarı bağlı tüm kameralar
        VideoCaptureDevice cam;//o an kullanılan kamera

        public KullanıcıGiriş()
        {
            InitializeComponent();
        }

        OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbConnection bağlantı = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\hanif\\OneDrive\\Desktop\\Kullanıcı Giriş 2002-2003.mdb");

        //Veritabanından kullanıcı adı ve şifreyi alarak giriş yaptırır.
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            string ad = txtKullanıcıAdı.Text;
            string sifre = txtQR.Text;
            cmd = new OleDbCommand();
            bağlantı.Open();
            cmd.Connection = bağlantı;
            cmd.CommandText = "Select * From Kullanıcı_Giriş where k_ad ='" + txtKullanıcıAdı.Text + "'AND k_sifre='" + txtQR.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (dr["k_ad"].ToString() == "admin" && dr["k_sifre"].ToString() == "admin")
                {
                    AdminAnasayfa yeni1 = new AdminAnasayfa();
                    yeni1.Show();
                    this.Hide();
                }
                else
                {
                    Anasayfa yeni = new Anasayfa();
                    yeni.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!!!");
                bağlantı.Close();
            }
        }

        // Şifreyi yıldızlayarak gizler.
        private void checkŞifreyiGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkŞifreyiGöster.Checked)
            {
                txtQR.PasswordChar = '\0';
            }
            else
            {
                txtQR.PasswordChar = '*';
            }
        }

        private void btnŞifremiUnuttum_Click(object sender, EventArgs e)
        {
            ŞifremiUnuttum yeni = new ŞifremiUnuttum();
            yeni.Show();
            this.Hide();
        }

        //Bilgisayara bağlı kameraları görüntüler ve seçilmesini sağlar
        private void KameraKontrol()
        {
                comboBoxKamera.Text = "Seçiniz";
                webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo dev in webcam)
                {
                    comboBoxKamera.Items.Add(dev.Name);
                }
        }

        private void KullanıcıGiriş_Load_1(object sender, EventArgs e)
        {
            KameraKontrol();
        }

        //Kameradan gelen görüntüyü pictureBox'da görüntülemeyi sağlar
        private void Kamera(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxKamera.Image = ((Bitmap)eventArgs.Frame.Clone());
        }

        //Kamera açmayı sağlar
        private void btnKameraAç_Click(object sender, EventArgs e)
        {
            try
            {
                cam = new VideoCaptureDevice(webcam[comboBoxKamera.SelectedIndex].MonikerString);
                cam.NewFrame += new NewFrameEventHandler(Kamera);
                cam.Start();
            }
            catch(Exception)
            {
                MessageBox.Show("Kamera Bulunamadı!");
            }
        }

        //timer kullanarak QR'ın taranmasını sağlar
        private void btnQRTara_Click(object sender, EventArgs e)
        {
            timerQR.Enabled = true;
            timerQR.Start();
        }

        //pictureBox'dan görüntüyü yakalayana kadar kodun çalışmasını sağlar
        private void timerQR_Tick(object sender, EventArgs e)
        {
            if (pictureBoxKamera.Image != null)
            {
                BarcodeReader barkod = new BarcodeReader();

                Result sonuç = barkod.Decode((Bitmap)pictureBoxKamera.Image);

                if (sonuç != null)
                {
                    txtQR.Text = sonuç.ToString(); //QR koddan gelen şifreyi şifre textbox ına aktarır.
                    timerQR.Stop();
                    if (cam.IsRunning)
                    {
                        cam.Stop();
                    }
                }

                else if (sonuç == null)
                {
                    timerQR.Stop();
                    MessageBox.Show("Karekod Okunamadı");
                }
            }

            else if (pictureBoxKamera.Image == null)
            {
                timerQR.Stop();
                MessageBox.Show("Kamera ile Karekodu Okutunuz");
            }
        }

        //pictureboxta görüntüyü yakalanınca kamerayı kapatır.
        private void KullanıcıGiriş_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
            {
                if (cam.IsRunning == true)
                {
                    cam.Stop();
                }
            }
        }
    }
}