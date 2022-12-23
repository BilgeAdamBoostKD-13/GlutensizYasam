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
    public partial class frmProfilEkrani : Form
    {
        Kullanici kullanici;
        public frmProfilEkrani()
        {
            InitializeComponent();
        }

        public frmProfilEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
        }

        private void frmProfilEkrani_Load(object sender, EventArgs e)
        {
            txtKilo.Text = this.kullanici.Kilo.ToString();
            txtBoy.Text = this.kullanici.Boy.ToString();
            txtHedefKilo.Text = this.kullanici.HedefKilo.ToString();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
