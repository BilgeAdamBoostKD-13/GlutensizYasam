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
    public partial class frmAnaEkran : Form
    {
        Kullanici kullanici;
        GlutensizYasamDbContext dbContext;
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        public frmAnaEkran(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            dbContext = new GlutensizYasamDbContext();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmProfilEkrani frm = new frmProfilEkrani(this.kullanici,dbContext);
            this.Hide();
            frm.ShowDialog();
            this.Show();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmDiyetListemPaneli frm = new frmDiyetListemPaneli(this.kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmSuEkrani frm = new frmSuEkrani(this.kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmBesinlerEkrani frm = new frmBesinlerEkrani(this.kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmGunlukProgramOluşturmaEkrani frm = new frmGunlukProgramOluşturmaEkrani(this.kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmYemekTarifiEkrani frm = new frmYemekTarifiEkrani(this.kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmIletisimEkrani frm = new frmIletisimEkrani(this.kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
