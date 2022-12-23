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
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        public frmAnaEkran(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmProfilEkrani frm = new frmProfilEkrani(this.kullanici);
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
            frmHaftalikProgramOluşturmaEkrani frm = new frmHaftalikProgramOluşturmaEkrani(this.kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmYemekTarifiOlusturmaEkrani frm = new frmYemekTarifiOlusturmaEkrani(this.kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmIletisimEkrani frm = new frmIletisimEkrani(this.kullanici);
            this.Close();
            frm.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
