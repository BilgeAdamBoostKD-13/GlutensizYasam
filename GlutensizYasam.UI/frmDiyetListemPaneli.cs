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
    public partial class frmDiyetListemPaneli : Form
    {
        GlutensizYasamDbContext db;
        Kullanici kullanici;
        BesinGunlukPlan besinGunlukPlan;
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





            //var besinadi = (from g in db.GunlukPlanlar
            //                join gb in db.besinGunlukPlanlar on g.ID equals gb.GunlukPlanId
            //                join b in db.Besinler on gb.BesinId equals b.ID
            //                where g.Ogun == Model.Enums.Ogun.Kahvalti
            //                Select new { besinadi })


            //var besinadi = db.Besinler.Where(a => a. == Model.Enums.Ogun.Kahvalti).ToList().Select(b => new {b.})


            //var index = db.GunlukPlanlar.Where(a => a.Ogun == Model.Enums.Ogun.Kahvalti).Select(a => a.ID).ToList();


            //var index2 = db.besinGunlukPlanlar.Where(a=>a.GunlukPlanId == index).Select(a=> a.BesinId).ToList();
            //int besinid = index2.First();

            //var besinadi = db.Besinler.Where(a => a.ID == besinid).Select(a => a.BesinAdi).ToList();

            //foreach (var item in besinadi)
            //{
            //    flowLayoutPanelKahvalti.Controls.Add(new CheckBox() { Text = item ,Tag = item });
            //}






            /*foreach (var item in ekstralar)
            {
                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = item.Ad, Tag = item });
            }
            */
        }
    }
}
