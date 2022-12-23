namespace GlutensizYasam.UI
{
    partial class frmSifremiUnuttumEkrani
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
            this.txtMailGiris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParolaGuncelle = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtParolaYeniden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMailGiris
            // 
            this.txtMailGiris.Location = new System.Drawing.Point(175, 34);
            this.txtMailGiris.Multiline = true;
            this.txtMailGiris.Name = "txtMailGiris";
            this.txtMailGiris.Size = new System.Drawing.Size(237, 24);
            this.txtMailGiris.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Giriniz";
            // 
            // btnParolaGuncelle
            // 
            this.btnParolaGuncelle.Location = new System.Drawing.Point(175, 160);
            this.btnParolaGuncelle.Name = "btnParolaGuncelle";
            this.btnParolaGuncelle.Size = new System.Drawing.Size(237, 27);
            this.btnParolaGuncelle.TabIndex = 2;
            this.btnParolaGuncelle.Text = "Parolayı Güncelle";
            this.btnParolaGuncelle.UseVisualStyleBackColor = true;
            this.btnParolaGuncelle.Click += new System.EventHandler(this.btnParolaGuncelle_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(175, 77);
            this.txtParola.Multiline = true;
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(237, 24);
            this.txtParola.TabIndex = 0;
            // 
            // txtParolaYeniden
            // 
            this.txtParolaYeniden.Location = new System.Drawing.Point(175, 116);
            this.txtParolaYeniden.Multiline = true;
            this.txtParolaYeniden.Name = "txtParolaYeniden";
            this.txtParolaYeniden.Size = new System.Drawing.Size(237, 24);
            this.txtParolaYeniden.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Şifrenizi Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yeni Şifrenizi Tekrar Giriniz";
            // 
            // frmSifremiUnuttumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 227);
            this.Controls.Add(this.btnParolaGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParolaYeniden);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtMailGiris);
            this.Name = "frmSifremiUnuttumEkrani";
            this.Text = "frmSifremiUnuttumEkrani";
            this.Load += new System.EventHandler(this.frmSifremiUnuttumEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMailGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParolaGuncelle;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtParolaYeniden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}