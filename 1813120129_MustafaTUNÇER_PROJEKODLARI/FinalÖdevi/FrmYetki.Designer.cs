
namespace FinalÖdevi
{
    partial class FrmYetki
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
            this.comboBoxSorumlu = new System.Windows.Forms.ComboBox();
            this.textBoxKAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.labelKisi = new System.Windows.Forms.Label();
            this.labelKAdi = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.comboBoxYetki = new System.Windows.Forms.ComboBox();
            this.labelYeki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSorumlu
            // 
            this.comboBoxSorumlu.FormattingEnabled = true;
            this.comboBoxSorumlu.Location = new System.Drawing.Point(104, 49);
            this.comboBoxSorumlu.Name = "comboBoxSorumlu";
            this.comboBoxSorumlu.Size = new System.Drawing.Size(100, 24);
            this.comboBoxSorumlu.TabIndex = 92;
            // 
            // textBoxKAdi
            // 
            this.textBoxKAdi.Location = new System.Drawing.Point(104, 107);
            this.textBoxKAdi.Name = "textBoxKAdi";
            this.textBoxKAdi.Size = new System.Drawing.Size(100, 22);
            this.textBoxKAdi.TabIndex = 93;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(104, 153);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(100, 22);
            this.textBoxSifre.TabIndex = 94;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(104, 250);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 36);
            this.btnEkle.TabIndex = 95;
            this.btnEkle.Text = "Yetki Ver";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // labelKisi
            // 
            this.labelKisi.AutoSize = true;
            this.labelKisi.Location = new System.Drawing.Point(33, 52);
            this.labelKisi.Name = "labelKisi";
            this.labelKisi.Size = new System.Drawing.Size(30, 17);
            this.labelKisi.TabIndex = 96;
            this.labelKisi.Text = "Kişi";
            // 
            // labelKAdi
            // 
            this.labelKAdi.AutoSize = true;
            this.labelKAdi.Location = new System.Drawing.Point(12, 110);
            this.labelKAdi.Name = "labelKAdi";
            this.labelKAdi.Size = new System.Drawing.Size(84, 17);
            this.labelKAdi.TabIndex = 97;
            this.labelKAdi.Text = "Kullanıcı Adı";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(33, 156);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(37, 17);
            this.labelSifre.TabIndex = 98;
            this.labelSifre.Text = "Şifre";
            // 
            // comboBoxYetki
            // 
            this.comboBoxYetki.FormattingEnabled = true;
            this.comboBoxYetki.Location = new System.Drawing.Point(104, 203);
            this.comboBoxYetki.Name = "comboBoxYetki";
            this.comboBoxYetki.Size = new System.Drawing.Size(100, 24);
            this.comboBoxYetki.TabIndex = 99;
            // 
            // labelYeki
            // 
            this.labelYeki.AutoSize = true;
            this.labelYeki.Location = new System.Drawing.Point(24, 206);
            this.labelYeki.Name = "labelYeki";
            this.labelYeki.Size = new System.Drawing.Size(39, 17);
            this.labelYeki.TabIndex = 100;
            this.labelYeki.Text = "Yetki";
            // 
            // FrmYetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 298);
            this.Controls.Add(this.labelYeki);
            this.Controls.Add(this.comboBoxYetki);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKAdi);
            this.Controls.Add(this.labelKisi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKAdi);
            this.Controls.Add(this.comboBoxSorumlu);
            this.Name = "FrmYetki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYetki";
            this.Load += new System.EventHandler(this.FrmYetki_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSorumlu;
        private System.Windows.Forms.TextBox textBoxKAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label labelKisi;
        private System.Windows.Forms.Label labelKAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.ComboBox comboBoxYetki;
        private System.Windows.Forms.Label labelYeki;
    }
}