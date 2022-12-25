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
    public partial class frmIletisimEkrani : Form
    {
        Kullanici kullanici;
        frmAnaEkran frm;
        public frmIletisimEkrani()
        {
            InitializeComponent();
        }
        public frmIletisimEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;

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

        private void frmIletisimEkrani_Load(object sender, EventArgs e)
        {
            txtIsım.Enabled = false;
            txtEmail.Enabled = false;

            txtIsım.Text = $"{this.kullanici.Isim} {this.kullanici.SoyIsim}";
            txtEmail.Text = this.kullanici.EMail.ToString();

            
            
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBoxMesaj.Text))
            {
                MessageBox.Show("Mesajınız boş olamaz");
            }
            else
            {
                MessageBox.Show("Mesajınız başarıyla iletilmiştir.");
                frm = new frmAnaEkran(this.kullanici);
                this.Hide();
                frm.ShowDialog();

            }
        }
    }
}
