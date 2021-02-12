
namespace FinalÖdevi
{
    partial class FrmCalisanEkle
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
            this.comboBoxDepartman = new System.Windows.Forms.ComboBox();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxMaas = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.comboBoxKanGrub = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.richTextBoxAdres = new System.Windows.Forms.RichTextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelGiris = new System.Windows.Forms.Label();
            this.labelMaas = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.labelCinsiyet = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelBolum = new System.Windows.Forms.Label();
            this.labelDepartman = new System.Windows.Forms.Label();
            this.labelKanGrub = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonId = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.maskedTextBoxYeniId = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDepartman
            // 
            this.comboBoxDepartman.FormattingEnabled = true;
            this.comboBoxDepartman.Location = new System.Drawing.Point(791, 155);
            this.comboBoxDepartman.Name = "comboBoxDepartman";
            this.comboBoxDepartman.Size = new System.Drawing.Size(100, 24);
            this.comboBoxDepartman.TabIndex = 59;
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Location = new System.Drawing.Point(383, 158);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(100, 24);
            this.comboBoxBolum.TabIndex = 58;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(383, 266);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(199, 22);
            this.dateTimePickerTarih.TabIndex = 57;
            this.dateTimePickerTarih.Value = new System.DateTime(2020, 12, 28, 0, 0, 0, 0);
            // 
            // maskedTextBoxMaas
            // 
            this.maskedTextBoxMaas.Location = new System.Drawing.Point(791, 261);
            this.maskedTextBoxMaas.Mask = "000000  ₺ (tl)";
            this.maskedTextBoxMaas.Name = "maskedTextBoxMaas";
            this.maskedTextBoxMaas.PromptChar = ' ';
            this.maskedTextBoxMaas.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxMaas.TabIndex = 56;
            this.maskedTextBoxMaas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxMaas_MouseClick);
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "ERKEK (E)",
            "KADIN / KIZ (K)"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(791, 212);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(100, 24);
            this.comboBoxCinsiyet.TabIndex = 55;
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
            this.comboBoxKanGrub.Location = new System.Drawing.Point(791, 100);
            this.comboBoxKanGrub.Name = "comboBoxKanGrub";
            this.comboBoxKanGrub.Size = new System.Drawing.Size(100, 24);
            this.comboBoxKanGrub.TabIndex = 54;
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(383, 215);
            this.maskedTextBoxTel.Mask = "0(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTel.TabIndex = 53;
            // 
            // richTextBoxAdres
            // 
            this.richTextBoxAdres.Location = new System.Drawing.Point(427, 348);
            this.richTextBoxAdres.Name = "richTextBoxAdres";
            this.richTextBoxAdres.Size = new System.Drawing.Size(378, 96);
            this.richTextBoxAdres.TabIndex = 52;
            this.richTextBoxAdres.Text = "";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(360, 348);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(55, 17);
            this.labelAdres.TabIndex = 51;
            this.labelAdres.Text = "ADRES";
            // 
            // labelGiris
            // 
            this.labelGiris.AutoSize = true;
            this.labelGiris.Location = new System.Drawing.Point(237, 266);
            this.labelGiris.Name = "labelGiris";
            this.labelGiris.Size = new System.Drawing.Size(105, 17);
            this.labelGiris.TabIndex = 50;
            this.labelGiris.Text = "İŞ GİRİŞ TARİH";
            // 
            // labelMaas
            // 
            this.labelMaas.AutoSize = true;
            this.labelMaas.Location = new System.Drawing.Point(647, 266);
            this.labelMaas.Name = "labelMaas";
            this.labelMaas.Size = new System.Drawing.Size(46, 17);
            this.labelMaas.TabIndex = 49;
            this.labelMaas.Text = "MAAŞ";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(791, 39);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoyad.TabIndex = 47;
            // 
            // labelCinsiyet
            // 
            this.labelCinsiyet.AutoSize = true;
            this.labelCinsiyet.Location = new System.Drawing.Point(647, 215);
            this.labelCinsiyet.Name = "labelCinsiyet";
            this.labelCinsiyet.Size = new System.Drawing.Size(69, 17);
            this.labelCinsiyet.TabIndex = 46;
            this.labelCinsiyet.Text = "CİNSİYET";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(237, 215);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(97, 17);
            this.labelTel.TabIndex = 45;
            this.labelTel.Text = "İLETİŞİM TEL.";
            // 
            // labelBolum
            // 
            this.labelBolum.AutoSize = true;
            this.labelBolum.Location = new System.Drawing.Point(237, 158);
            this.labelBolum.Name = "labelBolum";
            this.labelBolum.Size = new System.Drawing.Size(57, 17);
            this.labelBolum.TabIndex = 44;
            this.labelBolum.Text = "BOLUM";
            // 
            // labelDepartman
            // 
            this.labelDepartman.AutoSize = true;
            this.labelDepartman.Location = new System.Drawing.Point(647, 158);
            this.labelDepartman.Name = "labelDepartman";
            this.labelDepartman.Size = new System.Drawing.Size(94, 17);
            this.labelDepartman.TabIndex = 43;
            this.labelDepartman.Text = "DEPARTMAN";
            // 
            // labelKanGrub
            // 
            this.labelKanGrub.AutoSize = true;
            this.labelKanGrub.Location = new System.Drawing.Point(647, 103);
            this.labelKanGrub.Name = "labelKanGrub";
            this.labelKanGrub.Size = new System.Drawing.Size(90, 17);
            this.labelKanGrub.TabIndex = 42;
            this.labelKanGrub.Text = "KAN GURUB";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(237, 103);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(26, 17);
            this.labelTc.TabIndex = 41;
            this.labelTc.Text = "TC";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(647, 42);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(56, 17);
            this.labelSoyad.TabIndex = 40;
            this.labelSoyad.Text = "SOYAD";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(237, 42);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(27, 17);
            this.labelAd.TabIndex = 39;
            this.labelAd.Text = "AD";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(383, 42);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxAd.TabIndex = 38;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(472, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 30);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "İPTAL";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 29);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(47, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 254);
            this.panel1.TabIndex = 35;
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
            // buttonId
            // 
            this.buttonId.Location = new System.Drawing.Point(55, 273);
            this.buttonId.Name = "buttonId";
            this.buttonId.Size = new System.Drawing.Size(118, 30);
            this.buttonId.TabIndex = 60;
            this.buttonId.Text = "İD DEĞİŞTİR";
            this.buttonId.UseVisualStyleBackColor = true;
            this.buttonId.Click += new System.EventHandler(this.buttonId_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonOk);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.maskedTextBoxYeniId);
            this.panel3.Location = new System.Drawing.Point(12, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 194);
            this.panel3.TabIndex = 61;
            this.panel3.Visible = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(56, 136);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(116, 38);
            this.buttonOk.TabIndex = 64;
            this.buttonOk.Text = "TAMAM";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 45);
            this.label15.TabIndex = 62;
            this.label15.Text = "YENİ ID ";
            // 
            // maskedTextBoxYeniId
            // 
            this.maskedTextBoxYeniId.Location = new System.Drawing.Point(63, 85);
            this.maskedTextBoxYeniId.Mask = "0000";
            this.maskedTextBoxYeniId.Name = "maskedTextBoxYeniId";
            this.maskedTextBoxYeniId.PromptChar = ' ';
            this.maskedTextBoxYeniId.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxYeniId.TabIndex = 63;
            this.maskedTextBoxYeniId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxYeniId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxYeniId_MouseClick);
            // 
            // maskedTextBoxTc
            // 
            this.maskedTextBoxTc.Location = new System.Drawing.Point(383, 100);
            this.maskedTextBoxTc.Mask = "00000000000";
            this.maskedTextBoxTc.Name = "maskedTextBoxTc";
            this.maskedTextBoxTc.PromptChar = ' ';
            this.maskedTextBoxTc.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTc.TabIndex = 62;
            this.maskedTextBoxTc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxTc_MouseClick);
            // 
            // FrmCalisanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 550);
            this.Controls.Add(this.maskedTextBoxTc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonId);
            this.Controls.Add(this.comboBoxDepartman);
            this.Controls.Add(this.comboBoxBolum);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.maskedTextBoxMaas);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.comboBoxKanGrub);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.richTextBoxAdres);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelGiris);
            this.Controls.Add(this.labelMaas);
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
            this.Name = "FrmCalisanEkle";
            this.Text = "Calışan Ekle";
            this.Load += new System.EventHandler(this.FrmCalisanEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartman;
        private System.Windows.Forms.ComboBox comboBoxBolum;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMaas;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.ComboBox comboBoxKanGrub;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.RichTextBox richTextBoxAdres;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelGiris;
        private System.Windows.Forms.Label labelMaas;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label labelCinsiyet;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelBolum;
        private System.Windows.Forms.Label labelDepartman;
        private System.Windows.Forms.Label labelKanGrub;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonId;
        public System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYeniId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTc;
    }
}