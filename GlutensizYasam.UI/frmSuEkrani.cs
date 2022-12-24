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
    public partial class frmSuEkrani : Form
    {
        Kullanici kullanici;
        GunlukBesinKontrolu gbk;
        GunlukBesinKontroluService gbkservice;
        KullaniciService kullaniciService;
        GunlukPlan gunlukPlan;
        GlutensizYasamDbContext db;

        public frmSuEkrani()
        {
            InitializeComponent();
        }
        public frmSuEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            gbk = new GunlukBesinKontrolu();
            gbkservice = new GunlukBesinKontroluService();
            kullaniciService = new KullaniciService();
            gunlukPlan = new GunlukPlan();
            db = new GlutensizYasamDbContext();
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

        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            gbk.Tarih = DateTime.Now;
            gbk.GunlukIcilenSu = 200;
            int kullaniciID = kullaniciService.KullaniciIdGetir(this.kullanici.EMail);
            var index = db.GunlukPlanlar.Where(a => a.KullaniciId == kullaniciID).Select(a => a.ID);
            int gunlukplanID = index.First();
            bool check = gbkservice.Insert(gbk);
            var index2 = db.gunlukBesinKontrolleri.Where(a => a.GunlukPlanID == gunlukplanID).Select(a => a.ID);
            int gunlukbesinkontroluID = index2.First();


            if (progressBarSu.Value == 2400)
            {
                MessageBox.Show("TEBRİKLER. BUGUNKÜ SU İHTİYACINIZI KARŞILADINIZ!");
            }
        }
    }
}
