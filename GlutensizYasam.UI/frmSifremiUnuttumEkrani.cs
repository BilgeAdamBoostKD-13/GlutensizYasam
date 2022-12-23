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
        public frmSifremiUnuttumEkrani()
        {
            InitializeComponent();
            db = new GlutensizYasamDbContext();
        }

        private void btnParolaGuncelle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            //if (kullanici.EMail == )
            {

            }
        }

        public List<Kullanici> kullanilanEmail = db.Kullanicilar.ToList();
    }
}
