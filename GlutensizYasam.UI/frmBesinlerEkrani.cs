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
                
                var besinadi = db.Besinler.Select(a => a.BesinAdi);
                
                foreach (var item in besinadi)
                {
                    if (item == txtBesin.Text)
                    {
                        listBoxBesinler.Items.Add(item);
                        lblBesinAd.Text=item.ToString();
                        
                    }
                }
                int besinID = besinService.BesinBul(txtBesin.Text);
                var kalori = db.Besinler.Where(a=>a.ID==besinID).Select(a=>a.Kalori);
                lblKalori.Text = kalori.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //
            //var protein = db.Besinler.Select(b => b.Protein);
            //var karbonhidrat = db.Besinler.Select(b => b.Karbonhidrat);
            //var yag = db.Besinler.Select(b => b.Yag);

            //lblKalori.Text = kalori.ToString();
            //lblProtein.Text = protein.ToString();
            //lblKarbonhidrat.Text = karbonhidrat.ToString();
            //lblYag.Text = yag.ToString();
            //var aktif =db.Besinler.Select(b => b.AktifMi);
        }
    }
}
