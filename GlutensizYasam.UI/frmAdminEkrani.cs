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
    public partial class frmAdminEkrani : Form
    {
        Kullanici kullanici;
        GlutensizYasamDbContext db;
        public frmAdminEkrani()
        {
            InitializeComponent();
        }
        public frmAdminEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            db = new GlutensizYasamDbContext();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdminEkrani_Load(object sender, EventArgs e)
        {
            lvKullanici.Items.Clear();
            var kullanicilar = db.Kullanicilar.Select(a => new
            {
                a.Isim,
                a.SoyIsim,
                a.EMail,

            }).ToList();
            foreach (var item in kullanicilar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Isim.ToString();
                lvi.SubItems.Add(item.SoyIsim.ToString());
                lvi.SubItems.Add(item.EMail.ToString());
                lvi.SubItems.Add(item.SoyIsim.ToString());
                lvi.Tag = item;

                lvKullanici.Items.Add(lvi);
            }
        }
    }
}
