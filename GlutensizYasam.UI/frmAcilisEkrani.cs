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
                if (kullanici != null && kullanici.KullaniciTipi == Model.Enums.KullaniciTipi.Admin)
                {
                    frmAdminEkrani frm = new frmAdminEkrani();
                    this.Hide();
                    frm.ShowDialog();                   
                        
                }
                else if (kullanici != null && kullanici.KullaniciTipi == Model.Enums.KullaniciTipi.Standart)
                {
                    frmAnaEkran frm = new frmAnaEkran(kullanici);
                    this.Hide();
                    frm.ShowDialog();

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
            yeniKayitEkrani.ShowDialog();
            
        }
        
    }
}
