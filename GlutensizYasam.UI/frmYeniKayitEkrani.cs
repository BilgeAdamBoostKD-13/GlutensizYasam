using GlutensizYasam.BLL.Services;
using GlutensizYasam.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GlutensizYasam.UI
{
    
    public partial class frmYeniKayitEkrani : Form
    {
        KullaniciService kullaniciService;
        ParolaService parolaService;
        public frmYeniKayitEkrani()
        {
            InitializeComponent();
            kullaniciService = new KullaniciService();
            parolaService = new ParolaService();
        }

        private void frmYeniKayitEkrani_Load(object sender, EventArgs e)
        {
            rbYok.Checked = true;
            rbKadin.Checked = true;
            txtKullaniciAd.Enabled = false;
        }

        private void linkGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAcilisEkrani acilisEkrani = new frmAcilisEkrani();
            this.Hide();
            acilisEkrani.ShowDialog();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Isim = txtIsim.Text;
            kullanici.SoyIsim = txtSoyisim.Text;
            kullanici.EMail = txtEmail.Text;
            kullanici.Cinsiyet = rbErkek.Checked ? Model.Enums.Cinsiyet.Erkek : Model.Enums.Cinsiyet.Kadin;
            kullanici.DogumTarihi = dateTimePickerDogumTarihi.Value;
            kullanici.Kilo = Convert.ToInt32(txtKilo.Text);
            kullanici.Boy = Convert.ToInt32(txtBoy.Text);
            kullanici.HedefKilo = Convert.ToInt32(txtHedefKilo.Text);
            

            if (cbGizlilikPol.Checked && cbUyelikSoz.Checked)
            {
               ///
            }

            if (txtParola.Text == txtParolaTekrar.Text)
            {
                kullanici.Parolalar.Add(new Parola()
                {
                    UserPassword = txtParola.Text
                });

            }

            if (rbYok.Checked)
            {
                kullanici.SporBilgisi = Model.Enums.SporTipi.SporYok;
            }
            else if (rbOrtaSeviye.Checked)
            {
                kullanici.SporBilgisi = Model.Enums.SporTipi.OrtaSeviyeli;
            }

            else if (rbYuksekSeviye.Checked)
            {
                kullanici.SporBilgisi = Model.Enums.SporTipi.YuksekSeviyeli;
            }
                    
            
            bool check = kullaniciService.Insert(kullanici);
            MessageBox.Show(check ? "Kullanıcı eklendi" : "Kullanıcı eklenemedi");

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciAd.Text = txtEmail.Text;
        }
    }
    
}
