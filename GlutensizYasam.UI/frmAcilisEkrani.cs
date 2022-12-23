using GlutensizYasam.BLL.Services;
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
    public partial class frmAcilisEkrani : Form
    {        
        KullaniciService kullaniciService;

        public frmAcilisEkrani()
        {
            InitializeComponent();


        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string userName = txtKullaniciAdi.Text;
            string password = txtSifre.Text;
            try
            {

                kullaniciService = new KullaniciService();
                Kullanici kullanici = kullaniciService.GirisKontrolu(userName, password);
                if (kullanici != null)
                {
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                        
        }

        private void linkHesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmYeniKayitEkrani yeniKayitEkrani = new frmYeniKayitEkrani();            
            this.Hide();
            yeniKayitEkrani.Show();
            this.Show();
        }
        
    }
}
