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
        string hata;
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
            txtParola.PasswordChar = '*';
            txtParolaTekrar.PasswordChar = '*';
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
            try
            {
                kullanici.Isim = txtIsim.Text;
                kullanici.SoyIsim = txtSoyisim.Text;
                kullanici.EMail = txtEmail.Text;             

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

            bool checkEmail = kullaniciService.EmailKontrolu(txtEmail.Text);

            if (checkEmail)
            {
                MessageBox.Show("Bu mail adresi kullanılıyor");
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

            if (txtIsim.Text != null && txtSoyisim.Text != null && txtEmail.Text !=null && sayac ==3 && (
                txtParola.Text.Length>5
                && txtParola.Text.Any(char.IsLower)
                && txtParola.Text.Any(char.IsUpper)
                && txtParola.Text.Any(char.IsNumber) 
                && txtParola.Text ==txtParolaTekrar.Text)
                && !checkEmail)
            {
                bool check = kullaniciService.Insert(kullanici);
                MessageBox.Show(check ? "Kullanıcı eklendi" : "Kullanıcı eklenemedi");
            }
            
            if (sayac == 2)
            {
                //MessageBox.Show("Üye olmak için gizlilik politikasını onaylamanız gerekmektedir.");
                hata += "Üye olmak için gizlilik politikasını onaylamanız gerekmektedir. \n";
            }
            else if (sayac == 1)
            {
                //MessageBox.Show("Üye olmak üyelik sözleşmesini onaylanamnız gerekmektedir.");
                hata += "Üye olmak üyelik sözleşmesini onaylanamnız gerekmektedir. \n";
            }
            else if (sayac == 0)
            {
                //MessageBox.Show("Gizlilik politikası ve üyelik sözleşmesi onaylanması gerekmektedir.");
                hata += "Gizlilik politikası ve üyelik sözleşmesi onaylanması gerekmektedir. \n";
            }

            if (txtParola.Text.Length < 6) /*MessageBox.Show("Parolanız 6 karakterden az olamaz");*/ hata += "Parolanız 6 karakterden az olamaz \n";
            if (!txtParola.Text.Any(char.IsLower)) /*MessageBox.Show("Parolanızda en az 1 küçük harf olmalı");*/ hata += "Parolanızda en az 1 küçük harf olmalı \n";
            if (!txtParola.Text.Any(char.IsUpper)) /*MessageBox.Show("Parolanızda en az 1 büyük harf olmalı");*/ hata += "Parolanızda en az 1 büyük harf olmalı \n";
            if (!txtParola.Text.Any(char.IsNumber)) /*MessageBox.Show("Parolanızda en az 1 sayı olmalı");*/ hata += "Parolanızda en az 1 sayı olmalı \n";

            if (hata != null)
            {
                MessageBox.Show(hata);
                hata = null;
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
                sayac += 2;
            }
            else
            {
                sayac -= 2;
            }
        }
    }
    
}
