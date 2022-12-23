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
    public partial class frmMDIForm : Form
    {
        public frmMDIForm()
        {
            InitializeComponent();
        }

        private void frmMDIForm_Load(object sender, EventArgs e)
        {
           
            ChildForm(new frmAcilisEkrani());
            //diyetListemToolStripMenuItem.Enabled = false;
            //ürünlerToolStripMenuItem.Enabled = false;
            //profiliGörüntüleToolStripMenuItem.Enabled = false;
            //suToolStripMenuItem.Enabled = false;
            //haftalıkProgramToolStripMenuItem.Enabled = false;
            //yemekTarifiToolStripMenuItem.Enabled = false;
            //diyetListemToolStripMenuItem.Enabled = false;

        }

        void ChildForm(Form childForm)//form tipinde bir child form alacak,herhangi bir formu alabalir
        {
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == childForm.Name)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                Width = childForm.Width + 30;
                Height = childForm.Height + 70;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();




            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı Kapatmak İstediğinize Emin Misiniz ?","Uygulamadan Çıkış",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
                       
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new frmBesinlerEkrani());
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new frmIletisimEkrani());
        }

        private void profiliGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new frmProfilEkrani());
        }

        private void suToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new frmSuEkrani());
        }

        private void haftalıkProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new frmHaftalikProgramOluşturmaEkrani());
        }

        private void yemekTarifiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new frmYemekTarifiOlusturmaEkrani());
        }

        private void diyetListemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new frmDiyetListemPaneli());
        }
    }
}
