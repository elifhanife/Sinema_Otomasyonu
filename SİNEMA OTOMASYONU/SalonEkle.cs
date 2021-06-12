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
    public partial class SalonEkle : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\hanif\\OneDrive\\Desktop\\SeansBilgiler.mdb");
        public SalonEkle()
        {
            InitializeComponent();
        }

        // Salon fotoğraflarına gözatma butonu.
        private void btnGözat_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.ShowDialog();
            txtSalonFoto.Text = dosya.FileName;
        }

        // SalonEkle tablosundaki verileri listViewSalonEkle de gösterir.
        private void SalonlarıGörüntüle()
        {
            listViewSalonEkle.Items.Clear();

            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select *From SalonEkle";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["sıra"].ToString();
                ekle.SubItems.Add(oku["SalonAdı"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["SalonFoto"].ToString());
                ekle.SubItems.Add(oku["SalonBaşlık"].ToString());
                listViewSalonEkle.Items.Add(ekle);
            }
            baglantı.Close();
        }

        //Salon ekleme butonu.
        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            if (txtSalonÜcret.Text != "")
            {
                try
                {
                    OleDbCommand komut = new OleDbCommand("insert into SalonEkle (SalonAdı,Ücret,SalonFoto,SalonBaşlık) values ('" + txtSalonEkle.Text.Trim().ToUpper() + "','" + txtSalonÜcret.Text + "','" + txtSalonFoto.Text + "','" + txtSalonBaşlık.Text + "')", baglantı);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni Salon Eklendi!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Bu salon daha önce eklenmiştir!");
                }
                Temizle();
            }
            else
            {
                MessageBox.Show("Ücret alanı boş geçilemez!");
            }
            baglantı.Close();
            SalonlarıGörüntüle();
        }

        //Salon silme butonu.
        private void btnSalonSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            try
            {
                komut.Connection = baglantı;
                komut.CommandText = "delete *from SalonEkle where SalonAdı='" + txtSalonEkle.Text.Trim().ToUpper() + "'";
                komut.ExecuteNonQuery();
                MessageBox.Show("Salon silindi!");
                Temizle();
            }
            catch(Exception)
            {
                MessageBox.Show("HATA! Salon silinemedi!");
            }
            baglantı.Close();
            txtSalonEkle.Clear();
            SalonlarıGörüntüle();
        }

        // Salon güncelleme butonu.
        private void btnSalonGüncelle_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d*$");
            Match match = regex.Match(txtSalonGüncelle.Text);

            if (match.Success)
            {
                baglantı.Open();
                OleDbCommand komut = new OleDbCommand();
                try
                {
                    if (txtSalonGüncelle.Text != "")
                    {
                        komut.Connection = baglantı;
                        komut.CommandText = "update SalonEkle set SalonAdı='" + txtSalonEkle.Text.Trim().ToUpper() + "',Ücret='" + txtSalonÜcret.Text + "',SalonBaşlık='" + txtSalonBaşlık.Text + "',SalonFoto='" + txtSalonFoto.Text + "'where sıra=" + txtSalonGüncelle.Text + "";
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Güncelleme başarılı!");
                        Temizle();
                    }
                    else
                        MessageBox.Show("Güncellenecek sıra girilmedi!");
                }
                catch (Exception)
                {
                    MessageBox.Show("HATA! Güncelleme başarısız!");
                }
                baglantı.Close();
                txtSalonGüncelle.Clear();
                SalonlarıGörüntüle();
            }
            else
                MessageBox.Show("Sıra no yanlış girildi!");
        }

        // Salon formu yüklendiğinde olanlar.
        private void SalonEkle_Load(object sender, EventArgs e)
        {
            SalonlarıGörüntüle();
        }

        // sıra no seçilen kaydın bilgilerini textboxlara taşır.
        private void listViewSalonEkle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSalonEkle.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewSalonEkle.SelectedItems[0];
                txtSalonEkle.Text = item.SubItems[1].Text;
                txtSalonÜcret.Text = item.SubItems[2].Text;
                txtSalonFoto.Text = item.SubItems[3].Text;
                txtSalonBaşlık.Text = item.SubItems[4].Text;
            }
        }

        // Textboxları temizleme fonksiyonu.
        private void Temizle()
        {
            txtSalonEkle.Clear();
            txtSalonÜcret.Clear();
            txtSalonBaşlık.Clear();
            txtSalonFoto.Clear();
        }

        //SalonEkle formu kapanınca Seans formu açılıyor.
        private void SalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Seans seans = new Seans();
            seans.Show();
            this.Hide();
        }
    }
}