using GlutensizYasam.DAL;
using GlutensizYasam.Model.Entities;
using GlutensizYasam.Model.Enums;
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
    public partial class frmDiyetListemPaneli : Form
    {
        GlutensizYasamDbContext db;
        Kullanici kullanici;
        BesinGunlukPlan besinGunlukPlan;
        GunlukBesinKontrolu gunlukBesinKontrolu;
        double _kalori = 0;
        public frmDiyetListemPaneli()
        {
            InitializeComponent();
           
        }
        public frmDiyetListemPaneli(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            db = new GlutensizYasamDbContext();
            besinGunlukPlan = new BesinGunlukPlan();
            gunlukBesinKontrolu = new GunlukBesinKontrolu();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran(kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDiyetListemPaneli_Load(object sender, EventArgs e)
        {
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
                    else if (Convert.ToInt32(item.Ogun) == 3)
                    {
                        GunlukPlanIdListAksam.Add(item.ID);
                    }
                }
            }

            BesinGetir(GunlukPlanIDListKahvalti, flowLayoutPanelKahvalti);
            BesinGetir(GunlukPlanIdListOgle, flowLayoutPanelOgleYemegi);
            BesinGetir(GunlukPlanIdListAra, flowLayoutPanelAraOgun1);
            BesinGetir(GunlukPlanIdListAksam, flowLayoutPanelAksamYemegi);
        }
        void BesinGetir(List<int> ıd, FlowLayoutPanel panel)
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
                panel.Controls.Add(new CheckBox() { Text = besin.First(), Tag = item });
            }
        }


        private void btnKaydet1_Click(object sender, EventArgs e)
        {
            KaloriTopla(flowLayoutPanelKahvalti);
            KaloriTopla(flowLayoutPanelOgleYemegi);
            KaloriTopla(flowLayoutPanelAraOgun1);
            KaloriTopla(flowLayoutPanelAksamYemegi);
            var index = db.GunlukPlanlar.Select(a => a.ID).ToList();
            GunlukBesinKontrolu gbk = new GunlukBesinKontrolu()
            {
                GunlukAlinanKalori = (int)_kalori,
                GunlukPlanID = index.Last()
                
            };
            db.gunlukBesinKontrolleri.Add(gbk); 
            db.SaveChanges();

        }

        void KaloriTopla(FlowLayoutPanel panel)
        {
            foreach (CheckBox item in panel.Controls)
            {
                if (item.Checked)
                {
                    var index = db.Besinler.Where(a => a.BesinAdi == item.Text).Select(b => b.Kalori).ToList();
                    _kalori += index.First();
                    lblTotalKalori.Text = _kalori.ToString();

                    var index2 = db.Besinler.Where(a => a.BesinAdi == item.Text).Select(b => b.AktifMi).ToList();
                    bool glutenVarMi = index2.First();
                    if (glutenVarMi == true)
                    {
                        lblEvetHayir.Text = "Evet";
                    }
                }
            }

        }
    }

}
