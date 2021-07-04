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
    public partial class Bilet : Form
    {
        OleDbConnection bağlantı = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\hanif\OneDrive\Desktop\SeansBilgiler.mdb");
        public Bilet()
        {
            InitializeComponent();
        }

        int sayaç = 0;

        //Veritabanında kayıtlı olan filmlerin ComboBox'da görüntülenmesini sağlar
        private void FilmGetir()
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From tablo1", bağlantı);
            OleDbDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                comboFilmAdı.Items.Add(read["Film"].ToString());
                string[] items = comboFilmAdı.Items.OfType<string>().Distinct().ToArray();
                /*OfType listelerde <> içindeki türden elemanları yazdırır, Distinct() tekrar eden elemanı bir tane yazar
                 ve ToArray de elde kalan son verileri diziye çevirir.*/
                comboFilmAdı.Items.Clear();
                for (int i = 0; i < items.Length; i++)
                    comboFilmAdı.Items.Add(items[i]);
            }
            bağlantı.Close();
        }

        //Veritabanında kayıtlı olan salonların ComboBox'da görüntülenmesini sağlar
        private void SalonGetir()
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From tablo1 where Film = '" + comboFilmAdı.SelectedItem + "' ", bağlantı);
            OleDbDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                comboSalonAdı.Items.Add(read["Salon"].ToString());
                string[] items = comboSalonAdı.Items.OfType<string>().Distinct().ToArray();
                comboSalonAdı.Items.Clear();
                for (int i = 0; i < items.Length; i++)
                    comboSalonAdı.Items.Add(items[i]);
            }
            bağlantı.Close();
        }

        //Veritabanında kayıtlı olan salonlara ait ücretlerin ComboBox'da görüntülenmesini sağlar
        private void ÜcretGetir()
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bağlantı;
            komut.CommandText = "Select *from SalonEkle where SalonAdı = '" + comboSalonAdı.SelectedItem + "'";
            komut.CommandType = CommandType.Text;
            bağlantı.Open();
            OleDbDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                comboÜcret.Items.Add(read["Ücret"].ToString());
                string[] items = comboÜcret.Items.OfType<string>().Distinct().ToArray();
                comboÜcret.Items.Clear();
                for (int i = 0; i < items.Length; i++)
                    comboÜcret.Items.Add(items[i]);
            }
            bağlantı.Close();
        }

        private void Bilet_Load(object sender, EventArgs e)
        {
            Boş_Koltuklar();
            FilmGetir();
            ÜrünGetir();
            FiyatGetir();
        }

        //Form açıldığı zaman koltukların görüntülenmesini sağlar
        private void Boş_Koltuklar()
        {
            sayaç = 1;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button buton = new Button();
                    buton.Size = new Size(50, 48);
                    buton.BackColor = Color.White;
                    buton.Location = new Point(j * 50 + 40, i * 50 + 50);
                    buton.Name = sayaç.ToString();
                    buton.Text = sayaç.ToString();

                    if (i == 4)
                    {
                        continue;
                    }
                    sayaç++;
                    this.pnlKoltuk.Controls.Add(buton);
                    buton.Click += Btn_Click;
                }
            }
        }

        //Satılan koltuğun renklenmesini sağlar
        private void YenidenRenklendir()
        {
            foreach (Control item in pnlKoltuk.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        //Veritabanından film, tarih, salon ve saat bilgilerine ait satılmış olan koltukların renklenmesini sağlar
        private void VeriTabanıDoluKoltuklar()
        {
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Bilet where FilmAdı = '" + comboFilmAdı.SelectedItem + "' and SalonAdı = '" + comboSalonAdı.Text + "' and Tarih = '" + comboTarih.SelectedItem + "' and Saat = '" + comboSaat.SelectedItem + "' ", bağlantı);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in pnlKoltuk.Controls)
                {
                    if (item is Button)
                    {
                        if (dr["KoltukNo"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Crimson;
                        }
                    }
                }
            }
            bağlantı.Close();
        }

        //Seçilen film, tarih, salon ve saat bilgisine göre satılmış olan koltukların iptal ComboBox'ında görüntülenmesini sağlar
        private void DoluKoltuklar()
        {
            comboBoxBiletiptal.Items.Clear();
            comboBoxBiletiptal.Text = "";
            foreach (Control item in pnlKoltuk.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Crimson)
                    {
                        comboBoxBiletiptal.Items.Add(item.Text);
                    }
                }
            }
        }

        //Satışı yapılmamış koltuklardan birine tıklandığında Koltuk No'sunun TextBox'da görüntülenmesini sağlar
        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                txtKoltukNo.Text = b.Text;
            }
        }

        //Satış Formunu açar
        private void btnTümSatış_Click(object sender, EventArgs e)
        {
            Satışlar yeni = new Satışlar();
            yeni.Show();
            this.Hide();
        }

        //Veritabanında gelen filmlerden birisi seçildiğinde salon bilgisinin gelmesini sağlar
        private void comboFilmAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSalonAdı.Items.Clear();
            comboÜcret.Items.Clear();
            comboSaat.Items.Clear();
            comboTarih.Items.Clear();
            comboSaat.Text = "";
            comboTarih.Text = "";
            comboSalonAdı.Text = "";
            comboÜcret.Text = "";
            foreach (Control item in groupBoxBiletSatışİşlemleri.Controls) if (item is TextBox) item.Text = "";
            SalonGetir();  //Veritabanında kayıtlı olan salonların ComboBox'da görüntülenmesini sağlar
            YenidenRenklendir(); //Satılan koltuğun renklenmesini sağlar
            DoluKoltuklar();  //Seçilen film, tarih, salon ve saat bilgisine göre satılmış olan koltukların iptal ComboBox'ında görüntülenmesini sağlar
        }

        //Veritabanında gelen film ve salon bilgisine göre tarihlerin gelmesini sağlar
        private void FilmTarihiGetir()
        {
            comboTarih.Text = "";
            comboSaat.Text = "";
            comboTarih.Items.Clear();
            comboSaat.Items.Clear();

            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("Select *From tablo1 where Film ='" + comboFilmAdı.SelectedItem + "' and Salon ='" + comboSalonAdı.SelectedItem + "' ", bağlantı);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //Geçmiş tarihlerin görüntülenmesini önler
                if (DateTime.Parse(dr["Tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboTarih.Items.Contains(dr["Tarih"].ToString()))
                    {
                        comboTarih.Items.Add(dr["Tarih"].ToString());
                    }
                }
            }
            bağlantı.Close();
        }

        //Veritabanından gelen film,salon ve tarih bilgisine göre saatlerin gelmesini sağlar
        private void FilmSeansıGetir()
        {
            comboSaat.Text = "";
            comboSaat.Items.Clear();

            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("Select *from tablo1 where Film='" + comboFilmAdı.SelectedItem + "' and Salon ='" + comboSalonAdı.SelectedItem + "' and Tarih='" + comboTarih.SelectedItem + "'", bağlantı);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //Geçmiş saatlerin görüntülenmesini önler
                if (DateTime.Parse(dr["Tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(dr["Saat"].ToString()) > DateTime.Parse(DateTime.Now.ToShortTimeString()))
                    {
                        comboSaat.Items.Add(dr["Saat"].ToString());
                    }
                }
                else if (DateTime.Parse(dr["Tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    comboSaat.Items.Add(dr["Saat"].ToString());
                }
            }
            bağlantı.Close();
        }

        //Veritabanından gelen tarihlerden birisi seçildiğinde saat bilgisinin gelmesini sağlar
        private void comboTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmSeansıGetir();//Veritabanında gelen film,salon ve tarih bilgisine göre saatlerin gelmesini sağlar
        }

        //Veritabanından gelen saatlern birisi seçildiğinde koltukların ona göre gelmesini sağlar
        private void comboSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir(); //Satılacak koltuğun renklenmesini sağlar
            VeriTabanıDoluKoltuklar(); //Veritabanında film,salon,tarih ve saate göre daha önce satılmış koltukları görüntüler
            DoluKoltuklar(); //Dolu koltukların renklenmesini sağlar
        }

        //Seçilen film,salon,tarih ve saat bilgisine göre kayıtlı olan koltuklardan iptal işlemi yapar
        private void Biletİptal()
        {
            if (comboBoxBiletiptal.Text != "")
            {
                try
                {
                    bağlantı.Open();
                    OleDbCommand komut = new OleDbCommand("Delete from Bilet where FilmAdı='" + comboFilmAdı.SelectedItem + "' and SalonAdı ='" + comboSalonAdı.SelectedItem + "' and Tarih='" + comboTarih.SelectedItem + "'and Saat='" + comboSaat.SelectedItem + "' and KoltukNo='" + comboBoxBiletiptal.SelectedItem + "'", bağlantı);
                    komut.ExecuteNonQuery();
                    bağlantı.Close();
                    MessageBox.Show("Bilet Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    YenidenRenklendir();
                    VeriTabanıDoluKoltuklar();
                    DoluKoltuklar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata Oluştu!", "Uyarı");
                }
            }

            else
            {
                MessageBox.Show("Koltuk Seçimi Yapmadınız!", "Uyarı");
            }
        }

        private void btnBiletİptal_Click(object sender, EventArgs e)
        {
            Biletİptal();//Bilet iptal işlemi
        }

        //Alının Film, salon, tarih, saat, koltuk no, ad, soyad, ücret bilgilerine göre biletin satılıp veritabanına kaydedilmesini sağlar
        private void BiletSat()
        {
            if (txtKoltukNo.Text != "" && comboFilmAdı.Text != "" && comboSalonAdı.Text != "" && comboTarih.Text != "" && comboSaat.Text != "" && comboÜcret.Text != "")
            {
                ToplamFiyat();
                bağlantı.Open();
                OleDbCommand komut = new OleDbCommand("insert into Bilet(FilmAdı,SalonAdı,Tarih,Saat,KoltukNo,Ad,Soyad,Ücret,BüfeFiyat) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bağlantı);
                komut.Parameters.AddWithValue("@p1", comboFilmAdı.Text.ToString());
                komut.Parameters.AddWithValue("@p2", comboSalonAdı.Text.ToString());
                komut.Parameters.AddWithValue("@p3", comboTarih.Text.ToString());
                komut.Parameters.AddWithValue("@p4", comboSaat.Text.ToString());
                komut.Parameters.AddWithValue("@p5", txtKoltukNo.Text.ToString());
                komut.Parameters.AddWithValue("@p6", txtAd.Text.ToString().Trim().ToUpper());
                komut.Parameters.AddWithValue("@p7", txtSoyad.Text.ToString().Trim().ToUpper());
                komut.Parameters.AddWithValue("@p8", comboÜcret.Text.ToString());
                komut.Parameters.AddWithValue("@p9", lblBüfeFiyat.Text.ToString());
                komut.ExecuteNonQuery();
                bağlantı.Close();
                MessageBox.Show("Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control item in groupBoxBiletSatışİşlemleri.Controls) if (item is TextBox) item.Text = "";
                YenidenRenklendir();
                VeriTabanıDoluKoltuklar();
                DoluKoltuklar();
                Temizle();
            }

            else
            {
                MessageBox.Show(" * işaretli alanları doldurunuz!", "Uyarı");
            }
        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            BiletSat();//Bilet satma işlemi
        }

        // Temizle fonksiyonu.
        private void Temizle()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            txtFiyat1.Text = "0";
            txtFiyat2.Text = "0";
            txtFiyat3.Text = "0";
            txtFiyat4.Text = "0";
            txtFiyat5.Text = "0";
            lblBüfeFiyat.Text = "0";
        }

        double fiyat = 0;

        //Büfeye veritabanındaki ürünlerin getirilmesini sağlar
        private void ÜrünGetir()
        {
            bağlantı.Open();
            for (int i = 1; i <= 5; i++)
            {
                OleDbCommand komut = new OleDbCommand("select *from Büfe where ID=" + i + "", bağlantı);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    if (i == 1)
                        lblÜrün1.Text = oku["Ürün"].ToString();
                    else if (i == 2)
                        lblÜrün2.Text = oku["Ürün"].ToString();
                    else if (i == 3)
                        lblÜrün3.Text = oku["Ürün"].ToString();
                    else if (i == 4)
                        lblÜrün4.Text = oku["Ürün"].ToString();
                    else if (i == 5)
                        lblÜrün5.Text = oku["Ürün"].ToString();
                }
            }
            bağlantı.Close();
        }

        //Büfeye veritabanındaki ürünlerin fiyatlarını getirmeyi sağlar
        private void FiyatGetir()
        {
            bağlantı.Open();
            for (int i = 1; i <= 5; i++)
            {
                OleDbCommand komut = new OleDbCommand("select *from Büfe where ID=" + i + "", bağlantı);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    if (i == 1)
                        lbldbFiyat1.Text = oku["Fiyat"].ToString();
                    else if (i == 2)
                        lbldbFiyat2.Text = oku["Fiyat"].ToString();
                    else if (i == 3)
                        lbldbFiyat3.Text = oku["Fiyat"].ToString();
                    else if (i == 4)
                        lbldbFiyat4.Text = oku["Fiyat"].ToString();
                    else if (i == 5)
                        lbldbFiyat5.Text = oku["Fiyat"].ToString();
                }
            }
            bağlantı.Close();
        }

        //Ürünün sayısını ayarlamayı sağlar
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(lbldbFiyat1.Text) * Convert.ToDouble(numericUpDown1.Value);
            txtFiyat1.Text = fiyat.ToString();
        }

        //Ürünün sayısını ayarlamayı sağlar
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(lbldbFiyat2.Text) * Convert.ToDouble(numericUpDown2.Value);
            txtFiyat2.Text = fiyat.ToString();
        }

        //Ürünün sayısını ayarlamayı sağlar
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(lbldbFiyat3.Text) * Convert.ToDouble(numericUpDown3.Value);
            txtFiyat3.Text = fiyat.ToString();
        }

        //Ürünün sayısını ayarlamayı sağlar
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(lbldbFiyat4.Text) * Convert.ToDouble(numericUpDown4.Value);
            txtFiyat4.Text = fiyat.ToString();
        }

        //Ürünün sayısını ayarlamayı sağlar
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(lbldbFiyat5.Text) * Convert.ToDouble(numericUpDown5.Value);
            txtFiyat5.Text = fiyat.ToString();
        }

        //Büfede o an satılan ürünlerin toplam fiyatını görüntüler
        private void ToplamFiyat()
        {
            double toplam = Convert.ToDouble(txtFiyat1.Text) + Convert.ToDouble(txtFiyat2.Text) + Convert.ToDouble(txtFiyat3.Text) + Convert.ToDouble(txtFiyat4.Text) + Convert.ToDouble(txtFiyat5.Text);
            lblBüfeFiyat.Text = toplam.ToString();
        }

        //Büfedeki ürünlerin toplamını görüntüleme
        private void btnBüfeHesapla_Click(object sender, EventArgs e)
        {
            ToplamFiyat();
        }

        // Menustrip GERİ butonu.
        private void gERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa yeni = new Anasayfa();
            yeni.Show();
            this.Hide();
        }

        // Menustrip ÇIKIŞ butonu.
        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult çıkış;
            çıkış = MessageBox.Show("Programı kapatmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (çıkış == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        //Seçilen salon ismine göre film tarihini ve fiyatını veritabanından almayı sağlar
        private void comboSalonAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboÜcret.Text = "";
            comboÜcret.Items.Clear();

            FilmTarihiGetir();
            ÜcretGetir();
        }

        // Menustrip HAKKIMIZDA butonu.
        private void bİZKİMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gazi Üniversitesi Bilgisayar Mühendisliği\n\nÇağla YÜCE\nBahadır BOZKURT\nElif Hanife AYDOĞAN","BİZ KİMİZ?",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //Büfe formunu açar
        private void btnBüfeİşlemleri_Click(object sender, EventArgs e)
        {
            Büfe yeni = new Büfe();
            yeni.Show();
            this.Hide();
        }

        private void Bilet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Anasayfa yeni = new Anasayfa();
            yeni.Show();
        }
    }
}