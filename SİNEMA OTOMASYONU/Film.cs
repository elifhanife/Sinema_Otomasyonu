using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace SİNEMA_OTOMASYONU
{
    public partial class Film : Form
    {
        public Film()
        {
            InitializeComponent();
        }

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\hanif\\OneDrive\\Desktop\\SeansBilgiler.mdb");

        OleDbCommand komut = new OleDbCommand();

        //Bir çok butonda ortak olan textleri temizleme ve verileri ekrana yazdırma fonksiyonu.
        private void verilerigöster()
        {
            listGörüntüle.Items.Clear();
            baglantı.Open();
           OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select * From Film_Bilgileri";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["Adı"].ToString());
                ekle.SubItems.Add(oku["Başroller"].ToString());
                ekle.SubItems.Add(oku["Yönetmeni"].ToString());
                ekle.SubItems.Add(oku["Süresi"].ToString());
                ekle.SubItems.Add(oku["Başlangıç_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Başlangıç_Saati"].ToString());
                ekle.SubItems.Add(oku["Bitiş_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Bitiş_Saati"].ToString());
                ekle.SubItems.Add(oku["Resim"].ToString());
                ekle.SubItems.Add(oku["Fragman"].ToString());
                ekle.SubItems.Add(oku["QR"].ToString());
                listGörüntüle.Items.Add(ekle);

            }
            baglantı.Close();
            txtFilmAdı.Clear();
            txtFilmSüresi.Clear();
            txtFilmYönetmen.Clear();
            txtBaşroller.Clear();
            txtSaat1.Clear();
            txtSaat2.Clear();
            txtAfişEkle.Clear();
            txtFragmanEkle.Clear();
            txtQREkle.Clear();
        }

       
        //Afiş Formuna yönlendirme yapıyor.
        private void btnFilmAfiş_Click(object sender, EventArgs e)
        {
            Film_Afiş yeni = new Film_Afiş();
            yeni.Show();
            this.Hide();
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
                Application.Exit();
            }
        }

        //Kayıtlı filmler ekrana yazdırılıyor.
        private void btnFilmGörüntüle_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        //Ekleme butonunda tarih kontrolü yapılıyor ve hata yoksa ekleme fonksiyonu ile film eklemesi yapılıyor.
        private void btnEkleme_Click(object sender, EventArgs e)
        {
            DateTime bugün = DateTime.Parse(DateTime.Now.ToLongDateString());
            DateTime ilk = DateTime.Parse(dateTimeGiriş.Text);
            DateTime son = DateTime.Parse(dateTimeKalkış.Text);

            if (ilk < bugün)
            {
                MessageBox.Show("Geçmiş günlere ait yeni kayıt oluşturulamaz!");
            }
            else if (son < bugün)
            {
                MessageBox.Show("Geçmiş günlere ait yeni kayıt oluşturulamaz!");
            }
            else if (son < ilk)
            {
                MessageBox.Show("Yayına Giriş Tarihi Yayından Kalkış Tarihinden Sonra Olamaz");
            }
            else
            {
                baglantı.Open();
                if (txtFilmAdı.Text != "")
                {
                    if (txtFilmSüresi.Text != "")
                    {
                        try
                        {
                            komut = new OleDbCommand("insert into Film_Bilgileri(Adı, Başroller, Yönetmeni, Süresi, Başlangıç_Tarihi, Başlangıç_Saati, Bitiş_Tarihi, Bitiş_Saati, Resim, Fragman, QR) values ('" + txtFilmAdı.Text.ToString().Trim().ToLower() + "','" + txtBaşroller.Text.ToString() + "','" + txtFilmYönetmen.Text.ToString() + "','" + txtFilmSüresi.Text.ToString() + "','" + dateTimeGiriş.Value.ToLongDateString().ToString() + "','" + txtSaat1.Text.ToString() + "','" + dateTimeKalkış.Value.ToLongDateString().ToString() + "','" + txtSaat2.Text.ToString() + "','" + txtAfişEkle.Text.ToString() + "','" + txtFragmanEkle.Text.ToString() + "','" + txtQREkle.Text.ToString() + "')", baglantı);
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Yeni Kayıt Eklendi!");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bu film daha önce eklendi!!!", "UYARI");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Filmin Süresini Yazmadınız", "UYARI");
                    }
                }
                else
                {
                    MessageBox.Show("Filmin Adını Yazmadınız", "UYARI");
                }
                baglantı.Close();
                verilerigöster();
            }
        }

        //Silme işlemini yapan buton
        private void btnSilme_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d*$");
            Match match = regex.Match(txtSil.Text);

            if (match.Success)
            {
                try
                {
                    if (txtSil.Text != "0" && txtSil.Text != "")
                    {
                        baglantı.Open();
                        komut.Connection = baglantı;
                        komut.CommandText = "delete from Film_Bilgileri where ID = " + txtSil.Text + "";
                        komut.ExecuteNonQuery();
                        baglantı.Close();
                        verilerigöster();
                    }
                    else
                        MessageBox.Show("Silinecek ID yanlış!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Silme işlemi yapılamadı!!!");
                }
            }
            else
                MessageBox.Show("Silinecek ID rakamlardan oluşmalı!!!");
        }

        //Güncelleme işlemini yapan buton
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d*$");
            Match match = regex.Match(txtGüncelle.Text);

            if (match.Success)
            {
                try
                {
                    if (txtGüncelle.Text != "0" && txtGüncelle.Text != "")
                    {
                        baglantı.Open();
                        komut.Connection = baglantı;
                        komut.CommandText = "update Film_Bilgileri set  Adı='" + txtFilmAdı.Text.Trim().ToLower() + "',Başroller='" + txtBaşroller.Text + "',Yönetmeni='" + txtFilmYönetmen.Text + "',Süresi='" + txtFilmSüresi.Text + "',Başlangıç_Tarihi='" + dateTimeGiriş.Value.ToLongDateString().ToString() + "',Başlangıç_Saati='" + txtSaat1.Text + "',Bitiş_Tarihi='" + dateTimeKalkış.Value.ToLongDateString().ToString() + "',Bitiş_Saati='" + txtSaat2.Text + "' where ID=" + txtGüncelle.Text + "";
                        komut.ExecuteNonQuery();
                        baglantı.Close();
                        verilerigöster();
                    }
                    else
                        MessageBox.Show("Güncellenecek ID yanlış!!!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Güncelleme işlemi yapılamadı!!!");
                }
            }
            else
                MessageBox.Show("Güncelleme ID rakamlardan oluşmalı!!!");
        }

        //Seçilen ID bilgilerini Paneldeki ilgili yerlere yazdırır.
        private void listGörüntüle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGörüntüle.SelectedItems.Count > 0)
            {
                ListViewItem item = listGörüntüle.SelectedItems[0];
                txtFilmAdı.Text = item.SubItems[1].Text;
                txtBaşroller.Text = item.SubItems[2].Text;
                txtFilmYönetmen.Text = item.SubItems[3].Text;
                txtFilmSüresi.Text = item.SubItems[4].Text;
                txtSaat1.Text = item.SubItems[6].Text;
                txtSaat2.Text = item.SubItems[8].Text;
                txtAfişEkle.Text = item.SubItems[9].Text;
                txtFragmanEkle.Text = item.SubItems[10].Text;
                txtQREkle.Text = item.SubItems[11].Text;
            }
        }

        //Arama işlemini yapan buton
        private void btnArama_Click(object sender, EventArgs e)
        {
            listGörüntüle.Items.Clear();
            baglantı.Open(); 
            //% işaretleri ile büyük harf küçük harf veya kelimenin başında, ortasında ve sonunda olsa bile istenilen kelimenin arama işlemi yapılabiliyor.
            OleDbCommand komut = new OleDbCommand("Select * From Film_Bilgileri where Adı like '%" + txtArananFilm.Text + "%'", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["Adı"].ToString());
                ekle.SubItems.Add(oku["Başroller"].ToString());
                ekle.SubItems.Add(oku["Yönetmeni"].ToString());
                ekle.SubItems.Add(oku["Süresi"].ToString());
                ekle.SubItems.Add(oku["Başlangıç_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Başlangıç_Saati"].ToString());
                ekle.SubItems.Add(oku["Bitiş_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Bitiş_Saati"].ToString());
                ekle.SubItems.Add(oku["Resim"].ToString());
                ekle.SubItems.Add(oku["Fragman"].ToString());
                ekle.SubItems.Add(oku["QR"].ToString());
                listGörüntüle.Items.Add(ekle);
            }
            baglantı.Close();
        }

        //Afiş ekleme işlemini yapan buton. Open File Dialog ile bilgisayardan dosya alınıyor. Filter komutu ile dosya uzatısı filtreleniyor.
        private void btnAfişEkle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.jpeg;*.png | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            txtAfişEkle.Text = dosyayolu;
            komut.Connection = baglantı;
            komut.CommandText = "update Film_Bilgileri set Resim = '" + txtAfişEkle.Text + "' where ID=" + txtGüncelle.Text + "";
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        //Fragman ekleme işlemini yapan buton. Open File Dialog ile bilgisayardan dosya alınıyor. Filter komutu ile dosya uzatısı filtreleniyor.
        private void btnFragman_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Video Dosyası |*.mp4;*.avi| Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu2 = dosya.FileName;
            txtFragmanEkle.Text = dosyayolu2;
            komut.Connection = baglantı;
            komut.CommandText = "update Film_Bilgileri set Fragman = '" + txtFragmanEkle.Text + "' where ID=" + txtGüncelle.Text + "";
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        //QR ekleme işlemini yapan buton. Open File Dialog ile bilgisayardan dosya alınıyor. Filter komutu ile dosya uzatısı filtreleniyor.
        private void btnQREkle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.jpeg;*.png | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu3 = dosya.FileName;
            txtQREkle.Text = dosyayolu3;
            komut.Connection = baglantı;
            komut.CommandText = "update Film_Bilgileri set QR = '" + txtQREkle.Text + "' where ID=" + txtGüncelle.Text + "";
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        // QR OLUŞTUR formuna yönlendirir.
        private void QROluştur_Click(object sender, EventArgs e)
        {
            QR oluştur = new QR();
            oluştur.Show();
            this.Hide();
        }

        //Menustrip HAKKIMIZDA butonu.
        private void bİZKİMİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gazi Üniversitesi Bilgisayar Mühendisliği\n\nÇağla YÜCE\nBahadır BOZKURT\nElif Hanife AYDOĞAN", "BİZ KİMİZ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Film_FormClosing(object sender, FormClosingEventArgs e)
        {
            Anasayfa yeni = new Anasayfa();
            yeni.Show();
        }
    }
}