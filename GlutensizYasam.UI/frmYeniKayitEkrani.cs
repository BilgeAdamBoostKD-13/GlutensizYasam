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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GlutensizYasam.UI
{
    
    public partial class frmYeniKayitEkrani : Form
    {
        int sayac;
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
            if (txtIsim.Text != null)
            {
                kullanici.Isim = txtIsim.Text; 
            }
            else
            {
                MessageBox.Show("Lütfen isim giriniz");
            }
            if (txtSoyisim.Text != null)
            {
                kullanici.SoyIsim = txtSoyisim.Text; 
            }
            else
            {
                MessageBox.Show("Lütfen soyisim giriniz");
            }
            if (txtEmail.Text != null)
            {
                if (txtEmail.Text.Contains("@") && txtEmail.Text.EndsWith(".com"))
                {
                    kullanici.EMail = txtEmail.Text;
                }
                else
                {
                    MessageBox.Show("e-mail geçerli formatta değil");
                }
            }
            else
            {
                MessageBox.Show("Lütfen email giriniz");
            }

            kullanici.Cinsiyet = rbErkek.Checked ? Model.Enums.Cinsiyet.Erkek : Model.Enums.Cinsiyet.Kadin;
            kullanici.DogumTarihi = dateTimePickerDogumTarihi.Value;
            kullanici.Kilo = Convert.ToInt32(nudKilo.Text);
            kullanici.Boy = Convert.ToInt32(nudBoy.Text);
            kullanici.HedefKilo = Convert.ToInt32(nudHedefKilo.Text);

           

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

            if (txtIsim.Text != null && txtSoyisim.Text != null && txtEmail.Text !=null && (
                txtParola.Text.Length>5
                && txtParola.Text.Any(char.IsLower)
                && txtParola.Text.Any(char.IsUpper)
                && txtParola.Text.Any(char.IsNumber) && txtParola.Text ==txtParolaTekrar.Text))
            {
                bool check = kullaniciService.Insert(kullanici);
                MessageBox.Show(check ? "Kullanıcı eklendi" : "Kullanıcı eklenemedi");
            }
            
            
            

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciAd.Text = txtEmail.Text;
        }
        
        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            if (txtParola.Text.Length > 5)
            {
                lblkarakter.Text = "√ En az 6 karakter uzunluğunda olmalı";
                lblkarakter.ForeColor = Color.Green;
            }
            else
            {
                lblkarakter.Text = "X En az 6 karakter uzunluğunda olmalı";
                lblkarakter.ForeColor = Color.Red;
            }

            
            if (txtParola.Text.Any(char.IsLower))
            {
                lblkucuk.Text = "√ En az 1 küçük harf içermeli";
                lblkucuk.ForeColor = Color.Green;
                
            }
            else
            {
                lblkucuk.Text = "X En az 1 küçük harf içermeli";
                lblkucuk.ForeColor = Color.Red;
            }

            if (txtParola.Text.Any(char.IsUpper))
            {
                lblbuyuk.Text = "√ En az 1 büyük harf içermeli";
                lblbuyuk.ForeColor = Color.Green;

            }
            else
            {
                lblbuyuk.Text = "X En az 1 büyük harf içermeli";
                lblbuyuk.ForeColor = Color.Red;
            }

            if (txtParola.Text.Any(char.IsNumber))
            {
                lblsayi.Text = "√ En az 1 sayı içermeli";
                lblsayi.ForeColor = Color.Green;
                
            }
            else if (!txtParola.Text.Any(char.IsNumber))
            {
                lblsayi.Text = "X En az 1 sayı içermeli";
                lblsayi.ForeColor = Color.Red;
            }
        }

        private void cbGizlilikPol_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGizlilikPol.Checked == true)
            {
                sayac += 1;
            }
            else
            {
                sayac -= 1;
            }
        }

        private void cbUyelikSoz_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUyelikSoz.Checked == true)
            {
                sayac += 1;
            }
            else
            {
                sayac -= 1;
            }
        }
    }
    
}
