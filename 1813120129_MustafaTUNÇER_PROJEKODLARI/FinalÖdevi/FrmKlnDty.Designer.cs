
namespace FinalÖdevi
{
    partial class FrmKlnDty
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.labelKanGrub = new System.Windows.Forms.Label();
            this.labelDepartman = new System.Windows.Forms.Label();
            this.labelBolum = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxTc = new System.Windows.Forms.TextBox();
            this.labelMaas = new System.Windows.Forms.Label();
            this.labelGirs = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.richTextBoxAdres = new System.Windows.Forms.RichTextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxKanGrub = new System.Windows.Forms.ComboBox();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxMaas = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartman = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::FinalÖdevi.Properties.Resources.name_tag_60px1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 159);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(60, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 254);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Location = new System.Drawing.Point(8, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 44);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(376, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(485, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "İPTAL";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(396, 89);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxAd.TabIndex = 6;
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(250, 89);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(27, 17);
            this.labelAd.TabIndex = 7;
            this.labelAd.Text = "AD";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(660, 89);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(56, 17);
            this.labelSoyad.TabIndex = 8;
            this.labelSoyad.Text = "SOYAD";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(250, 150);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(26, 17);
            this.labelTc.TabIndex = 9;
            this.labelTc.Text = "TC";
            // 
            // labelKanGrub
            // 
            this.labelKanGrub.AutoSize = true;
            this.labelKanGrub.Location = new System.Drawing.Point(660, 150);
            this.labelKanGrub.Name = "labelKanGrub";
            this.labelKanGrub.Size = new System.Drawing.Size(90, 17);
            this.labelKanGrub.TabIndex = 10;
            this.labelKanGrub.Text = "KAN GURUB";
            // 
            // labelDepartman
            // 
            this.labelDepartman.AutoSize = true;
            this.labelDepartman.Location = new System.Drawing.Point(660, 205);
            this.labelDepartman.Name = "labelDepartman";
            this.labelDepartman.Size = new System.Drawing.Size(94, 17);
            this.labelDepartman.TabIndex = 11;
            this.labelDepartman.Text = "DEPARTMAN";
            // 
            // labelBolum
            // 
            this.labelBolum.AutoSize = true;
            this.labelBolum.Location = new System.Drawing.Point(250, 205);
            this.labelBolum.Name = "labelBolum";
            this.labelBolum.Size = new System.Drawing.Size(57, 17);
            this.labelBolum.TabIndex = 12;
            this.labelBolum.Text = "BOLUM";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(250, 262);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(97, 17);
            this.labelTel.TabIndex = 13;
            this.labelTel.Text = "İLETİŞİM TEL.";
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Location = new System.Drawing.Point(660, 262);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(69, 17);
            this.labelCinsiyet.TabIndex = 14;
            this.labelCinsiyet.Text = "CİNSİYET";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(804, 86);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoyad.TabIndex = 15;
            // 
            // textBoxTc
            // 
            this.textBoxTc.Location = new System.Drawing.Point(396, 150);
            this.textBoxTc.Name = "textBoxTc";
            this.textBoxTc.Size = new System.Drawing.Size(100, 22);
            this.textBoxTc.TabIndex = 16;
            // 
            // labelMaas
            // 
            this.labelMaas.AutoSize = true;
            this.labelMaas.Location = new System.Drawing.Point(660, 313);
            this.labelMaas.Name = "labelMaas";
            this.labelMaas.Size = new System.Drawing.Size(46, 17);
            this.labelMaas.TabIndex = 24;
            this.labelMaas.Text = "MAAŞ";
            // 
            // labelGirs
            // 
            this.labelGirs.AutoSize = true;
            this.labelGirs.Location = new System.Drawing.Point(250, 313);
            this.labelGirs.Name = "labelGirs";
            this.labelGirs.Size = new System.Drawing.Size(105, 17);
            this.labelGirs.TabIndex = 25;
            this.labelGirs.Text = "İŞ GİRİŞ TARİH";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(373, 395);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(55, 17);
            this.labelAdres.TabIndex = 26;
            this.labelAdres.Text = "ADRES";
            // 
            // richTextBoxAdres
            // 
            this.richTextBoxAdres.Location = new System.Drawing.Point(440, 395);
            this.richTextBoxAdres.Name = "richTextBoxAdres";
            this.richTextBoxAdres.Size = new System.Drawing.Size(378, 96);
            this.richTextBoxAdres.TabIndex = 27;
            this.richTextBoxAdres.Text = "";
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(396, 262);
            this.maskedTextBoxTel.Mask = "0(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTel.TabIndex = 28;
            // 
            // comboBoxKanGrub
            // 
            this.comboBoxKanGrub.FormattingEnabled = true;
            this.comboBoxKanGrub.Items.AddRange(new object[] {
            "A RH(+)",
            "0 RH(+)",
            "B RH(+)",
            "AB RH(+)",
            "A RH(-)",
            "0 RH(-)",
            "B RH(-)",
            "AB RH(-)"});
            this.comboBoxKanGrub.Location = new System.Drawing.Point(804, 147);
            this.comboBoxKanGrub.Name = "comboBoxKanGrub";
            this.comboBoxKanGrub.Size = new System.Drawing.Size(100, 24);
            this.comboBoxKanGrub.TabIndex = 29;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "ERKEK (E)",
            "KADIN / KIZ (K)"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(804, 259);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(100, 24);
            this.comboBoxCinsiyet.TabIndex = 30;
            // 
            // maskedTextBoxMaas
            // 
            this.maskedTextBoxMaas.Location = new System.Drawing.Point(804, 308);
            this.maskedTextBoxMaas.Mask = "000000  ₺ (tl)";
            this.maskedTextBoxMaas.Name = "maskedTextBoxMaas";
            this.maskedTextBoxMaas.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxMaas.TabIndex = 31;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(396, 313);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(199, 22);
            this.dateTimePickerTarih.TabIndex = 32;
            this.dateTimePickerTarih.Value = new System.DateTime(2020, 12, 28, 0, 0, 0, 0);
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Location = new System.Drawing.Point(396, 205);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(100, 24);
            this.comboBoxBolum.TabIndex = 33;
            // 
            // comboBoxDepartman
            // 
            this.comboBoxDepartman.FormattingEnabled = true;
            this.comboBoxDepartman.Location = new System.Drawing.Point(804, 202);
            this.comboBoxDepartman.Name = "comboBoxDepartman";
            this.comboBoxDepartman.Size = new System.Drawing.Size(100, 24);
            this.comboBoxDepartman.TabIndex = 34;
            // 
            // FrmKlnDty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(957, 597);
            this.Controls.Add(this.comboBoxDepartman);
            this.Controls.Add(this.comboBoxBolum);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.maskedTextBoxMaas);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.comboBoxKanGrub);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.richTextBoxAdres);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelGirs);
            this.Controls.Add(this.labelMaas);
            this.Controls.Add(this.textBoxTc);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.labelCinsiyet);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelBolum);
            this.Controls.Add(this.labelDepartman);
            this.Controls.Add(this.labelKanGrub);
            this.Controls.Add(this.labelTc);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKlnDty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKlnDty";
            this.Load += new System.EventHandler(this.FrmKlnDty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label labelKanGrub;
        private System.Windows.Forms.Label labelDepartman;
        private System.Windows.Forms.Label labelBolum;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxTc;
        private System.Windows.Forms.Label labelMaas;
        private System.Windows.Forms.Label labelGirs;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.RichTextBox richTextBoxAdres;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.ComboBox comboBoxKanGrub;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMaas;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.ComboBox comboBoxDepartman;
    }
}