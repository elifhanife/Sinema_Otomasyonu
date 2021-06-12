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

namespace SİNEMA_OTOMASYONU
{
    public partial class Film_Afiş : Form
    {
        public Film_Afiş()
        {
            InitializeComponent();
        }

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\hanif\\OneDrive\\Desktop\\SeansBilgiler.mdb");

        OleDbCommand komut = new OleDbCommand();

        //Form açıldıktan sonra filmler veri tabanına göre combobox a yazdırılıyor.
        private void Film_Afiş_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select * From Film_Bilgileri";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboFilmler.Items.Add(oku["Adı"]);
            }
            baglantı.Close();
        }

        //Filmin afişini Veri tabanındaki dosya yoluna göre PictureBox da gösterme işlemini yapan fonksiyon
        private void FilmAfişGöster()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Film_Bilgileri where Adı ='" + comboFilmler.SelectedItem + "'", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                pctrFilmAfişleri.ImageLocation = oku["Resim"].ToString();
            }
            baglantı.Close();
        }

        //Filmin Fragmanını Veri tabanındaki dosya yoluna göre WindowsMediaPlayer da gösterme işlemini yapan
        private void FilmFragmanGöster()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Film_Bilgileri where Adı ='" + comboFilmler.SelectedItem + "'", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                axFragman.URL = oku["Fragman"].ToString();
            }
            baglantı.Close();
        }

        //Filmin karekodunu Veri tabanındaki dosya yoluna göre PictureBox da gösterme işlemini yapan fonksiyon
        private void FilmQRGöster()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Film_Bilgileri where Adı ='" + comboFilmler.SelectedItem + "'", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                pctrIMDB.ImageLocation = oku["QR"].ToString();
            }
            baglantı.Close();
        }

        //Comboxdan seçilen filme göre afiş, fragman ve qr ı ekrana yazdırma fonksiyonu
        private void comboFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmAfişGöster();
            FilmFragmanGöster();
            FilmQRGöster();
        }

        // Film Afiş formu kapandığında Film formuna geri döner.
        private void Film_Afiş_FormClosing(object sender, FormClosingEventArgs e)
        {
            Film yeni = new Film();
            yeni.Show();
            this.Hide();
        }
    }
}