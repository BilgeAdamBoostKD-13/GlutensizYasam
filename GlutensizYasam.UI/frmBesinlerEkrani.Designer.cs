namespace GlutensizYasam.UI
{
    partial class frmBesinlerEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBesinlerEkrani));
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBesin = new System.Windows.Forms.TextBox();
            this.listBoxBesinler = new System.Windows.Forms.ListBox();
            this.lblBesinAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKalori = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblKarbonhidrat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblYag = new System.Windows.Forms.Label();
            this.lblGlutenVarYok = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(968, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "KAÇ KALORİ?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Orange;
            this.label12.Location = new System.Drawing.Point(81, 81);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 37);
            this.label12.TabIndex = 20;
            this.label12.Text = "Glutensiz";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(213, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Yasam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 31);
            this.label4.TabIndex = 27;
            this.label4.Text = "Besinler kaç kalori?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tükettiğin besinlerin makro besin değerlerini öğren.";
            // 
            // txtBesin
            // 
            this.txtBesin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBesin.Location = new System.Drawing.Point(27, 239);
            this.txtBesin.Name = "txtBesin";
            this.txtBesin.Size = new System.Drawing.Size(467, 29);
            this.txtBesin.TabIndex = 38;
            this.txtBesin.Tag = "Ara";
            this.txtBesin.TextChanged += new System.EventHandler(this.txtBesin_TextChanged);
            // 
            // listBoxBesinler
            // 
            this.listBoxBesinler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxBesinler.FormattingEnabled = true;
            this.listBoxBesinler.ItemHeight = 20;
            this.listBoxBesinler.Location = new System.Drawing.Point(26, 282);
            this.listBoxBesinler.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBesinler.Name = "listBoxBesinler";
            this.listBoxBesinler.Size = new System.Drawing.Size(468, 284);
            this.listBoxBesinler.TabIndex = 40;
            this.listBoxBesinler.SelectedIndexChanged += new System.EventHandler(this.listBoxBesinler_SelectedIndexChanged);
            // 
            // lblBesinAd
            // 
            this.lblBesinAd.AutoSize = true;
            this.lblBesinAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBesinAd.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblBesinAd.Location = new System.Drawing.Point(513, 83);
            this.lblBesinAd.Name = "lblBesinAd";
            this.lblBesinAd.Size = new System.Drawing.Size(150, 31);
            this.lblBesinAd.TabIndex = 41;
            this.lblBesinAd.Text = "@BesinAd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(513, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 42;
            this.label2.Text = "PROTEİN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(513, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 31);
            this.label6.TabIndex = 43;
            this.label6.Text = "KARBONHİDRAT";
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalori.ForeColor = System.Drawing.Color.Red;
            this.lblKalori.Location = new System.Drawing.Point(746, 141);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(117, 31);
            this.lblKalori.TabIndex = 44;
            this.lblKalori.Text = "@Kalori";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProtein.ForeColor = System.Drawing.Color.Red;
            this.lblProtein.Location = new System.Drawing.Point(746, 190);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(135, 31);
            this.lblProtein.TabIndex = 45;
            this.lblProtein.Text = "@Protein";
            // 
            // lblKarbonhidrat
            // 
            this.lblKarbonhidrat.AutoSize = true;
            this.lblKarbonhidrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarbonhidrat.ForeColor = System.Drawing.Color.Red;
            this.lblKarbonhidrat.Location = new System.Drawing.Point(746, 244);
            this.lblKarbonhidrat.Name = "lblKarbonhidrat";
            this.lblKarbonhidrat.Size = new System.Drawing.Size(209, 31);
            this.lblKarbonhidrat.TabIndex = 46;
            this.lblKarbonhidrat.Text = "@Karbonhidrat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(513, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 31);
            this.label10.TabIndex = 47;
            this.label10.Text = "YAĞ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(513, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 31);
            this.label11.TabIndex = 48;
            this.label11.Text = "KALORİ";
            // 
            // lblYag
            // 
            this.lblYag.AutoSize = true;
            this.lblYag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYag.ForeColor = System.Drawing.Color.Red;
            this.lblYag.Location = new System.Drawing.Point(746, 291);
            this.lblYag.Name = "lblYag";
            this.lblYag.Size = new System.Drawing.Size(93, 31);
            this.lblYag.TabIndex = 49;
            this.lblYag.Text = "@Yağ";
            // 
            // lblGlutenVarYok
            // 
            this.lblGlutenVarYok.AutoSize = true;
            this.lblGlutenVarYok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGlutenVarYok.ForeColor = System.Drawing.Color.Red;
            this.lblGlutenVarYok.Location = new System.Drawing.Point(746, 336);
            this.lblGlutenVarYok.Name = "lblGlutenVarYok";
            this.lblGlutenVarYok.Size = new System.Drawing.Size(137, 31);
            this.lblGlutenVarYok.TabIndex = 53;
            this.lblGlutenVarYok.Text = "@VarYok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(513, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 31);
            this.label8.TabIndex = 52;
            this.label8.Text = "Gluten Var Mı?";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(909, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlutensizYasam.UI.Properties.Resources.wheat_allergy_amber_icon_15413;
            this.pictureBox1.Location = new System.Drawing.Point(26, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmBesinlerEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 628);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblGlutenVarYok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblYag);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblKarbonhidrat);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblKalori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBesinAd);
            this.Controls.Add(this.listBoxBesinler);
            this.Controls.Add(this.txtBesin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBesinlerEkrani";
            this.Text = "frmBesinlerEkrani";
            this.Load += new System.EventHandler(this.frmBesinlerEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBesin;
        private System.Windows.Forms.ListBox listBoxBesinler;
        private System.Windows.Forms.Label lblBesinAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblKarbonhidrat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblYag;
        private System.Windows.Forms.Label lblGlutenVarYok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}