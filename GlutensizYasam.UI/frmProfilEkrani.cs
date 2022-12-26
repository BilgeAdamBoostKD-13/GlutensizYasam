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

namespace GlutensizYasam.UI
{
    public partial class frmProfilEkrani : Form
    {
        GlutensizYasamDbContext context;
        Kullanici kullanici;
        KullaniciService kullaniciService;
        HaftalikKiloKontrolu haftalikKiloKontrolu;
        HaftalikKiloKontroluService haftalikKiloKontroluService;
        public frmProfilEkrani()
        {
            InitializeComponent();
        }
        
        public frmProfilEkrani(Kullanici kullanici,GlutensizYasamDbContext dbcontenxt)
        {
            context = dbcontenxt;
            InitializeComponent();
            this.kullanici = kullanici;
            kullaniciService = new KullaniciService();
            haftalikKiloKontrolu = new HaftalikKiloKontrolu();
            haftalikKiloKontroluService = new HaftalikKiloKontroluService();

            
        }
        
        private void frmProfilEkrani_Load(object sender, EventArgs e)
        {
            List<HaftalikKiloKontrolu> haftalikKiloKontrolleri = context.HaftalikKiloKontrolleri.ToList(); 
            txtKilo.Text = this.kullanici.Kilo.ToString();
            txtBoy.Text = this.kullanici.Boy.ToString();
            txtHedefKilo.Text = this.kullanici.HedefKilo.ToString();
            lblKalori.Text = kullanici.GunlukKaloriIhtiyaci.ToString();
            KiloBilgisiDoldur(haftalikKiloKontrolleri);
            KaloriBilgisiDoldur();
            Hesapla(); 


            
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

        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            List<HaftalikKiloKontrolu> haftalikKiloKontrolleri = context.HaftalikKiloKontrolleri.ToList();
            HaftalikKiloKontrolu haftalikKiloKontrolu = new HaftalikKiloKontrolu();

            haftalikKiloKontrolu.KontrolTarihi = DateTime.Now;
            haftalikKiloKontrolu.AnlikKilo = Convert.ToInt32(txtKilo.Text);
            haftalikKiloKontrolu.KullaniciId = this.kullanici.ID;
            bool checkHaftalikKiloKontrolu = haftalikKiloKontroluService.Insert(haftalikKiloKontrolu);


            
            bool check = kullaniciService.Update(new Kullanici()
            {
                ID = this.kullanici.ID,
                Kilo = Convert.ToInt32(txtKilo.Text),
                Boy = Convert.ToInt32(txtBoy.Text),
                HedefKilo = Convert.ToInt32(txtHedefKilo.Text)

            });
            MessageBox.Show(check ? "Güncelleme başarılı" : "Güncellenemedi");
            KiloBilgisiDoldur(haftalikKiloKontrolleri);
            Temizle();
            Hesapla();
        }
        void Hesapla()
        {
            double boymetre = (this.kullanici.Boy / 100);
            double boykare = boymetre * boymetre;
            double kilo = this.kullanici.Kilo;
            double bki = kilo / boykare;
            lblBKI.Text = bki.ToString();
            string isimsoyisim = $"{this.kullanici.Isim} {this.kullanici.SoyIsim} ";
            lblKullanıcıIsimSoyisim.Text = isimsoyisim;
            //if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Erkek)
            //{
            //    if (this.kullanici.SporBilgisi == Model.Enums.SporTipi.SporYok)
            //    {
            //        lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) + 5) * 1.2).ToString();
            //    }
            //    else if (this.kullanici.SporBilgisi == Model.Enums.SporTipi.OrtaSeviyeli)
            //    {
            //        lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) + 5) * 1.55).ToString();
            //    }
            //    else
            //    {
            //        lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) + 5) * 1.72).ToString();
            //    }

            //}
            //else if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Kadin)
            //{
            //    if (this.kullanici.SporBilgisi == Model.Enums.SporTipi.SporYok)
            //    {
            //        lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) - 161) * 1.2).ToString();
            //    }
            //    else if (this.kullanici.SporBilgisi == Model.Enums.SporTipi.OrtaSeviyeli)
            //    {
            //        lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) - 161) * 1.55).ToString();
            //    }
            //    else
            //    {
            //        lblKalori.Text = (((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) - 161) * 1.72).ToString();
            //    }

            //}

            if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Erkek)
            {
                lblIdealKilo.Text = ((this.kullanici.Boy - 100) * 0.90).ToString();
            }

            if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Kadin)
            {
                lblIdealKilo.Text = ((this.kullanici.Boy - 100) * 0.85).ToString();
            }

        }

        void Temizle()
        {
            lblBKI.Text = null;
            lblIdealKilo.Text = null;
            lblKalori.Text = null;
        }

        void KiloBilgisiDoldur(List<HaftalikKiloKontrolu> liste)
        {
            listViewHaftalikKiloDegisimTablosu.Items.Clear();
            foreach (var item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.KontrolTarihi.ToString();
                lvi.SubItems.Add(item.AnlikKilo.ToString());
                lvi.Tag = item;

                listViewHaftalikKiloDegisimTablosu.Items.Add(lvi);
            }
        }
        void KaloriBilgisiDoldur()

        {
            List<GunlukBesinKontrolu> liste = context.gunlukBesinKontrolleri.ToList();
            foreach (var item in liste)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Tarih.ToString();
                lvi.SubItems.Add(item.GunlukAlinanKalori.ToString());
                lvi.Tag = item;

                listViewGunlukAlinanKalori.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAcilisEkrani frm = new frmAcilisEkrani();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }

    
}
