
namespace FinalÖdevi
{
    partial class FrmAnlasmaEkle
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
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxMaas = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.richtextBoxAdres = new System.Windows.Forms.RichTextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelTarih = new System.Windows.Forms.Label();
            this.textBoxIl = new System.Windows.Forms.TextBox();
            this.textBoxFirmaAdi = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richtextBoxYemekList = new System.Windows.Forms.RichTextBox();
            this.labeYemekList = new System.Windows.Forms.Label();
            this.textBoxIlce = new System.Windows.Forms.TextBox();
            this.labelIlce = new System.Windows.Forms.Label();
            this.labelFirmaAdi = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelIl = new System.Windows.Forms.Label();
            this.maskedTextBoxFiyat = new System.Windows.Forms.MaskedTextBox();
            this.labeMiktar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(401, 163);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(199, 22);
            this.dateTimePickerTarih.TabIndex = 84;
            this.dateTimePickerTarih.Value = new System.DateTime(2020, 12, 28, 0, 0, 0, 0);
            // 
            // maskedTextBoxMaas
            // 
            this.maskedTextBoxMaas.Location = new System.Drawing.Point(809, 160);
            this.maskedTextBoxMaas.Mask = "000000  ₺ (tl)";
            this.maskedTextBoxMaas.Name = "maskedTextBoxMaas";
            this.maskedTextBoxMaas.PromptChar = ' ';
            this.maskedTextBoxMaas.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxMaas.TabIndex = 83;
            this.maskedTextBoxMaas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxMaas_MouseClick);
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(809, 100);
            this.maskedTextBoxTel.Mask = "0(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTel.TabIndex = 80;
            // 
            // richtextBoxAdres
            // 
            this.richtextBoxAdres.Location = new System.Drawing.Point(448, 393);
            this.richtextBoxAdres.Name = "richtextBoxAdres";
            this.richtextBoxAdres.Size = new System.Drawing.Size(378, 96);
            this.richtextBoxAdres.TabIndex = 79;
            this.richtextBoxAdres.Text = "";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(381, 393);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(55, 17);
            this.labelAdres.TabIndex = 78;
            this.labelAdres.Text = "ADRES";
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Location = new System.Drawing.Point(255, 163);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(49, 17);
            this.labelTarih.TabIndex = 77;
            this.labelTarih.Text = "TARİH";
            // 
            // textBoxIl
            // 
            this.textBoxIl.Location = new System.Drawing.Point(809, 39);
            this.textBoxIl.Name = "textBoxIl";
            this.textBoxIl.Size = new System.Drawing.Size(100, 22);
            this.textBoxIl.TabIndex = 75;
            // 
            // textBoxFirmaAdi
            // 
            this.textBoxFirmaAdi.Location = new System.Drawing.Point(401, 42);
            this.textBoxFirmaAdi.Name = "textBoxFirmaAdi";
            this.textBoxFirmaAdi.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirmaAdi.TabIndex = 66;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(490, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 30);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "İPTAL";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(381, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 29);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(65, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 254);
            this.panel1.TabIndex = 63;
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
            // richtextBoxYemekList
            // 
            this.richtextBoxYemekList.Location = new System.Drawing.Point(448, 267);
            this.richtextBoxYemekList.Name = "richtextBoxYemekList";
            this.richtextBoxYemekList.Size = new System.Drawing.Size(378, 96);
            this.richtextBoxYemekList.TabIndex = 91;
            this.richtextBoxYemekList.Text = "";
            // 
            // labeYemekList
            // 
            this.labeYemekList.AutoSize = true;
            this.labeYemekList.Location = new System.Drawing.Point(327, 267);
            this.labeYemekList.Name = "labeYemekList";
            this.labeYemekList.Size = new System.Drawing.Size(109, 17);
            this.labeYemekList.TabIndex = 90;
            this.labeYemekList.Text = "YEMEK LİSTESİ";
            // 
            // textBoxIlce
            // 
            this.textBoxIlce.Location = new System.Drawing.Point(401, 100);
            this.textBoxIlce.Name = "textBoxIlce";
            this.textBoxIlce.Size = new System.Drawing.Size(100, 22);
            this.textBoxIlce.TabIndex = 66;
            // 
            // labelIlce
            // 
            this.labelIlce.AutoSize = true;
            this.labelIlce.Location = new System.Drawing.Point(255, 103);
            this.labelIlce.Name = "labelIlce";
            this.labelIlce.Size = new System.Drawing.Size(129, 17);
            this.labelIlce.TabIndex = 93;
            this.labelIlce.Text = "BULUNDUĞU İLÇE";
            // 
            // labelFirmaAdi
            // 
            this.labelFirmaAdi.AutoSize = true;
            this.labelFirmaAdi.Location = new System.Drawing.Point(255, 42);
            this.labelFirmaAdi.Name = "labelFirmaAdi";
            this.labelFirmaAdi.Size = new System.Drawing.Size(75, 17);
            this.labelFirmaAdi.TabIndex = 92;
            this.labelFirmaAdi.Text = "FİRMA ADI";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Location = new System.Drawing.Point(649, 163);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(46, 17);
            this.labelFiyat.TabIndex = 96;
            this.labelFiyat.Text = "FİYAT";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(649, 103);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(97, 17);
            this.labelTel.TabIndex = 95;
            this.labelTel.Text = "İLETİŞİM TEL.";
            // 
            // labelIl
            // 
            this.labelIl.AutoSize = true;
            this.labelIl.Location = new System.Drawing.Point(649, 42);
            this.labelIl.Name = "labelIl";
            this.labelIl.Size = new System.Drawing.Size(111, 17);
            this.labelIl.TabIndex = 94;
            this.labelIl.Text = "BULUNDUĞU İL";
            // 
            // maskedTextBoxFiyat
            // 
            this.maskedTextBoxFiyat.Location = new System.Drawing.Point(609, 223);
            this.maskedTextBoxFiyat.Mask = "999999 Kişilik";
            this.maskedTextBoxFiyat.Name = "maskedTextBoxFiyat";
            this.maskedTextBoxFiyat.PromptChar = ' ';
            this.maskedTextBoxFiyat.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxFiyat.TabIndex = 98;
            this.maskedTextBoxFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxFiyat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxFiyat_MouseClick);
            // 
            // labeMiktar
            // 
            this.labeMiktar.AutoSize = true;
            this.labeMiktar.Location = new System.Drawing.Point(544, 226);
            this.labeMiktar.Name = "labeMiktar";
            this.labeMiktar.Size = new System.Drawing.Size(59, 17);
            this.labeMiktar.TabIndex = 97;
            this.labeMiktar.Text = "MİKTAR";
            // 
            // FrmAnlasmaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 550);
            this.Controls.Add(this.maskedTextBoxFiyat);
            this.Controls.Add(this.labeMiktar);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelIl);
            this.Controls.Add(this.labelIlce);
            this.Controls.Add(this.labelFirmaAdi);
            this.Controls.Add(this.richtextBoxYemekList);
            this.Controls.Add(this.labeYemekList);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.maskedTextBoxMaas);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.richtextBoxAdres);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.textBoxIl);
            this.Controls.Add(this.textBoxIlce);
            this.Controls.Add(this.textBoxFirmaAdi);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmAnlasmaEkle";
            this.Text = "Anlaşma Ekle";
            this.Load += new System.EventHandler(this.FrmAnlasmaEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMaas;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.RichTextBox richtextBoxAdres;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.TextBox textBoxIl;
        private System.Windows.Forms.TextBox textBoxFirmaAdi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richtextBoxYemekList;
        private System.Windows.Forms.Label labeYemekList;
        private System.Windows.Forms.TextBox textBoxIlce;
        private System.Windows.Forms.Label labelIlce;
        private System.Windows.Forms.Label labelFirmaAdi;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelIl;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFiyat;
        private System.Windows.Forms.Label labeMiktar;
    }
}