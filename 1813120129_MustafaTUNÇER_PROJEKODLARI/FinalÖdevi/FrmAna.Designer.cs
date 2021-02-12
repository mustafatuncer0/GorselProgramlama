
namespace FinalÖdevi
{
    partial class FrmAna
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btncikis = new System.Windows.Forms.Button();
            this.btnalt = new System.Windows.Forms.Button();
            this.flowLayoutpanelCalisan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnlasma = new System.Windows.Forms.Button();
            this.btnYemek = new System.Windows.Forms.Button();
            this.btnArac = new System.Windows.Forms.Button();
            this.btnGiris_Cikis = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.flowLayoutpanelAnlasmalar = new System.Windows.Forms.FlowLayoutPanel();
            this.textVersion = new System.Windows.Forms.TextBox();
            this.labelGirisAd = new System.Windows.Forms.Label();
            this.labelGirisSoyad = new System.Windows.Forms.Label();
            this.dataGridViewCalisanlar = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCalisan = new System.Windows.Forms.Panel();
            this.panelAnlasmalar = new System.Windows.Forms.Panel();
            this.btnYenile2 = new System.Windows.Forms.Button();
            this.btnAnlasmaSil = new System.Windows.Forms.Button();
            this.btnAnlasmaEkle = new System.Windows.Forms.Button();
            this.dataGridViewAnlasmalar = new System.Windows.Forms.DataGridView();
            this.panelYemekDurumu = new System.Windows.Forms.Panel();
            this.btnYemekEkle = new System.Windows.Forms.Button();
            this.btnSorumluDegistir = new System.Windows.Forms.Button();
            this.dataGridViewYemek = new System.Windows.Forms.DataGridView();
            this.panelGiris = new System.Windows.Forms.Panel();
            this.btnIslem = new System.Windows.Forms.Button();
            this.dataGridViewGiris = new System.Windows.Forms.DataGridView();
            this.panelArac = new System.Windows.Forms.Panel();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.dataGridViewArac = new System.Windows.Forms.DataGridView();
            this.btnYetki = new System.Windows.Forms.Button();
            this.pictureGirisFemale = new System.Windows.Forms.PictureBox();
            this.pictureGirisMale = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalisanlar = new System.Windows.Forms.Button();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.btnDepartmanEkle = new System.Windows.Forms.Button();
            this.flowLayoutpanelCalisan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalisanlar)).BeginInit();
            this.panelCalisan.SuspendLayout();
            this.panelAnlasmalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnlasmalar)).BeginInit();
            this.panelYemekDurumu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYemek)).BeginInit();
            this.panelGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiris)).BeginInit();
            this.panelArac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGirisFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGirisMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btncikis
            // 
            this.btncikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis.FlatAppearance.BorderSize = 0;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncikis.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.White;
            this.btncikis.Location = new System.Drawing.Point(987, 12);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(38, 38);
            this.btncikis.TabIndex = 1;
            this.btncikis.Text = "X";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            this.btncikis.MouseEnter += new System.EventHandler(this.btncikis_MouseEnter);
            this.btncikis.MouseLeave += new System.EventHandler(this.btncikis_MouseLeave);
            // 
            // btnalt
            // 
            this.btnalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnalt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalt.FlatAppearance.BorderSize = 0;
            this.btnalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalt.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnalt.ForeColor = System.Drawing.Color.White;
            this.btnalt.Location = new System.Drawing.Point(950, 0);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(31, 44);
            this.btnalt.TabIndex = 2;
            this.btnalt.Text = "-";
            this.btnalt.UseVisualStyleBackColor = true;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click);
            this.btnalt.MouseEnter += new System.EventHandler(this.btnalt_MouseEnter);
            this.btnalt.MouseLeave += new System.EventHandler(this.btnalt_MouseLeave);
            // 
            // flowLayoutpanelCalisan
            // 
            this.flowLayoutpanelCalisan.Controls.Add(this.btnCalisanlar);
            this.flowLayoutpanelCalisan.Controls.Add(this.btnAnlasma);
            this.flowLayoutpanelCalisan.Controls.Add(this.btnYemek);
            this.flowLayoutpanelCalisan.Controls.Add(this.btnArac);
            this.flowLayoutpanelCalisan.Controls.Add(this.btnGiris_Cikis);
            this.flowLayoutpanelCalisan.Controls.Add(this.buttonCikis);
            this.flowLayoutpanelCalisan.Location = new System.Drawing.Point(12, 199);
            this.flowLayoutpanelCalisan.Name = "flowLayoutpanelCalisan";
            this.flowLayoutpanelCalisan.Size = new System.Drawing.Size(189, 416);
            this.flowLayoutpanelCalisan.TabIndex = 3;
            // 
            // btnAnlasma
            // 
            this.btnAnlasma.Location = new System.Drawing.Point(3, 66);
            this.btnAnlasma.Name = "btnAnlasma";
            this.btnAnlasma.Size = new System.Drawing.Size(186, 63);
            this.btnAnlasma.TabIndex = 4;
            this.btnAnlasma.Text = "ANLAŞMALAR";
            this.btnAnlasma.UseVisualStyleBackColor = true;
            this.btnAnlasma.Click += new System.EventHandler(this.btnAnlasma_Click);
            // 
            // btnYemek
            // 
            this.btnYemek.Location = new System.Drawing.Point(3, 135);
            this.btnYemek.Name = "btnYemek";
            this.btnYemek.Size = new System.Drawing.Size(186, 63);
            this.btnYemek.TabIndex = 4;
            this.btnYemek.Text = "YEMEK DURUMU";
            this.btnYemek.UseVisualStyleBackColor = true;
            this.btnYemek.Click += new System.EventHandler(this.btnYemek_Click);
            // 
            // btnArac
            // 
            this.btnArac.Location = new System.Drawing.Point(3, 204);
            this.btnArac.Name = "btnArac";
            this.btnArac.Size = new System.Drawing.Size(186, 63);
            this.btnArac.TabIndex = 4;
            this.btnArac.Text = "ARAÇ GEREÇ";
            this.btnArac.UseVisualStyleBackColor = true;
            this.btnArac.Click += new System.EventHandler(this.btnArac_Click);
            // 
            // btnGiris_Cikis
            // 
            this.btnGiris_Cikis.Location = new System.Drawing.Point(3, 273);
            this.btnGiris_Cikis.Name = "btnGiris_Cikis";
            this.btnGiris_Cikis.Size = new System.Drawing.Size(186, 63);
            this.btnGiris_Cikis.TabIndex = 4;
            this.btnGiris_Cikis.Text = "GİRİŞ ÇIKIŞ";
            this.btnGiris_Cikis.UseVisualStyleBackColor = true;
            this.btnGiris_Cikis.Click += new System.EventHandler(this.btnGiris_Cikis_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(3, 342);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(186, 63);
            this.buttonCikis.TabIndex = 4;
            this.buttonCikis.Text = "OTURUMU KAPAT";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // flowLayoutpanelAnlasmalar
            // 
            this.flowLayoutpanelAnlasmalar.Location = new System.Drawing.Point(1, 0);
            this.flowLayoutpanelAnlasmalar.Name = "flowLayoutpanelAnlasmalar";
            this.flowLayoutpanelAnlasmalar.Size = new System.Drawing.Size(1024, 137);
            this.flowLayoutpanelAnlasmalar.TabIndex = 4;
            this.flowLayoutpanelAnlasmalar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutpanelAnlasmalar_MouseDown);
            this.flowLayoutpanelAnlasmalar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutpanelAnlasmalar_MouseMove);
            this.flowLayoutpanelAnlasmalar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutpanelAnlasmalar_MouseUp);
            // 
            // textVersion
            // 
            this.textVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.textVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textVersion.Enabled = false;
            this.textVersion.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textVersion.ForeColor = System.Drawing.Color.Orange;
            this.textVersion.Location = new System.Drawing.Point(392, 27);
            this.textVersion.Name = "textVersion";
            this.textVersion.Size = new System.Drawing.Size(179, 36);
            this.textVersion.TabIndex = 5;
            this.textVersion.Text = "VERISON 1-0.1";
            // 
            // labelGirisAd
            // 
            this.labelGirisAd.AutoSize = true;
            this.labelGirisAd.Font = new System.Drawing.Font("Stencil", 13.8F);
            this.labelGirisAd.ForeColor = System.Drawing.Color.White;
            this.labelGirisAd.Location = new System.Drawing.Point(672, 108);
            this.labelGirisAd.Name = "labelGirisAd";
            this.labelGirisAd.Size = new System.Drawing.Size(98, 29);
            this.labelGirisAd.TabIndex = 9;
            this.labelGirisAd.Text = "label1";
            this.labelGirisAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGirisSoyad
            // 
            this.labelGirisSoyad.AutoSize = true;
            this.labelGirisSoyad.Font = new System.Drawing.Font("Stencil", 13.8F);
            this.labelGirisSoyad.ForeColor = System.Drawing.Color.White;
            this.labelGirisSoyad.Location = new System.Drawing.Point(776, 108);
            this.labelGirisSoyad.Name = "labelGirisSoyad";
            this.labelGirisSoyad.Size = new System.Drawing.Size(98, 29);
            this.labelGirisSoyad.TabIndex = 10;
            this.labelGirisSoyad.Text = "label1";
            this.labelGirisSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCalisanlar
            // 
            this.dataGridViewCalisanlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.dataGridViewCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalisanlar.Location = new System.Drawing.Point(14, 32);
            this.dataGridViewCalisanlar.Name = "dataGridViewCalisanlar";
            this.dataGridViewCalisanlar.ReadOnly = true;
            this.dataGridViewCalisanlar.RowHeadersWidth = 51;
            this.dataGridViewCalisanlar.RowTemplate.Height = 24;
            this.dataGridViewCalisanlar.Size = new System.Drawing.Size(555, 485);
            this.dataGridViewCalisanlar.TabIndex = 11;
            this.dataGridViewCalisanlar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCalisanlar_CellContentDoubleClick);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(610, 290);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(142, 51);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(608, 355);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(142, 51);
            this.btnYenile.TabIndex = 13;
            this.btnYenile.Text = "Liste Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(608, 424);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(142, 51);
            this.btnCalisanEkle.TabIndex = 14;
            this.btnCalisanEkle.Text = "Çalışan Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Çalışan Durumu Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCalisan
            // 
            this.panelCalisan.Controls.Add(this.dataGridViewCalisanlar);
            this.panelCalisan.Controls.Add(this.button1);
            this.panelCalisan.Controls.Add(this.btnAra);
            this.panelCalisan.Controls.Add(this.btnCalisanEkle);
            this.panelCalisan.Controls.Add(this.btnYenile);
            this.panelCalisan.Location = new System.Drawing.Point(222, 172);
            this.panelCalisan.Name = "panelCalisan";
            this.panelCalisan.Size = new System.Drawing.Size(779, 587);
            this.panelCalisan.TabIndex = 16;
            this.panelCalisan.Visible = false;
            // 
            // panelAnlasmalar
            // 
            this.panelAnlasmalar.Controls.Add(this.btnYenile2);
            this.panelAnlasmalar.Controls.Add(this.btnAnlasmaSil);
            this.panelAnlasmalar.Controls.Add(this.btnAnlasmaEkle);
            this.panelAnlasmalar.Controls.Add(this.dataGridViewAnlasmalar);
            this.panelAnlasmalar.Location = new System.Drawing.Point(222, 172);
            this.panelAnlasmalar.Name = "panelAnlasmalar";
            this.panelAnlasmalar.Size = new System.Drawing.Size(779, 587);
            this.panelAnlasmalar.TabIndex = 17;
            this.panelAnlasmalar.Visible = false;
            // 
            // btnYenile2
            // 
            this.btnYenile2.Location = new System.Drawing.Point(660, 419);
            this.btnYenile2.Name = "btnYenile2";
            this.btnYenile2.Size = new System.Drawing.Size(119, 62);
            this.btnYenile2.TabIndex = 3;
            this.btnYenile2.Text = "Sayfayı Yenile";
            this.btnYenile2.UseVisualStyleBackColor = true;
            this.btnYenile2.Click += new System.EventHandler(this.btnYenile2_Click);
            // 
            // btnAnlasmaSil
            // 
            this.btnAnlasmaSil.Location = new System.Drawing.Point(660, 330);
            this.btnAnlasmaSil.Name = "btnAnlasmaSil";
            this.btnAnlasmaSil.Size = new System.Drawing.Size(119, 62);
            this.btnAnlasmaSil.TabIndex = 2;
            this.btnAnlasmaSil.Text = "Anlaşma Sil";
            this.btnAnlasmaSil.UseVisualStyleBackColor = true;
            this.btnAnlasmaSil.Click += new System.EventHandler(this.btnAnlasmaSil_Click);
            // 
            // btnAnlasmaEkle
            // 
            this.btnAnlasmaEkle.Location = new System.Drawing.Point(660, 241);
            this.btnAnlasmaEkle.Name = "btnAnlasmaEkle";
            this.btnAnlasmaEkle.Size = new System.Drawing.Size(119, 62);
            this.btnAnlasmaEkle.TabIndex = 1;
            this.btnAnlasmaEkle.Text = "Anlaşma Ekle";
            this.btnAnlasmaEkle.UseVisualStyleBackColor = true;
            this.btnAnlasmaEkle.Click += new System.EventHandler(this.btnAnlasmaEkle_Click);
            // 
            // dataGridViewAnlasmalar
            // 
            this.dataGridViewAnlasmalar.AllowUserToAddRows = false;
            this.dataGridViewAnlasmalar.AllowUserToDeleteRows = false;
            this.dataGridViewAnlasmalar.AllowUserToResizeColumns = false;
            this.dataGridViewAnlasmalar.AllowUserToResizeRows = false;
            this.dataGridViewAnlasmalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.dataGridViewAnlasmalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAnlasmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnlasmalar.Location = new System.Drawing.Point(25, 19);
            this.dataGridViewAnlasmalar.MultiSelect = false;
            this.dataGridViewAnlasmalar.Name = "dataGridViewAnlasmalar";
            this.dataGridViewAnlasmalar.ReadOnly = true;
            this.dataGridViewAnlasmalar.RowHeadersVisible = false;
            this.dataGridViewAnlasmalar.RowHeadersWidth = 51;
            this.dataGridViewAnlasmalar.RowTemplate.Height = 24;
            this.dataGridViewAnlasmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAnlasmalar.Size = new System.Drawing.Size(629, 550);
            this.dataGridViewAnlasmalar.TabIndex = 0;
            this.dataGridViewAnlasmalar.TabStop = false;
            this.dataGridViewAnlasmalar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnlasmalar_CellContentDoubleClick);
            // 
            // panelYemekDurumu
            // 
            this.panelYemekDurumu.Controls.Add(this.btnYemekEkle);
            this.panelYemekDurumu.Controls.Add(this.btnSorumluDegistir);
            this.panelYemekDurumu.Controls.Add(this.dataGridViewYemek);
            this.panelYemekDurumu.Location = new System.Drawing.Point(222, 172);
            this.panelYemekDurumu.Name = "panelYemekDurumu";
            this.panelYemekDurumu.Size = new System.Drawing.Size(779, 587);
            this.panelYemekDurumu.TabIndex = 18;
            this.panelYemekDurumu.Visible = false;
            // 
            // btnYemekEkle
            // 
            this.btnYemekEkle.Location = new System.Drawing.Point(638, 342);
            this.btnYemekEkle.Name = "btnYemekEkle";
            this.btnYemekEkle.Size = new System.Drawing.Size(136, 64);
            this.btnYemekEkle.TabIndex = 19;
            this.btnYemekEkle.Text = "Yemek Ekle";
            this.btnYemekEkle.UseVisualStyleBackColor = true;
            this.btnYemekEkle.Click += new System.EventHandler(this.btnYemekEkle_Click);
            // 
            // btnSorumluDegistir
            // 
            this.btnSorumluDegistir.Location = new System.Drawing.Point(638, 260);
            this.btnSorumluDegistir.Name = "btnSorumluDegistir";
            this.btnSorumluDegistir.Size = new System.Drawing.Size(136, 64);
            this.btnSorumluDegistir.TabIndex = 2;
            this.btnSorumluDegistir.Text = "Sorumlu Değiştir";
            this.btnSorumluDegistir.UseVisualStyleBackColor = true;
            this.btnSorumluDegistir.Click += new System.EventHandler(this.btnSorumluDegistir_Click);
            // 
            // dataGridViewYemek
            // 
            this.dataGridViewYemek.AllowUserToAddRows = false;
            this.dataGridViewYemek.AllowUserToDeleteRows = false;
            this.dataGridViewYemek.AllowUserToResizeColumns = false;
            this.dataGridViewYemek.AllowUserToResizeRows = false;
            this.dataGridViewYemek.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.dataGridViewYemek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewYemek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYemek.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewYemek.MultiSelect = false;
            this.dataGridViewYemek.Name = "dataGridViewYemek";
            this.dataGridViewYemek.ReadOnly = true;
            this.dataGridViewYemek.RowHeadersVisible = false;
            this.dataGridViewYemek.RowHeadersWidth = 51;
            this.dataGridViewYemek.RowTemplate.Height = 24;
            this.dataGridViewYemek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYemek.Size = new System.Drawing.Size(629, 550);
            this.dataGridViewYemek.TabIndex = 1;
            this.dataGridViewYemek.TabStop = false;
            this.dataGridViewYemek.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewYemek_CellDoubleClick);
            this.dataGridViewYemek.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewYemek_RowEnter);
            // 
            // panelGiris
            // 
            this.panelGiris.Controls.Add(this.btnIslem);
            this.panelGiris.Controls.Add(this.dataGridViewGiris);
            this.panelGiris.Location = new System.Drawing.Point(219, 169);
            this.panelGiris.Name = "panelGiris";
            this.panelGiris.Size = new System.Drawing.Size(779, 587);
            this.panelGiris.TabIndex = 20;
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(680, 265);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(94, 58);
            this.btnIslem.TabIndex = 3;
            this.btnIslem.Text = "İşlem";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // dataGridViewGiris
            // 
            this.dataGridViewGiris.AllowUserToAddRows = false;
            this.dataGridViewGiris.AllowUserToDeleteRows = false;
            this.dataGridViewGiris.AllowUserToResizeColumns = false;
            this.dataGridViewGiris.AllowUserToResizeRows = false;
            this.dataGridViewGiris.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.dataGridViewGiris.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGiris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiris.Location = new System.Drawing.Point(14, 19);
            this.dataGridViewGiris.MultiSelect = false;
            this.dataGridViewGiris.Name = "dataGridViewGiris";
            this.dataGridViewGiris.ReadOnly = true;
            this.dataGridViewGiris.RowHeadersVisible = false;
            this.dataGridViewGiris.RowHeadersWidth = 51;
            this.dataGridViewGiris.RowTemplate.Height = 24;
            this.dataGridViewGiris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGiris.Size = new System.Drawing.Size(629, 550);
            this.dataGridViewGiris.TabIndex = 2;
            this.dataGridViewGiris.TabStop = false;
            // 
            // panelArac
            // 
            this.panelArac.Controls.Add(this.btnAracEkle);
            this.panelArac.Controls.Add(this.dataGridViewArac);
            this.panelArac.Location = new System.Drawing.Point(222, 172);
            this.panelArac.Name = "panelArac";
            this.panelArac.Size = new System.Drawing.Size(779, 587);
            this.panelArac.TabIndex = 19;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(662, 249);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(114, 55);
            this.btnAracEkle.TabIndex = 3;
            this.btnAracEkle.Text = "Arac Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // dataGridViewArac
            // 
            this.dataGridViewArac.AllowUserToAddRows = false;
            this.dataGridViewArac.AllowUserToDeleteRows = false;
            this.dataGridViewArac.AllowUserToResizeColumns = false;
            this.dataGridViewArac.AllowUserToResizeRows = false;
            this.dataGridViewArac.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.dataGridViewArac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewArac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArac.Location = new System.Drawing.Point(14, 19);
            this.dataGridViewArac.MultiSelect = false;
            this.dataGridViewArac.Name = "dataGridViewArac";
            this.dataGridViewArac.ReadOnly = true;
            this.dataGridViewArac.RowHeadersVisible = false;
            this.dataGridViewArac.RowHeadersWidth = 51;
            this.dataGridViewArac.RowTemplate.Height = 24;
            this.dataGridViewArac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArac.Size = new System.Drawing.Size(629, 550);
            this.dataGridViewArac.TabIndex = 2;
            this.dataGridViewArac.TabStop = false;
            this.dataGridViewArac.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArac_CellContentDoubleClick);
            // 
            // btnYetki
            // 
            this.btnYetki.Location = new System.Drawing.Point(15, 621);
            this.btnYetki.Name = "btnYetki";
            this.btnYetki.Size = new System.Drawing.Size(169, 59);
            this.btnYetki.TabIndex = 21;
            this.btnYetki.Text = "Yetki Ver";
            this.btnYetki.UseVisualStyleBackColor = true;
            this.btnYetki.Click += new System.EventHandler(this.btnYetki_Click);
            // 
            // pictureGirisFemale
            // 
            this.pictureGirisFemale.Image = global::FinalÖdevi.Properties.Resources.kadın48x48;
            this.pictureGirisFemale.Location = new System.Drawing.Point(620, 90);
            this.pictureGirisFemale.Name = "pictureGirisFemale";
            this.pictureGirisFemale.Size = new System.Drawing.Size(46, 47);
            this.pictureGirisFemale.TabIndex = 8;
            this.pictureGirisFemale.TabStop = false;
            this.pictureGirisFemale.Visible = false;
            // 
            // pictureGirisMale
            // 
            this.pictureGirisMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureGirisMale.Image = global::FinalÖdevi.Properties.Resources.kıl;
            this.pictureGirisMale.Location = new System.Drawing.Point(620, 92);
            this.pictureGirisMale.Name = "pictureGirisMale";
            this.pictureGirisMale.Size = new System.Drawing.Size(46, 45);
            this.pictureGirisMale.TabIndex = 6;
            this.pictureGirisMale.TabStop = false;
            this.pictureGirisMale.Visible = false;
            this.pictureGirisMale.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalÖdevi.Properties.Resources.Screenshot;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalisanlar
            // 
            this.btnCalisanlar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalisanlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanlar.Image = global::FinalÖdevi.Properties.Resources.calisanlar_buton_default;
            this.btnCalisanlar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalisanlar.Location = new System.Drawing.Point(0, 0);
            this.btnCalisanlar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalisanlar.Name = "btnCalisanlar";
            this.btnCalisanlar.Size = new System.Drawing.Size(186, 63);
            this.btnCalisanlar.TabIndex = 4;
            this.btnCalisanlar.UseVisualStyleBackColor = false;
            this.btnCalisanlar.Click += new System.EventHandler(this.btnCalisanlar_Click);
            this.btnCalisanlar.MouseEnter += new System.EventHandler(this.btnCalisanlar_MouseEnter);
            this.btnCalisanlar.MouseLeave += new System.EventHandler(this.btnCalisanlar_MouseLeave);
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(15, 686);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(169, 32);
            this.btnBolumEkle.TabIndex = 22;
            this.btnBolumEkle.Text = "Bölüm Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.Location = new System.Drawing.Point(15, 724);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(169, 33);
            this.btnDepartmanEkle.TabIndex = 23;
            this.btnDepartmanEkle.Text = "Departman Ekle";
            this.btnDepartmanEkle.UseVisualStyleBackColor = true;
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // FrmAna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnDepartmanEkle);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.btnYetki);
            this.Controls.Add(this.panelGiris);
            this.Controls.Add(this.panelYemekDurumu);
            this.Controls.Add(this.panelArac);
            this.Controls.Add(this.panelCalisan);
            this.Controls.Add(this.panelAnlasmalar);
            this.Controls.Add(this.labelGirisSoyad);
            this.Controls.Add(this.labelGirisAd);
            this.Controls.Add(this.pictureGirisFemale);
            this.Controls.Add(this.pictureGirisMale);
            this.Controls.Add(this.textVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutpanelCalisan);
            this.Controls.Add(this.btnalt);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.flowLayoutpanelAnlasmalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAna";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAna";
            this.Load += new System.EventHandler(this.FrmAna_Load);
            this.flowLayoutpanelCalisan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalisanlar)).EndInit();
            this.panelCalisan.ResumeLayout(false);
            this.panelAnlasmalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnlasmalar)).EndInit();
            this.panelYemekDurumu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYemek)).EndInit();
            this.panelGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiris)).EndInit();
            this.panelArac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGirisFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGirisMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutpanelCalisan;
        private System.Windows.Forms.Button btnYemek;
        private System.Windows.Forms.Button btnArac;
        private System.Windows.Forms.Button btnGiris_Cikis;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutpanelAnlasmalar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textVersion;
        private System.Windows.Forms.PictureBox pictureGirisMale;
        private System.Windows.Forms.PictureBox pictureGirisFemale;
        private System.Windows.Forms.Label labelGirisAd;
        private System.Windows.Forms.Label labelGirisSoyad;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnCalisanEkle;
        public System.Windows.Forms.DataGridView dataGridViewCalisanlar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCalisan;
        private System.Windows.Forms.Button btnAnlasmaEkle;
        private System.Windows.Forms.Button btnAnlasmaSil;
        private System.Windows.Forms.Button btnCalisanlar;
        private System.Windows.Forms.Button btnAnlasma;
        private System.Windows.Forms.Panel panelAnlasmalar;
        private System.Windows.Forms.Button btnYenile2;
        public System.Windows.Forms.DataGridView dataGridViewAnlasmalar;
        private System.Windows.Forms.Panel panelYemekDurumu;
        public System.Windows.Forms.DataGridView dataGridViewYemek;
        private System.Windows.Forms.Button btnSorumluDegistir;
        private System.Windows.Forms.Button btnYemekEkle;
        private System.Windows.Forms.Panel panelArac;
        public System.Windows.Forms.DataGridView dataGridViewArac;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Panel panelGiris;
        private System.Windows.Forms.Button btnIslem;
        public System.Windows.Forms.DataGridView dataGridViewGiris;
        private System.Windows.Forms.Button btnYetki;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.Button btnDepartmanEkle;
    }
}