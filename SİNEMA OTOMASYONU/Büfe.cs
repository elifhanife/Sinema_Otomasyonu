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
    public partial class Büfe : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\hanif\\OneDrive\\Desktop\\SeansBilgiler.mdb");
        public Büfe()
        {
            InitializeComponent();
        }

        int ToplamHücre = 0;

        // listViewBüfe de Büfe tablosunu görüntüleme.
        private void BüfeyiGörüntüle()
        {
            listViewBüfe.Items.Clear();

            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select *From Büfe";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["Ürün"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                listViewBüfe.Items.Add(ekle);
            }
            baglantı.Close();
        }

        // Büfe tablosundaki Ürün sütununda yer alan veri sayısını döndürür.
        private int ToplamÜrünSayısı()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select count(Ürün) from Büfe", baglantı);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ToplamHücre = int.Parse(oku[0].ToString());
            }
            baglantı.Close();
            return ToplamHücre;
        }

        // En fazla 5 ürünü Büfe tablosuna ekler.
        private void BüfeyeEkle()
        {
            try
            {
                if (ToplamÜrünSayısı() >= 0 && ToplamÜrünSayısı() < 5)
                {
                    baglantı.Open();
                    OleDbCommand komut = new OleDbCommand("insert into Büfe (Ürün,Fiyat) values ('" + txtBüfeÜrün.Text.Trim().ToLower() + "','" + txtBüfeFiyat.Text + "')", baglantı);
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                }
                else
                {
                    MessageBox.Show("Maximum kayıt sayısına ulaştınız!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu ürün daha önce eklenmiştir!");
            }

            txtBüfeÜrün.Clear();
            txtBüfeFiyat.Clear();
            BüfeyiGörüntüle();
        }

        // Büfeye ekleme butonu.
        private void btnBüfeEkle_Click(object sender, EventArgs e)
        {
            BüfeyeEkle();
        }

        // listViewBüfe de tıklanılan ID nin bilgilerini textboxlara taşır.
        private void listViewBüfe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBüfe.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewBüfe.SelectedItems[0];
                txtBüfeÜrün.Text = item.SubItems[1].Text;
                txtBüfeFiyat.Text = item.SubItems[2].Text;
            }
        }

        // Büfe tablosunda kayıt güncelleme butonu.
        private void btnBüfeGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglantı;
                komut.CommandText = "update Büfe set Ürün='" + txtBüfeÜrün.Text.ToLower() + "',Fiyat='"+txtBüfeFiyat.Text+"'where ID=" + listViewBüfe.SelectedItems[0].Text + "";
                komut.ExecuteNonQuery();
                baglantı.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Değiştirme işlemi başarısız!");
            }

            txtBüfeFiyat.Clear();
            txtBüfeÜrün.Clear();
            BüfeyiGörüntüle();
        }

        //Büfe formu kapandığında Bilet formuna geri döner.
        private void Büfe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bilet yeni = new Bilet();
            yeni.Show();
        }

        private void Büfe_Load(object sender, EventArgs e)
        {
            BüfeyiGörüntüle();// listViewBüfe de Büfe verilerini gösterir.
        }
    }
}