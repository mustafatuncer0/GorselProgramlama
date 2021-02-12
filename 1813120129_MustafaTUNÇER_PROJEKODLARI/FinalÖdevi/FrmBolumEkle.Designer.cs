
namespace FinalÖdevi
{
    partial class FrmBolumEkle
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
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxYer = new System.Windows.Forms.TextBox();
            this.labelBlmAdı = new System.Windows.Forms.Label();
            this.labelBlmYer = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(105, 74);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxAd.TabIndex = 0;
            // 
            // textBoxYer
            // 
            this.textBoxYer.Location = new System.Drawing.Point(105, 133);
            this.textBoxYer.Name = "textBoxYer";
            this.textBoxYer.Size = new System.Drawing.Size(100, 22);
            this.textBoxYer.TabIndex = 1;
            // 
            // labelBlmAdı
            // 
            this.labelBlmAdı.AutoSize = true;
            this.labelBlmAdı.Location = new System.Drawing.Point(31, 77);
            this.labelBlmAdı.Name = "labelBlmAdı";
            this.labelBlmAdı.Size = new System.Drawing.Size(68, 17);
            this.labelBlmAdı.TabIndex = 2;
            this.labelBlmAdı.Text = "Bölüm Ad";
            // 
            // labelBlmYer
            // 
            this.labelBlmYer.AutoSize = true;
            this.labelBlmYer.Location = new System.Drawing.Point(26, 136);
            this.labelBlmYer.Name = "labelBlmYer";
            this.labelBlmYer.Size = new System.Drawing.Size(73, 17);
            this.labelBlmYer.TabIndex = 3;
            this.labelBlmYer.Text = "Bölüm Yer";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(105, 174);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 29);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmBolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 215);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.labelBlmYer);
            this.Controls.Add(this.labelBlmAdı);
            this.Controls.Add(this.textBoxYer);
            this.Controls.Add(this.textBoxAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmBolumEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBolumEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxYer;
        private System.Windows.Forms.Label labelBlmAdı;
        private System.Windows.Forms.Label labelBlmYer;
        private System.Windows.Forms.Button btnEkle;
    }
}