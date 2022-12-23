using GlutensizYasam.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlutensizYasam.UI
{
    public partial class frmProfilEkrani : Form
    {
        Kullanici kullanici;
        public frmProfilEkrani()
        {
            InitializeComponent();
        }
        
        public frmProfilEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
        }

        private void frmProfilEkrani_Load(object sender, EventArgs e)
        {
            txtKilo.Text = this.kullanici.Kilo.ToString();
            txtBoy.Text = this.kullanici.Boy.ToString();
            txtHedefKilo.Text = this.kullanici.HedefKilo.ToString();
            double boymetre = (this.kullanici.Boy / 100);
            double boykare = boymetre * boymetre;
            double kilo = this.kullanici.Kilo;
            double bki = kilo / boykare;
            lblBKI.Text = bki.ToString();
            string isimsoyisim = $"{this.kullanici.Isim} {this.kullanici.SoyIsim} ";
            lblKullanıcıIsimSoyisim.Text = isimsoyisim;

            if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Erkek)
            {
                if (this.kullanici.SporBilgisi == Model.Enums.SporTipi.SporYok)
                {
                    lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) + 5)*1.2).ToString();
                }
                else if (this.kullanici.SporBilgisi == Model.Enums.SporTipi.OrtaSeviyeli)
                {
                    lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) + 5) * 1.55).ToString();
                }
                else
                {
                    lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) + 5) * 1.72).ToString();
                }
                
            }
            else if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Kadin)
            {
                if (this.kullanici.SporBilgisi == Model.Enums.SporTipi.SporYok)
                {
                    lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) -161) * 1.2).ToString();
                }
                else if (this.kullanici.SporBilgisi == Model.Enums.SporTipi.OrtaSeviyeli)
                {
                    lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) - 161) * 1.55).ToString();
                }
                else
                {
                    lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) - 161) * 1.72).ToString();
                }
                
            }

            if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Erkek)
            {
                lblIdealKilo.Text = ((this.kullanici.Boy - 100) * 0.90).ToString();
            }

            if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Kadin)
            {
                lblIdealKilo.Text = ((this.kullanici.Boy - 100) * 0.85).ToString();
            }
                      

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm=new frmAnaEkran(kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                
    }
}
