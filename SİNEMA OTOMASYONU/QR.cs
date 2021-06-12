using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode; //QR oluşturmak için
using MessagingToolkit.QRCode.Codec; //gerekli kütüphaneler

namespace SİNEMA_OTOMASYONU
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();
        }

        QRCodeEncoder code = new QRCodeEncoder();//QR oluşturucu (kütüphane ile birlikte geliyor)
        Image resim;

        //girilen metinden QR üretmeyi sağlar
        private void btnQROluştur_Click(object sender, EventArgs e)
        {
            //TextBoxdan aldığı veriyi QR haline getirip 
            //PictureBox'da görüntülemeyi sağlar
            resim = code.Encode(txtQROluştur.Text);
            pictureBoxQR.Image = resim;
        }

        //PictureBox'da görüntülenen QR'ı png olarak bilgisayara kaydetmeyi sağlar.
        private void QRKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Resim Dosyaları";
            savefile.Filter = "PNG dosyası |*.png";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                pictureBoxQR.Image.Save(savefile.FileName);
                MessageBox.Show("Kayıt İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı");
            }
        }

        //Form kapatılırken Film formunun açılmasını sağlar.
        private void QR_FormClosing(object sender, FormClosingEventArgs e)
        {
            Film yeni = new Film();
            yeni.Show();
            this.Hide();
        }
    }
}