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
        }
    }
}
