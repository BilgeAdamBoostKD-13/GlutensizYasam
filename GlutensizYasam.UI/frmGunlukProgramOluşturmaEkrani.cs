using GlutensizYasam.BLL.Services;
using GlutensizYasam.DAL;
using GlutensizYasam.DAL.Repositories;
using GlutensizYasam.Model.Entities;
using GlutensizYasam.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlutensizYasam.UI
{
    public partial class frmGunlukProgramOluşturmaEkrani : Form
    {
        Kullanici kullanici;
        GlutensizYasamDbContext db;
        GunlukPlan gunlukPlan;
        Besin besin;
        BesinService besinService;
        BesinGunlukPlan besinGunlukPlan;
        GunlukPlanService gunlukPlanService;
        double alinan = 0;


        public frmGunlukProgramOluşturmaEkrani()
        {
            InitializeComponent();
        }
        public frmGunlukProgramOluşturmaEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            db = new GlutensizYasamDbContext();
            besin = new Besin();
            gunlukPlan = new GunlukPlan();
            besinService = new BesinService();
            gunlukPlanService = new GunlukPlanService();
            besinGunlukPlan = new BesinGunlukPlan();
        }

        public frmGunlukProgramOluşturmaEkrani(Besin besin)
        {
            InitializeComponent();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran(kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (listBoxBesinler.SelectedItem != null)
            {
                if (cmbGidecekOgun.Text == "Kahvaltı Öğünü")
                {
                    ListViewItem lvi = ListViewDoldur();
                    lstViewKahvalti.Items.Add(lvi);
                    GonderDataBase(Model.Enums.Ogun.Kahvalti);
                }
                else if (cmbGidecekOgun.Text == "Öğle Öğünü")
                {
                    ListViewItem lvi = ListViewDoldur();
                    lstViewOgle.Items.Add(lvi);
                    GonderDataBase(Model.Enums.Ogun.OgleOgunu);
                }
                else if (cmbGidecekOgun.Text == "Ara Öğün")
                {
                    ListViewItem lvi = ListViewDoldur();
                    lstViewAra.Items.Add(lvi);
                    GonderDataBase(Model.Enums.Ogun.AraOgunu);
                }
                else if (cmbGidecekOgun.Text == "Akşam Öğünü")
                {
                    ListViewItem lvi = ListViewDoldur();
                    lstViewAksam.Items.Add(lvi);
                    GonderDataBase(Model.Enums.Ogun.AkşamOgunu);

                }
                var index = db.Besinler.Where(a => a.BesinAdi == listBoxBesinler.SelectedItem.ToString()).Select(a => a.Kalori).ToList();
                double _kalori = index.First();
                alinan += _kalori;
                if (kullanici.GunlukKaloriIhtiyaci > alinan)
                {
                    lblAlinanKalori.Text = alinan.ToString();
                    lblKalanKalori.Text = (kullanici.GunlukKaloriIhtiyaci - alinan).ToString();
                }
                else
                {
                    MessageBox.Show("Günlük Kalor ihtiyacınızı doldurdunuz");
                    btnEkle.Enabled = false;
                }
            }
        }

        private ListViewItem ListViewDoldur()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = listBoxBesinler.SelectedItem.ToString();
            lvi.Tag = listBoxBesinler.SelectedItem;
            return lvi;
        }

        private void frmGunlukProgramOluşturmaEkrani_Load(object sender, EventArgs e)
        {
            cmbGidecekOgun.Items.Add("Kahvaltı Öğünü");
            cmbGidecekOgun.Items.Add("Öğle Öğünü");
            cmbGidecekOgun.Items.Add("Ara Öğün");
            cmbGidecekOgun.Items.Add("Akşam Öğünü");

            lblGunlukKalori.Text = kullanici.GunlukKaloriIhtiyaci.ToString();

            var besinadi = db.Besinler.Select(a => a.BesinAdi);

            foreach (var item in besinadi)
            {
                listBoxBesinler.Items.Add(item);
            }
            List<int> GunlukPlanIDListKahvalti = new List<int>();
            List<int> GunlukPlanIdListOgle = new List<int>();
            List<int> GunlukPlanIdListAra = new List<int>();
            List<int> GunlukPlanIdListAksam = new List<int>();
            

            List<GunlukPlan> gunlukplan = db.GunlukPlanlar.ToList();
            
            foreach (var item in gunlukplan)
            {
                if (item.Tarih.Year == DateTime.Now.Year && item.Tarih.Month == DateTime.Now.Month && item.Tarih.Day == DateTime.Now.Day)
                {
                    if (item.Ogun == 0)
                    {
                        GunlukPlanIDListKahvalti.Add(item.ID);
                    }
                    else if (Convert.ToInt32(item.Ogun) == 1)
                    {
                        GunlukPlanIdListOgle.Add(item.ID);
                    }
                    else if (Convert.ToInt32(item.Ogun) == 2)
                    {
                        GunlukPlanIdListAra.Add(item.ID);
                    }
                    else if (Convert.ToInt32(item.Ogun) == 3 )
                    {
                        GunlukPlanIdListAksam.Add(item.ID);
                    }
                }
            }

            BesinGetir(GunlukPlanIDListKahvalti, lstViewKahvalti);
            BesinGetir(GunlukPlanIdListOgle, lstViewOgle);
            BesinGetir(GunlukPlanIdListAra, lstViewAra);
            BesinGetir(GunlukPlanIdListAksam, lstViewAksam);
            



        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                listBoxBesinler.Items.Clear();
                int besinID = besinService.BesinBul(txtArananBesinOgesi.Text);
                var besinadi = db.Besinler.Select(a => a.BesinAdi);
                foreach (var item in besinadi)
                {
                    if (item == txtArananBesinOgesi.Text)
                    {
                        listBoxBesinler.Items.Add(item);
                    } 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void GonderDataBase(Ogun ogun)
        {
            var index = db.Besinler.Where(a => a.BesinAdi == listBoxBesinler.SelectedItem.ToString()).Select(a => a.ID).ToList();
            int _besinId = index.First();
            Besin besin = new Besin();
            GunlukPlan gp = new GunlukPlan()
            {
                Tarih = DateTime.Now,
                Ogun = ogun,
                KullaniciId = this.kullanici.ID,
            };
            db.GunlukPlanlar.Add(gp); db.SaveChanges();

            var index2 = db.GunlukPlanlar.Select(a => a.ID).ToList();
            int _gunlukPlanId = index2.Last();

            BesinGunlukPlan bgp = new BesinGunlukPlan()
            {
                BesinId = _besinId,
                GunlukPlanId = _gunlukPlanId,
            };

            db.besinGunlukPlanlar.Add(bgp); db.SaveChanges();
        }
        void BesinGetir(List<int> ıd,ListView lstview)
        {
            List<int> BesinIdList = new List<int>();
            List<BesinGunlukPlan> besinGunlukPlans = db.besinGunlukPlanlar.ToList();
            foreach (var item in besinGunlukPlans)
            {
                foreach (var item2 in ıd)
                {
                    if (item.GunlukPlanId == item2)
                    {
                        BesinIdList.Add(item.BesinId);
                    }
                }
            }
            foreach (var item in BesinIdList)
            {
                var besin = db.Besinler.Where(a => a.ID == item).Select(b => b.BesinAdi).ToList();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = besin.First();
                lstview.Items.Add(lvi);
                var index = db.Besinler.Where(a => a.ID == item).Select(b => b.Kalori).ToList();
                double kalori = index.First();
                alinan += kalori;
                if (kullanici.GunlukKaloriIhtiyaci > alinan)
                {
                    lblAlinanKalori.Text = alinan.ToString();
                    lblKalanKalori.Text = (kullanici.GunlukKaloriIhtiyaci - alinan).ToString();
                }
            
            }


        }
    }
}
;