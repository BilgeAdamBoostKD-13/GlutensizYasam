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
    public partial class frmBesinlerEkrani : Form
    {
        Kullanici kullanici;
        GlutensizYasamDbContext db;
        BesinService besinService;
        public frmBesinlerEkrani()
        {
            InitializeComponent();
        }
        public frmBesinlerEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            db = new GlutensizYasamDbContext();
            besinService = new BesinService();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran(kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmBesinlerEkrani_Load(object sender, EventArgs e)
        {
            Doldur();            
        }

        
        void Doldur()
        {
            var besinadi = db.Besinler.Select(a => a.BesinAdi);

            foreach (var item in besinadi)
            {
                listBoxBesinler.Items.Add(item.ToLower());
            }
        }

        private void listBoxBesinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBesinAd.Text = listBoxBesinler.SelectedItems[0].ToString();
            string aranan = listBoxBesinler.SelectedItems[0].ToString();
            var bulunan = db.Besinler.Where(a => a.BesinAdi == aranan).Select(a => a.Protein).ToList();
            string protein = bulunan.First().ToString();
            lblProtein.Text = protein;

            var bulunan1 = db.Besinler.Where(a => a.BesinAdi == aranan).Select(a => a.Yag).ToList();
            string yag = bulunan1.First().ToString();
            lblYag.Text = yag;

            var bulunan2 = db.Besinler.Where(a => a.BesinAdi == aranan).Select(a => a.Karbonhidrat).ToList();
            string kh = bulunan2.First().ToString();
            lblKarbonhidrat.Text = kh;

            var bulunan3 = db.Besinler.Where(a => a.BesinAdi == aranan).Select(a => a.Kalori).ToList();
            lblKalori.Text = bulunan3.First().ToString();

            var bulunan4 = db.Besinler.Where(a => a.BesinAdi == aranan).Select(a => a.AktifMi).ToList();
            if (bulunan4.First() == true)
            {
                lblGlutenVarYok.Text = "VAR";
            }
            else
            {
                lblGlutenVarYok.Text = "YOK";
            }
        }

        private void txtBesin_TextChanged(object sender, EventArgs e)
        {
            listBoxBesinler.Items.Clear();
            var besinadi = db.Besinler.Select(a => a.BesinAdi);
            
            foreach (var item in besinadi)
            {
                if (item.ToLower().Contains(txtBesin.Text))
                {
                    listBoxBesinler.Items.Add(item.ToLower());
                    
                }
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm = new frmAnaEkran(kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
