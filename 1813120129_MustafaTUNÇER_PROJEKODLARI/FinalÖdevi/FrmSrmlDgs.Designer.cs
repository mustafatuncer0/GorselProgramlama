
namespace FinalÖdevi
{
    partial class FrmSrmlDgs
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
            this.labelSorumlu = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.comboBoxSorumlu = new System.Windows.Forms.ComboBox();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSorumlu
            // 
            this.labelSorumlu.AutoSize = true;
            this.labelSorumlu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSorumlu.Location = new System.Drawing.Point(12, 117);
            this.labelSorumlu.Name = "labelSorumlu";
            this.labelSorumlu.Size = new System.Drawing.Size(131, 22);
            this.labelSorumlu.TabIndex = 0;
            this.labelSorumlu.Text = "Sorumlu Kişi : ";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOk.Location = new System.Drawing.Point(99, 209);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 36);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "TAMAM";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // comboBoxSorumlu
            // 
            this.comboBoxSorumlu.FormattingEnabled = true;
            this.comboBoxSorumlu.Location = new System.Drawing.Point(139, 117);
            this.comboBoxSorumlu.Name = "comboBoxSorumlu";
            this.comboBoxSorumlu.Size = new System.Drawing.Size(167, 24);
            this.comboBoxSorumlu.TabIndex = 2;
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Location = new System.Drawing.Point(63, 9);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(188, 17);
            this.labelBaslik.TabIndex = 3;
            this.labelBaslik.Text = "SORUMLU KİŞİ DEĞİŞTİRİCİ";
            // 
            // FrmSrmlDgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 257);
            this.Controls.Add(this.labelBaslik);
            this.Controls.Add(this.comboBoxSorumlu);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelSorumlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSrmlDgs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SORUMLU DEĞİŞTİR";
            this.Load += new System.EventHandler(this.FrmSrmlDgs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSorumlu;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox comboBoxSorumlu;
        private System.Windows.Forms.Label labelBaslik;
    }
}