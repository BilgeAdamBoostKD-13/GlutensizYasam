using GlutensizYasam.BLL.Services;
using GlutensizYasam.DAL;
using GlutensizYasam.DAL.Repositories;
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
    public partial class frmGunlukProgramOluşturmaEkrani : Form
    {
        Kullanici kullanici;
        GlutensizYasamDbContext db;
        GunlukPlan gunlukPlan;
        Besin besin;
        BesinService besinService;
        GunlukPlanService gunlukPlanService;

        
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

        private void btnEkleKahvalti_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //if (besin.AktifMi)// AKTİF Mİ EKLENEBİLİR Mİ ? 
           // {
                //DialogResult result = MessageBox.Show("Seçilen besin gluten içermektedir. Eklemek istediğinize emin misiniz ?","UYARI!!!",MessageBoxButtons.YesNo);

                //if (result == DialogResult.Yes)
                //{
                    if (listBoxBesinler.SelectedItem != null)
                    {
                        if (cmbGidecekOgun.Text == "Kahvaltı Öğünü")
                        {
                            ListViewItem lvi = ListViewDoldur();
                            lstViewKahvalti.Items.Add(lvi);

                        }
                        else if (cmbGidecekOgun.Text == "Öğle Öğünü")
                        {
                            ListViewItem lvi = ListViewDoldur();
                            lstViewOgle.Items.Add(lvi);

                        }
                        else if (cmbGidecekOgun.Text == "Ara Öğün")
                        {
                            ListViewItem lvi = ListViewDoldur();
                            lstViewAra.Items.Add(lvi);

                        }
                        else if (cmbGidecekOgun.Text == "Akşam Öğünü")
                        {
                            ListViewItem lvi = ListViewDoldur();
                            lstViewAksam.Items.Add(lvi);

                        }
                    }
                //}
           //}
           
            
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
            /*List<Besin> besin = db.Besinler.Where(a => a.I).Select(a => a.BesinAdi).ToList();
             *
            var employees = db.Employees.Select(a => a.FirstName);
            //foreach (var item in employees)
            //{
            //    lstBxEmployee.Items.Add(item); 
            //}
            */


            var besinadi = db.Besinler.Select(a => a.BesinAdi);

            foreach (var item in besinadi)
            {
                listBoxBesinler.Items.Add(item);
            }

            

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

        private void btnSilKahvalti_Click(object sender, EventArgs e)
        {
            lstViewKahvalti.Items.Clear();
        }

        private void btnSilOgle_Click(object sender, EventArgs e)
        {
            lstViewOgle.Items.Clear();
        }

        private void btnSilAra1_Click(object sender, EventArgs e)
        {
            lstViewAra.Items.Clear();
        }

        private void btnSilAksam_Click(object sender, EventArgs e)
        {
            lstViewAksam.Items.Clear();
        }

        private void btnKaydet1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
;