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
    public partial class Satışlar : Form
    {
        OleDbConnection bağlantı = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\hanif\OneDrive\Desktop\SeansBilgiler.mdb");
        public Satışlar()
        {
            InitializeComponent();
        }

        //Veritabanında kayıtlı olan verileri hesaplamayı sağlar
        private void ToplamÜcretHesapla()
        {
            bağlantı.Open();
            //Veritabanında kayıtlı olan bilet satış verilerini hesaplamayı sağlar
            OleDbCommand komut = new OleDbCommand("Select sum(Ücret) From Bilet", bağlantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblBiletToplam.Text = oku[0].ToString();
            }

            //Veritabanında kayıtlı olan büfe satış verilerini hesaplamayı sağlar
            OleDbCommand komut1 = new OleDbCommand("Select sum(BüfeFiyat) From Bilet", bağlantı);
            OleDbDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                lblBüfeToplam.Text = oku1[0].ToString();
            }
            bağlantı.Close();
        }

        //Belirli tarihe göre Veritabanında kayıtlı olan verileri Listview'de görüntüleme işlemi
        private void verilerigöster()
        {
            listViewSatışlar.Items.Clear();
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bağlantı;
            komut.CommandText = "Select *From Bilet where Tarih like '" + dateTimePickerToplamSatış1.Value.ToShortDateString() + "'";
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["BiletID"].ToString();
                ekle.SubItems.Add(oku["FilmAdı"].ToString());
                ekle.SubItems.Add(oku["SalonAdı"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["BüfeFiyat"].ToString());
                listViewSatışlar.Items.Add(ekle);
            }
            bağlantı.Close();
        }

        //Veritabanında kayıtlı olan verileri Listview'de görüntüleme işlemi
        private void tümverilerigöster()
        {
            listViewSatışlar.Items.Clear();
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bağlantı;
            komut.CommandText = "Select *From Bilet";
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["BiletID"].ToString();
                ekle.SubItems.Add(oku["FilmAdı"].ToString());
                ekle.SubItems.Add(oku["SalonAdı"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["BüfeFiyat"].ToString());
                listViewSatışlar.Items.Add(ekle);
            }
            bağlantı.Close();
        }

        //Satılan tüm bilet ve yiyeceklerin fiyatlarını hesaplama
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            verilerigöster();//Belirli tarihe göre Veritabanında kayıtlı olan verileri Listview'de görüntüleme işlemi
            bağlantı.Open();

            //Belirli tarihe göre toplam bilet satış fiyatlarını görüntüleme
            OleDbCommand komut = new OleDbCommand("Select sum(Ücret) From Bilet where Tarih like '" + dateTimePickerToplamSatış1.Value.ToShortDateString() + "' ", bağlantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblBiletToplam.Text = oku[0].ToString();
            }

            //Belirli tarihe göre toplam büfe satış fiyatlarını görüntüleme
            OleDbCommand komut1 = new OleDbCommand("Select sum(BüfeFiyat) From Bilet where Tarih like '" + dateTimePickerToplamSatış1.Value.ToShortDateString() + "' ", bağlantı);
            OleDbDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                lblBüfeToplam.Text = oku1[0].ToString();
            }
            bağlantı.Close();
            HerşeyiTopla();
            lblSatılanBilet.Text = listViewSatışlar.Items.Count.ToString();
        }

        // Tüm satışları hesaplama.
        private void btnTümSatış_Click(object sender, EventArgs e)
        {
            ToplamÜcretHesapla();
            tümverilerigöster();
            lblSatılanBilet.Text = listViewSatışlar.Items.Count.ToString();
            HerşeyiTopla();
        }

        // Belirli bir tarihe göre tüm satışları hesaplama.
        private void btnAralık_Click(object sender, EventArgs e)
        {
            Aralık();
            lblSatılanBilet.Text = listViewSatışlar.Items.Count.ToString();
            HerşeyiTopla();
        }

        //Girilen 2 tarihe göre satışları hesaplama
        private void Aralık()
        {
            listViewSatışlar.Items.Clear();
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bağlantı;
            komut.CommandText = "Select * From Bilet WHERE Tarih";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                DateTime tarih1 = dateTimePickerToplamSatış2.Value;
                DateTime tarih2 = dateTimePickerToplamSatış3.Value;
                string[] dbtarih = oku["Tarih"].ToString().Split('.');//Veritabanında string olarak tutulan tarih değerini parçalar

                //Tarihi gün, ay ve yıl olarak oluşturulan dizinin indislerine atar 
                int gün = Convert.ToInt32(dbtarih[0]);
                int ay = Convert.ToInt32(dbtarih[1]);
                int yıl = Convert.ToInt32(dbtarih[2]);

                //Dizideki değerleri DateTime'da tarih olarak birleştirir
                DateTime tarih3 = new DateTime(yıl, ay, gün);

                if (DateTime.Compare(tarih1, tarih3) < 0 && DateTime.Compare(tarih3, tarih2) < 0)
                {
                    //DateTimePicker'lardan gelen tarihleri ve veritabanından gelen tarihi karşılaştırarak
                    //2 tarihin arasında bulunan verileri görüntüler
                    /*  
                    <0 − If date1 is earlier than date2.
                     0 − If date1 is the same as date2.
                     >0 − If date1 is later than date2.
                     */
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["BiletID"].ToString();
                    ekle.SubItems.Add(oku["FilmAdı"].ToString());
                    ekle.SubItems.Add(oku["SalonAdı"].ToString());
                    ekle.SubItems.Add(oku["Tarih"].ToString());
                    ekle.SubItems.Add(oku["Saat"].ToString());
                    ekle.SubItems.Add(oku["KoltukNo"].ToString());
                    ekle.SubItems.Add(oku["Ad"].ToString());
                    ekle.SubItems.Add(oku["Soyad"].ToString());
                    ekle.SubItems.Add(oku["Ücret"].ToString());
                    ekle.SubItems.Add(oku["BüfeFiyat"].ToString());
                    listViewSatışlar.Items.Add(ekle);
                    FilmveToplamÜcret();
                }
                else if (DateTime.Compare(tarih2, tarih3) < 0 && DateTime.Compare(tarih3, tarih1) < 0)
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["BiletID"].ToString();
                    ekle.SubItems.Add(oku["FilmAdı"].ToString());
                    ekle.SubItems.Add(oku["SalonAdı"].ToString());
                    ekle.SubItems.Add(oku["Tarih"].ToString());
                    ekle.SubItems.Add(oku["Saat"].ToString());
                    ekle.SubItems.Add(oku["KoltukNo"].ToString());
                    ekle.SubItems.Add(oku["Ad"].ToString());
                    ekle.SubItems.Add(oku["Soyad"].ToString());
                    ekle.SubItems.Add(oku["Ücret"].ToString());
                    ekle.SubItems.Add(oku["BüfeFiyat"].ToString());
                    listViewSatışlar.Items.Add(ekle);
                    FilmveToplamÜcret();
                }  
            }
            bağlantı.Close();
        }

        //Veritabanındaki kayıtlı filmleri görüntülemeyi sağlar
        private void FilmGetir()
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Bilet", bağlantı);
            OleDbDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                comboFilmAdı.Items.Add(read["FilmAdı"].ToString());
                string[] items = comboFilmAdı.Items.OfType<string>().Distinct().ToArray();
                /*OfType listelerde <> içindeki türden elemanları yazdırır, Distinct() tekrar eden elemanı bir tane yazar
                 ve ToArray de elde kalan son verileri diziye çevirir.*/
                comboFilmAdı.Items.Clear();
                for (int i = 0; i < items.Length; i++)
                    comboFilmAdı.Items.Add(items[i]);
            }
            bağlantı.Close();
        }

        //Seçilen filme göre gelen ücretleri hesaplamayı sağlar
        private void FilmveToplamÜcret()
        {
            //Seçilen filme göre gelen bilet satışını hesaplamayı sağlar
            double ücrettoplamı = 0;
            for (int i = 0; i < listViewSatışlar.Items.Count; i++)
            {
                ücrettoplamı += Convert.ToDouble(listViewSatışlar.Items[i].SubItems[8].Text);
                lblBiletToplam.Text = ücrettoplamı.ToString();
            }

            //Seçilen filme göre gelen büfe satışını hesaplamayı sağlar
            double ücrettoplamı2 = 0;
            for (int i = 0; i < listViewSatışlar.Items.Count; i++)
            {
                ücrettoplamı2 += Convert.ToDouble(listViewSatışlar.Items[i].SubItems[9].Text);
                lblBüfeToplam.Text = ücrettoplamı2.ToString();
            }
        }

        //Girilen 2 tarih ve filme göre satışları hesaplama
        private void btnAranan_Click(object sender, EventArgs e)
        {
            listViewSatışlar.Items.Clear();
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Bilet WHERE Tarih and FilmAdı='" + comboFilmAdı.SelectedItem + "'", bağlantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                DateTime tarih1 = dateTimePickerToplamSatış2.Value;
                DateTime tarih2 = dateTimePickerToplamSatış3.Value;
                string[] dbtarih = oku["Tarih"].ToString().Split('.');//Veritabanında string olarak tutulan tarih değerini parçalar
                //Tarihi gün, ay ve yıl olarak oluşturulan dizinin indislerine atar 
                int gün = Convert.ToInt32(dbtarih[0]);
                int ay = Convert.ToInt32(dbtarih[1]);
                int yıl = Convert.ToInt32(dbtarih[2]);
                //Dizideki değerleri DateTime'da tarih olarak birleştirir
                DateTime tarih3 = new DateTime(yıl, ay, gün);

                if (DateTime.Compare(tarih1, tarih3) < 0 && DateTime.Compare(tarih3, tarih2) < 0)
                {
                    //DateTimePicker'lardan gelen tarihleri ve veritabanından gelen tarihi karşılaştırarak
                    //2 tarihin arasında bulunan verileri görüntüler
                    /*  
                    <0 − If date1 is earlier than date2.
                    0 − If date1 is the same as date2.
                    >0 − If date1 is later than date2.
                    */
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["BiletID"].ToString();
                    ekle.SubItems.Add(oku["FilmAdı"].ToString());
                    ekle.SubItems.Add(oku["SalonAdı"].ToString());
                    ekle.SubItems.Add(oku["Tarih"].ToString());
                    ekle.SubItems.Add(oku["Saat"].ToString());
                    ekle.SubItems.Add(oku["KoltukNo"].ToString());
                    ekle.SubItems.Add(oku["Ad"].ToString());
                    ekle.SubItems.Add(oku["Soyad"].ToString());
                    ekle.SubItems.Add(oku["Ücret"].ToString());
                    ekle.SubItems.Add(oku["BüfeFiyat"].ToString());
                    listViewSatışlar.Items.Add(ekle);
                }
                else if (DateTime.Compare(tarih2, tarih3) < 0 && DateTime.Compare(tarih3, tarih1) < 0)
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["BiletID"].ToString();
                    ekle.SubItems.Add(oku["FilmAdı"].ToString());
                    ekle.SubItems.Add(oku["SalonAdı"].ToString());
                    ekle.SubItems.Add(oku["Tarih"].ToString());
                    ekle.SubItems.Add(oku["Saat"].ToString());
                    ekle.SubItems.Add(oku["KoltukNo"].ToString());
                    ekle.SubItems.Add(oku["Ad"].ToString());
                    ekle.SubItems.Add(oku["Soyad"].ToString());
                    ekle.SubItems.Add(oku["Ücret"].ToString());
                    ekle.SubItems.Add(oku["BüfeFiyat"].ToString());
                    listViewSatışlar.Items.Add(ekle);
                }
            }
            FilmveToplamÜcret();
            bağlantı.Close();
            lblSatılanBilet.Text = listViewSatışlar.Items.Count.ToString();
            HerşeyiTopla();
        }

        // Filme göre satışı hesaplar.
        private void btnFilm_Click_1(object sender, EventArgs e)
        {
            listViewSatışlar.Items.Clear();
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Bilet WHERE FilmAdı='" + comboFilmAdı.SelectedItem + "'", bağlantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["BiletID"].ToString();
                ekle.SubItems.Add(oku["FilmAdı"].ToString());
                ekle.SubItems.Add(oku["SalonAdı"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["BüfeFiyat"].ToString());
                listViewSatışlar.Items.Add(ekle);
            }
            FilmveToplamÜcret();
            bağlantı.Close();
            lblSatılanBilet.Text = listViewSatışlar.Items.Count.ToString();
            HerşeyiTopla();
        }

        private void Satışlar_Load(object sender, EventArgs e)
        {
            FilmGetir();
        }

        //Bilet sayfasına dönmeyi sağlar
        private void Satışlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bilet yeni = new Bilet();
            yeni.Show();
        }

        //Toplam büfe ve bilet satışı hesaplar
        private void HerşeyiTopla()
        {
            try
            {
                double toplam = Convert.ToDouble(lblBiletToplam.Text) + Convert.ToDouble(lblBüfeToplam.Text);
                lblToplamKazanç.Text = toplam.ToString();
            }
            catch (Exception)
            {
                lblBiletToplam.Text = "0";
                lblBüfeToplam.Text = "0";
                lblToplamKazanç.Text = "0";
                MessageBox.Show("Bu güne ait kayıt bulunmamaktadır!!!");
            }
        }
    }
}