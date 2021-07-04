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
    public partial class Seans : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\hanif\\OneDrive\\Desktop\\SeansBilgiler.mdb");
        OleDbCommand komut;

        public Seans()
        {
            InitializeComponent();
        }

        //Film comboboxında filmleri gösterme fonksiyonu
        private void film_sec()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select *from Film_Bilgileri", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBoxFilm.Items.Add(oku["Adı"]);
                string[] items = comboBoxFilm.Items.OfType<string>().Distinct().ToArray();
                /*OfType listelerde <> içindeki türden elemanları yazdırır, Distinct() tekrar eden elemanı bir tane yazar
                 ve ToArray de elde kalan son verileri diziye çevirir.*/
                comboBoxFilm.Items.Clear();
                for (int i = 0; i < items.Length; i++)
                    comboBoxFilm.Items.Add(items[i]);
            }
            baglantı.Close();
        }

        //Salon comboboxında salonları gösterme fonksiyonu
        private void salon_sec()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select *from SalonEkle", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            comboBoxSalon.Items.Clear();
            while (oku.Read())
            {
                comboBoxSalon.Items.Add(oku["SalonAdı"]);
            }
            baglantı.Close();
        }

        //SalonEkle tablosundan ilgili salonun fotoğrafını alan fonksiyon.
        private void SalonFotoGöster()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select * From SalonEkle where SalonAdı ='" + comboBoxSalon.SelectedItem + "'", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                pboxSalonlar.ImageLocation = oku["SalonFoto"].ToString();
                lblSeçiliSalon.Text = oku["SalonBaşlık"].ToString();
            }
            baglantı.Close();
        }

        // Seçilen salonun fotoğrafını gösterir.
        private void comboBoxSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalonFotoGöster();
            TarihKarşılaştır();
        }

        //Saatler groupbox ında saatleri gösterme fonksiyonu.
        private void saat_sec()
        {
            baglantı.Open();
            for (int i = 1; i <= 10; i++)
            {
                OleDbCommand komut = new OleDbCommand("select *from SaatEkle where Sıra=" + i + "", baglantı);

                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    if (i == 1)
                        rbtn1.Text = oku["Saatler"].ToString();
                    else if (i == 2)
                        rbtn2.Text = oku["Saatler"].ToString();
                    else if (i == 3)
                        rbtn3.Text = oku["Saatler"].ToString();
                    else if (i == 4)
                        rbtn4.Text = oku["Saatler"].ToString();
                    else if (i == 5)
                        rbtn5.Text = oku["Saatler"].ToString();
                    else if (i == 6)
                        rbtn6.Text = oku["Saatler"].ToString();
                    else if (i == 7)
                        rbtn7.Text = oku["Saatler"].ToString();
                    else if (i == 8)
                        rbtn8.Text = oku["Saatler"].ToString();
                    else if (i == 9)
                        rbtn9.Text = oku["Saatler"].ToString();
                    else if (i == 10)
                        rbtn10.Text = oku["Saatler"].ToString();
                }
            }
            baglantı.Close();
        }

        // Tarih seçildiğinde olanlar.
        private void dateTimePickerTarih_ValueChanged(object sender, EventArgs e)
        {
            TarihKarşılaştır();
            foreach (RadioButton item1 in gboxSaatler.Controls)
            {
                if (saat == item1.Text)
                    item1.Checked = true;
            }
        }

        //Geçmiş saatlere ve daha önce kaydedilmiş bir tarihe ait saate tıklanmasını engeller.
        private void TarihKarşılaştır()
        {
            foreach (Control item in gboxSaatler.Controls)
                item.Enabled = true;

            foreach (RadioButton item in gboxSaatler.Controls)
                item.Checked = false;

            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePickerTarih.Text);

            if (yeni == bugün)
            {
                foreach (Control item in gboxSaatler.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                KayıtlıSeans();
            }
            else if (yeni > bugün)
            {
                KayıtlıSeans();
            }
            else if (yeni < bugün)
            {
                MessageBox.Show("Geçmiş günlere ait yeni kayıt oluşturulamaz!");
                dateTimePickerTarih.Text = DateTime.Now.ToShortDateString();
            }
        }

        // Eğer bir salona ait seçilen tarihte kayıt varsa onun saatini gizler.
        private void KayıtlıSeans()
        {
            baglantı.Open();
            komut = new OleDbCommand("select *from tablo1 where Salon='" + comboBoxSalon.Text + "' and Tarih='" + dateTimePickerTarih.Text + "'", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                foreach (Control item in gboxSaatler.Controls)
                {
                    if (oku["Saat"].ToString() == item.Text)
                        item.Enabled = false;
                }
            }
            baglantı.Close();
        }

        //Seans listele butonu.
        private void btnSeansGörüntüle_Click(object sender, EventArgs e)
        {
            SeansGörüntüle();
        }

        //tablo1 i listview e yazdırır.
        private void SeansGörüntüle()
        {
            listViewSeans.Items.Clear();
            baglantı.Open();
            komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select *From tablo1";
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Film"].ToString());
                ekle.SubItems.Add(oku["Salon"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                listViewSeans.Items.Add(ekle);
            }
            baglantı.Close();
        }

        //Seans filtreleme butonu.
        private void btnSeansFiltrele_Click(object sender, EventArgs e)
        {
            SeansFiltrele();
        }

        // Tarihe göre seansları listeleme fonksiyonu.
        private void SeansFiltrele()
        {
            listViewSeans.Items.Clear();
            baglantı.Open();
            komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select *From tablo1 where Tarih like '" + dateTimePickerListele.Text + "'";
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Film"].ToString());
                ekle.SubItems.Add(oku["Salon"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                listViewSeans.Items.Add(ekle);
            }
            baglantı.Close();
        }

        //Seans güncelle butonu.
        private void btnSeansGüncelle_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d*$");
            Match match = regex.Match(txtSeansGüncelle.Text);

            if (match.Success)
            {
                SeciliSaat();
                SeansGüncelle();
            }
            else
            {
                MessageBox.Show("Sıra No yanlış girildi!");
            }
            TarihKarşılaştır();
            txtSeansGüncelle.Clear();
            foreach (RadioButton item1 in gboxSaatler.Controls)
            {
                if (saat == item1.Text)
                    item1.Checked = true;
            }
        }

        //Kayıt günceller.
        private void SeansGüncelle()
        {
            if (txtSeansGüncelle.Text != "")
            {
                baglantı.Open();
                komut = new OleDbCommand();
                komut.Connection = baglantı;
                komut.CommandText = "update tablo1 set Film='" + comboBoxFilm.Text + "',Salon='" + comboBoxSalon.Text + "',Tarih='" + dateTimePickerTarih.Text + "',Saat='" + saat + "'where id=" + txtSeansGüncelle.Text + "";
                komut.ExecuteNonQuery();
                baglantı.Close();
                txtSeansGüncelle.Clear();
                SeansGörüntüle();
                Temizle();
            }
            else
            {
                MessageBox.Show("Değiştirilecek sıra girilmedi!");
            }
        }

        //Kayıt güncellemede listview dan seçili id bilgilerini comboboxlara taşır.
        private void KaydıTaşı()
        {
            if (listViewSeans.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewSeans.SelectedItems[0];

                comboBoxFilm.Text = item.SubItems[1].Text;
                comboBoxSalon.Text = item.SubItems[2].Text;
                dateTimePickerTarih.Text = item.SubItems[3].Text;
                saat = item.SubItems[4].Text;
            }
            TarihKarşılaştır();
            foreach (RadioButton item1 in gboxSaatler.Controls)
            {
                if (saat == item1.Text)
                    item1.Checked = true;
            }
        }

        private void listViewSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            KaydıTaşı();
        }

        //Seans silme butonu.
        private void btnSeansSil_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d*$");
            Match match = regex.Match(txtSeansSil.Text);

            if (match.Success)
            {
                SeansSil();
            }
            else
                MessageBox.Show("Sıra No yanlış girildi!");
            Temizle();
            TarihKarşılaştır();
            txtSeansSil.Clear();
        }


        //Kayıt siler.
        private void SeansSil()
        {
            if (txtSeansSil.Text != "")
            {
                baglantı.Open();
                komut = new OleDbCommand();
                komut.Connection = baglantı;
                komut.CommandText = "delete from tablo1 where id=" + txtSeansSil.Text + "";
                komut.ExecuteNonQuery();
                baglantı.Close();
                txtSeansSil.Clear();
                SeansGörüntüle();
            }
            else
            {
                MessageBox.Show("Silinecek sıra girilmedi!");
            }

        }

        //Seans ekle butonu.
        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            AynısıVarMı();
            SeciliSaat();
            if (comboBoxFilm.Text != "Seçiniz")
            {
                if (comboBoxSalon.Text != "Seçiniz")
                {
                    if (saat != "")
                    {
                        if (durum == true)
                        {
                            SeansEkle();
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Bu kayıt daha önce eklendi!");
                            Temizle();
                            pboxSalonlar.Image = null;
                            lblSeçiliSalon.Text = "Salonlarımız";
                        }
                    }
                    else
                        MessageBox.Show("Saat seçimi yapılmadı!");
                }
                else
                    MessageBox.Show("Salon seçimi yapılmadı!");
            }
            else
                MessageBox.Show("Film seçimi yapılmadı!");
            film_sec();
            salon_sec();
            dateTimePickerTarih.Text = DateTime.Now.ToShortDateString();
            TarihKarşılaştır();
        }

        //Yeni kayıt ekler.
        private void SeansEkle()
        {
            baglantı.Open();
            komut = new OleDbCommand("insert into tablo1 (Film,Salon,Tarih,Saat) values ('" + comboBoxFilm.Text + "','" + comboBoxSalon.Text + "','" + dateTimePickerTarih.Text + "','" + saat + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            SeansGörüntüle();
        }

        string saat = "";
        //Saat radiobutton larından seçili olanı saat değişkenine atama fonksiyonu.
        private void SeciliSaat()
        {
            if (rbtn1.Checked == true)
                saat = rbtn1.Text;
            else if (rbtn2.Checked == true)
                saat = rbtn2.Text;
            else if (rbtn3.Checked == true)
                saat = rbtn3.Text;
            else if (rbtn4.Checked == true)
                saat = rbtn4.Text;
            else if (rbtn5.Checked == true)
                saat = rbtn5.Text;
            else if (rbtn6.Checked == true)
                saat = rbtn6.Text;
            else if (rbtn7.Checked == true)
                saat = rbtn7.Text;
            else if (rbtn8.Checked == true)
                saat = rbtn8.Text;
            else if (rbtn9.Checked == true)
                saat = rbtn9.Text;
            else if (rbtn10.Checked == true)
                saat = rbtn10.Text;
        }

        // Daha önce eklenmiş seans kaydı var mı diye kontrol eder.
        bool durum;
        private void AynısıVarMı()
        {
            baglantı.Open();
            komut = new OleDbCommand("select *from tablo1 where Film='" + comboBoxFilm.Text + "' and Salon='" + comboBoxSalon.Text + "' and Tarih = '" + dateTimePickerTarih.Text + "' and Saat = '" + saat + "'", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglantı.Close();
        }

        // Seans yüklendiğinde olanlar.
        private void Seans_Load(object sender, EventArgs e)
        {
            comboBoxFilm.Text = "Seçiniz";
            comboBoxSalon.Text = "Seçiniz";
            film_sec();
            salon_sec();
            saat_sec();
            dateTimePickerTarih.Text = DateTime.Now.ToShortDateString();
            dateTimePickerListele.Text = DateTime.Now.ToShortDateString();
        }

        //Temizleme fonksiyonu. İşlemler yapıldıktan sonra comboları,seçili radiobuttonları ve saat değişkenini temizler.
        private void Temizle()
        {
            comboBoxFilm.Text = "Seçiniz";
            comboBoxSalon.Text = "Seçiniz";
            foreach (RadioButton item in gboxSaatler.Controls)
                item.Checked = false;
            saat = "";
        }

        //Salon İşlemleri butonu.
        private void btnSalonİşlemleri_Click(object sender, EventArgs e)
        {
            SalonEkle yeni = new SalonEkle();
            yeni.Show();
            this.Hide();
        }

        //Saat işlemleri butonu.
        private void btnSaatİşlemleri_Click(object sender, EventArgs e)
        {
            SaatEkle yeni = new SaatEkle();
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
                Environment.Exit(0);
            }
        }

        // Menustrip Hakkımızda butonu.
        private void bizKimizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gazi Üniversitesi Bilgisayar Mühendisliği\n\nÇağla YÜCE\nBahadır BOZKURT\nElif Hanife AYDOĞAN", "BİZ KİMİZ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Seans_FormClosing(object sender, FormClosingEventArgs e)
        {
            Anasayfa yeni = new Anasayfa();
            yeni.Show();
        }
    }
}