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
    public partial class frmYemekTarifiEkrani : Form
    {
        Kullanici kullanici;
        GlutensizYasamDbContext db;
        TarifService tarifService;
        public frmYemekTarifiEkrani()
        {
            InitializeComponent();
        }
        public frmYemekTarifiEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            db = new GlutensizYasamDbContext();
            tarifService = new TarifService();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void frmYemekTarifiOlusturmaEkrani_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            var tarifAdi = db.Tarifler.Select(a => a.TarifAdi);

            foreach (var item in tarifAdi)
            {
                listBoxBesinler.Items.Add(item.ToLower());
            }
        }

        private void listBoxBesinler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ara = listBoxBesinler.SelectedItems[0].ToString();
            lblTarifAd.Text = ara;
            var aranan = db.Tarifler.Where(a => a.TarifAdi == ara).Select(a => a.TarifIcerigi).ToList();
            var bulunan = aranan.First().ToString();
            txtAcıklama.Text = bulunan;
        }

        private void txtArananBesinOgesi_TextChanged(object sender, EventArgs e)
        {
            listBoxBesinler.Items.Clear();
            var tarifAdi = db.Tarifler.Select(a => a.TarifAdi);

            foreach (var item in tarifAdi)
            {
                if (item.ToLower().Contains(txtArananBesinOgesi.Text))
                {
                    listBoxBesinler.Items.Add(item.ToLower());

                }
            }
        }
    }
}
