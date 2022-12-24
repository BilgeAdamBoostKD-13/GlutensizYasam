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
        public frmBesinlerEkrani()
        {
            InitializeComponent();
        }
        public frmBesinlerEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
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
    }
}
