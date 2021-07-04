using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİNEMA_OTOMASYONU
{
    public partial class AdminAnasayfa : Form
    {
        public AdminAnasayfa()
        {
            InitializeComponent();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            Film yeni = new Film();
            yeni.Show();
            this.Hide();
        }

        private void btnSeans_Click(object sender, EventArgs e)
        {
            Seans yeni = new Seans();
            yeni.Show();
            this.Hide();
        }

        private void btnBilet_Click(object sender, EventArgs e)
        {
            Bilet yeni = new Bilet();
            yeni.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminEkle yeni = new AdminEkle();
            yeni.Show();
            this.Hide();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            DialogResult çıkış;
            çıkış = MessageBox.Show("Programı kapatmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (çıkış == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void AdminAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            KullanıcıGiriş yeni = new KullanıcıGiriş();
            yeni.Show();
        }
    }
}