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
            //if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Erkek)
            //{
            //    lblBKI.Text = ((10 * this.kullanici.Kilo) + (6.25 * this.kullanici.Boy) - (5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year)) + 5).ToString();
            //}
            //else if (this.kullanici.Cinsiyet == Model.Enums.Cinsiyet.Kadin)
            //{
            //    lblBKI.Text = ((10 * this.kullanici.Kilo) + (6.25) * this.kullanici.Boy - 5 * (DateTime.Now.Year - this.kullanici.DogumTarihi.Year) - 161).ToString();
            //}
            lblBKI.Text = ((this.kullanici.Kilo) / ((this.kullanici.Boy) * (this.kullanici.Boy))).ToString();

            /*
             * Erkekler için: BMR = 10 × ağırlık (kg) + 6,25 × yükseklik (cm) - 5 × yaş (y) + 5

Kadınlar için: BMR = 10 × ağırlık (kg) + 6,25 × yükseklik (cm) - 5 × yaş (y) - 161
             * */

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmAnaEkran frm=new frmAnaEkran(kullanici);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                
    }
}
