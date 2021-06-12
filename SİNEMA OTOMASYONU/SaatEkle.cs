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
    public partial class SaatEkle : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\hanif\\OneDrive\\Desktop\\SeansBilgiler.mdb");
        public SaatEkle()
        {
            InitializeComponent();
        }

        int ToplamHücre=0;

        //SaatEkle tablosunu listViewSaatEkle de gösterir.
        private void SaatleriGörüntüle()
        {
            listViewSaatEkle.Items.Clear();

            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select *From SaatEkle";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["sıra"].ToString();
                ekle.SubItems.Add(oku["Saatler"].ToString());
                listViewSaatEkle.Items.Add(ekle);
            }

            baglantı.Close();
        }

        // SaatEkle tablosunda Saatler sütununda kaç adet veri olduğunu hesaplar.
        private int ToplamSaatSayısı()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("Select count(Saatler) from SaatEkle",baglantı);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ToplamHücre = int.Parse(oku[0].ToString());
            }
            baglantı.Close();
            return ToplamHücre;
        }

        // Daha önce eklenmiş saat var mı diye kontrol eder.
        bool durum;
        private void AynısıVarMı()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select *from SaatEkle where Saatler='" + txtSaatEkle.Text + "'", baglantı);
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

        //Saat ekleme butonu.
        private void btnSaatEkle_Click(object sender, EventArgs e)
        {
            AynısıVarMı();
            try
            {
                if (ToplamSaatSayısı() >= 0 && ToplamSaatSayısı() < 10)
                {
                    if (durum == true)
                    {
                        baglantı.Open();
                        OleDbCommand komut = new OleDbCommand("insert into SaatEkle (Saatler) values ('" + txtSaatEkle.Text.Replace(".", ":") + "')", baglantı);
                        komut.ExecuteNonQuery();
                        baglantı.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bu saat tabloda var!");
                    }
                }
                else
                {
                    MessageBox.Show("Maximum kayıt sayısına ulaştınız!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu saat daha önce eklenmiştir!");
            }

            txtSaatEkle.Clear();
            SaatleriGörüntüle();
        }

        // id si seçilen saati textbox a taşır.
        private void listViewSaatEkle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSaatEkle.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewSaatEkle.SelectedItems[0];
                txtSaatEkle.Text = item.SubItems[1].Text;
            }
        }

        //Saat değiştirme butonu.
        private void btnSaatDeğiştir_Click(object sender, EventArgs e)
        {
            AynısıVarMı();
            try
            {
                if (durum == true)
                {
                    baglantı.Open();
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = baglantı;
                    komut.CommandText = "update SaatEkle set Saatler='" + txtSaatEkle.Text.Replace(".", ":") + "'where sıra=" + listViewSaatEkle.SelectedItems[0].Text + "";
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                }
                else
                {
                    MessageBox.Show("Bu saat tabloda var!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Değiştirme işlemi başarısız!");
            }
            txtSaatEkle.Clear();
            SaatleriGörüntüle();
        }

        //SaatEkle formu kapanınca Seans formunu görüntüler.
        private void SaatEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Seans seans = new Seans();
            seans.Show();
            this.Hide();
        }

        //SaatEkle formu açıldığında olanlar.
        private void SaatEkle_Load(object sender, EventArgs e)
        {
            SaatleriGörüntüle();
            ToplamSaatSayısı();
        }
    }
}