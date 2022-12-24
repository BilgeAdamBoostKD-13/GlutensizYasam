using GlutensizYasam.BLL.Services;
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
    public partial class frmSifremiUnuttumEkrani : Form
    {
        GlutensizYasamDbContext db;
        KullaniciService kullaniciService;
        ParolaService parolaService;
        public frmSifremiUnuttumEkrani()
        {
            InitializeComponent();
            db = new GlutensizYasamDbContext();
            kullaniciService = new KullaniciService();
            parolaService = new ParolaService();
        }

        private void btnParolaGuncelle_Click(object sender, EventArgs e)
        {
            bool checkEmail = kullaniciService.EmailKontrolu(txtMailGiris.Text);
            
              
            if (!checkEmail)
            {
                MessageBox.Show("Bu mail adresi kayıtlı değil");
            }
            else
            {
                int UserId = kullaniciService.KullaniciIdGetir(txtMailGiris.Text);
                bool checkPass = parolaService.Update(new Parola()
                {
                    ID = UserId,
                    UserPassword = txtParola.Text
                });
                MessageBox.Show(checkPass ? "Güncelleme başarılı" : "Güncellenemedi");
            }
        }

        private void frmSifremiUnuttumEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
