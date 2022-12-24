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
        public frmGunlukProgramOluşturmaEkrani()
        {
            InitializeComponent();
        }
        public frmGunlukProgramOluşturmaEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
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

        }
    }
}
