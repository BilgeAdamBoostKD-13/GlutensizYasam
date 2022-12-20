namespace GlutensizYasam.UI
{
    partial class frmSuEkrani
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
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarSu = new System.Windows.Forms.ProgressBar();
            this.lblSu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewGunlukSuTuketimi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSuEkle = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1479, 70);
            this.label3.TabIndex = 16;
            this.label3.Text = "SU ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Orange;
            this.label12.Location = new System.Drawing.Point(121, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 57);
            this.label12.TabIndex = 20;
            this.label12.Text = "Glutensiz";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(318, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 57);
            this.label5.TabIndex = 19;
            this.label5.Text = "Yasam";
            // 
            // progressBarSu
            // 
            this.progressBarSu.Location = new System.Drawing.Point(38, 482);
            this.progressBarSu.Maximum = 2500;
            this.progressBarSu.Name = "progressBarSu";
            this.progressBarSu.Size = new System.Drawing.Size(1020, 67);
            this.progressBarSu.Step = 200;
            this.progressBarSu.TabIndex = 23;
            // 
            // lblSu
            // 
            this.lblSu.AutoSize = true;
            this.lblSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSu.ForeColor = System.Drawing.Color.Blue;
            this.lblSu.Location = new System.Drawing.Point(277, 248);
            this.lblSu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(82, 36);
            this.lblSu.TabIndex = 52;
            this.lblSu.Text = "@Su";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(278, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "GÜNLÜK SU İHTİYACI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1103, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 29);
            this.label6.TabIndex = 57;
            this.label6.Text = "Günlük Su Tüketimi";
            // 
            // listViewGunlukSuTuketimi
            // 
            this.listViewGunlukSuTuketimi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewGunlukSuTuketimi.GridLines = true;
            this.listViewGunlukSuTuketimi.HideSelection = false;
            this.listViewGunlukSuTuketimi.Location = new System.Drawing.Point(1108, 134);
            this.listViewGunlukSuTuketimi.Name = "listViewGunlukSuTuketimi";
            this.listViewGunlukSuTuketimi.Size = new System.Drawing.Size(356, 428);
            this.listViewGunlukSuTuketimi.TabIndex = 56;
            this.listViewGunlukSuTuketimi.UseCompatibleStateImageBehavior = false;
            this.listViewGunlukSuTuketimi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TARİH";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SU TÜKETİMİ";
            this.columnHeader2.Width = 150;
            // 
            // btnSuEkle
            // 
            this.btnSuEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSuEkle.ForeColor = System.Drawing.Color.White;
            this.btnSuEkle.Location = new System.Drawing.Point(258, 389);
            this.btnSuEkle.Name = "btnSuEkle";
            this.btnSuEkle.Size = new System.Drawing.Size(800, 87);
            this.btnSuEkle.TabIndex = 0;
            this.btnSuEkle.Text = "1 SU BARDAĞI SU EKLE (200 ML)";
            this.btnSuEkle.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GlutensizYasam.UI.Properties.Resources.su;
            this.pictureBox3.Location = new System.Drawing.Point(38, 187);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 289);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GlutensizYasam.UI.Properties.Resources._3f2ae8fc132bafca49a23144a28dbfcb;
            this.pictureBox2.Location = new System.Drawing.Point(2, 586);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1477, 556);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlutensizYasam.UI.Properties.Resources.wheat_allergy_amber_icon_15413;
            this.pictureBox1.Location = new System.Drawing.Point(38, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmSuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 1017);
            this.Controls.Add(this.btnSuEkle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listViewGunlukSuTuketimi);
            this.Controls.Add(this.lblSu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarSu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSuEkrani";
            this.Text = "frmSuEkrani";
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBarSu;
        private System.Windows.Forms.Label lblSu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewGunlukSuTuketimi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSuEkle;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}