
namespace FinalÖdevi
{
    partial class FrmAracDurum
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
            this.checkBoxEksik = new System.Windows.Forms.CheckBox();
            this.checkBoxTam = new System.Windows.Forms.CheckBox();
            this.checkBoxYok = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxEksik
            // 
            this.checkBoxEksik.AutoSize = true;
            this.checkBoxEksik.Location = new System.Drawing.Point(195, 72);
            this.checkBoxEksik.Name = "checkBoxEksik";
            this.checkBoxEksik.Size = new System.Drawing.Size(69, 21);
            this.checkBoxEksik.TabIndex = 0;
            this.checkBoxEksik.Text = "EKSİK";
            this.checkBoxEksik.UseVisualStyleBackColor = true;
            this.checkBoxEksik.CheckedChanged += new System.EventHandler(this.checkBoxEksik_CheckedChanged);
            // 
            // checkBoxTam
            // 
            this.checkBoxTam.AutoSize = true;
            this.checkBoxTam.Location = new System.Drawing.Point(195, 99);
            this.checkBoxTam.Name = "checkBoxTam";
            this.checkBoxTam.Size = new System.Drawing.Size(59, 21);
            this.checkBoxTam.TabIndex = 1;
            this.checkBoxTam.Text = "TAM";
            this.checkBoxTam.UseVisualStyleBackColor = true;
            this.checkBoxTam.CheckedChanged += new System.EventHandler(this.checkBoxTam_CheckedChanged);
            // 
            // checkBoxYok
            // 
            this.checkBoxYok.AutoSize = true;
            this.checkBoxYok.Location = new System.Drawing.Point(195, 126);
            this.checkBoxYok.Name = "checkBoxYok";
            this.checkBoxYok.Size = new System.Drawing.Size(59, 21);
            this.checkBoxYok.TabIndex = 2;
            this.checkBoxYok.Text = "YOK";
            this.checkBoxYok.UseVisualStyleBackColor = true;
            this.checkBoxYok.CheckedChanged += new System.EventHandler(this.checkBoxYok_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::FinalÖdevi.Properties.Resources.name_tag_60px1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 159);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Location = new System.Drawing.Point(17, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 44);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelId.Location = new System.Drawing.Point(74, 10);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(22, 23);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "0";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(209, 202);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(84, 35);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Tamam";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FrmAracDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 259);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxYok);
            this.Controls.Add(this.checkBoxTam);
            this.Controls.Add(this.checkBoxEksik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmAracDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Durum";
            this.Load += new System.EventHandler(this.FrmAracDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEksik;
        private System.Windows.Forms.CheckBox checkBoxTam;
        private System.Windows.Forms.CheckBox checkBoxYok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonOk;
    }
}