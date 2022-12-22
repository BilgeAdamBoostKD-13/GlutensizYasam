namespace GlutensizYasam.UI
{
    partial class frmMDIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.profiliGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oturumuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tariflerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haftalıkProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekTarifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem1,
            this.tariflerToolStripMenuItem,
            this.ekleToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1476, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilToolStripMenuItem1
            // 
            this.profilToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profiliGörüntüleToolStripMenuItem,
            this.suToolStripMenuItem,
            this.oturumuKapatToolStripMenuItem});
            this.profilToolStripMenuItem1.Name = "profilToolStripMenuItem1";
            this.profilToolStripMenuItem1.Size = new System.Drawing.Size(69, 29);
            this.profilToolStripMenuItem1.Text = "Profil";
            // 
            // profiliGörüntüleToolStripMenuItem
            // 
            this.profiliGörüntüleToolStripMenuItem.Name = "profiliGörüntüleToolStripMenuItem";
            this.profiliGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.profiliGörüntüleToolStripMenuItem.Text = "Profili Görüntüle";
            // 
            // suToolStripMenuItem
            // 
            this.suToolStripMenuItem.Name = "suToolStripMenuItem";
            this.suToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.suToolStripMenuItem.Text = "Su ";
            // 
            // oturumuKapatToolStripMenuItem
            // 
            this.oturumuKapatToolStripMenuItem.Name = "oturumuKapatToolStripMenuItem";
            this.oturumuKapatToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.oturumuKapatToolStripMenuItem.Text = "Oturumu Kapat";
            // 
            // tariflerToolStripMenuItem
            // 
            this.tariflerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem});
            this.tariflerToolStripMenuItem.Name = "tariflerToolStripMenuItem";
            this.tariflerToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.tariflerToolStripMenuItem.Text = "Besinler";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ürünlerToolStripMenuItem.Text = "Kaç Kalori?";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haftalıkProgramToolStripMenuItem,
            this.yemekTarifiToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // haftalıkProgramToolStripMenuItem
            // 
            this.haftalıkProgramToolStripMenuItem.Name = "haftalıkProgramToolStripMenuItem";
            this.haftalıkProgramToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.haftalıkProgramToolStripMenuItem.Text = "Haftalık Program";
            // 
            // yemekTarifiToolStripMenuItem
            // 
            this.yemekTarifiToolStripMenuItem.Name = "yemekTarifiToolStripMenuItem";
            this.yemekTarifiToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.yemekTarifiToolStripMenuItem.Text = "Yemek Tarifi";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.çıkışToolStripMenuItem.Text = "Uygulamadan Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // frmMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1017);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMDIForm";
            this.Text = "frmMDIForm";
            this.Load += new System.EventHandler(this.frmMDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haftalıkProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekTarifiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tariflerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oturumuKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profiliGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suToolStripMenuItem;
    }
}