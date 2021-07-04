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
    public partial class AdminEkle : Form
    {
        OleDbConnection baglantı = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\hanif\\OneDrive\\Desktop\\Kullanıcı Giriş 2002-2003.mdb");
        public AdminEkle()
        {
            InitializeComponent();
        }

        OleDbCommand komut = new OleDbCommand();


        private void verilerigöster()
        {
            listViewAdmin.Items.Clear();
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select * From Kullanıcı_Giriş";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["k_no"].ToString();
                ekle.SubItems.Add(oku["k_ad"].ToString());
                ekle.SubItems.Add(oku["k_sifre"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                listViewAdmin.Items.Add(ekle);
            }
            baglantı.Close();
            txtYeniAdmin.Clear();
            txtYeniŞifre.Clear();
            txtYeniMail.Clear();
            txtSil.Text = "0";
            txtGüncelle.Text = "0";
        }

        private void AdminEkle_Load(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            if (txtYeniAdmin.Text != "")
            {
                if (txtYeniŞifre.Text != "")
                {
                    if (txtYeniMail.Text != "")
                    {
                        try
                        {
                            komut = new OleDbCommand("insert into Kullanıcı_Giriş(k_ad,k_sifre,email) values ('" + txtYeniAdmin.Text.ToString() + "','" + txtYeniŞifre.Text.ToString() + "','" + txtYeniMail.Text.ToString() + "')", baglantı);
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Yeni Admin Eklendi!");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Bu admin daha önce eklendi!!!", "UYARI");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mail alanı boş geçilmez!!!", "UYARI");
                    }
                }
                else
                {
                    MessageBox.Show("Şifre alanı boş geçilmez!!!", "UYARI");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı alanı boş geçilmez!!!", "UYARI");
            }
            baglantı.Close();
            verilerigöster();
        }

        private void btnAdminSil_Click(object sender, EventArgs e)
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
                        komut.CommandText = "delete from Kullanıcı_Giriş where k_no = " + txtSil.Text + "";
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

        private void btnAdminGüncelle_Click(object sender, EventArgs e)
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
                        komut.CommandText = "update Kullanıcı_Giriş set  k_ad='" + txtYeniAdmin.Text + "',k_sifre='" + txtYeniŞifre.Text + "',email='" + txtYeniMail.Text + "' where k_no=" + txtGüncelle.Text + "";
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

        private void listViewAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAdmin.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewAdmin.SelectedItems[0];
                txtYeniAdmin.Text = item.SubItems[1].Text;
                txtYeniŞifre.Text = item.SubItems[2].Text;
                txtYeniMail.Text = item.SubItems[3].Text;
            }
        }

        private void checkŞifreyiGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkŞifreyiGöster.Checked)
            {
                txtYeniŞifre.PasswordChar = '\0';
            }
            else
            {
                txtYeniŞifre.PasswordChar = '*';
            }
        }

        private void AdminEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdminAnasayfa yeni = new AdminAnasayfa();
            yeni.Show();
        }
    }
}
