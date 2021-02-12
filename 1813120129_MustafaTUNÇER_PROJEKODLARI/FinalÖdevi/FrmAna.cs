using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Güvenli sifre oluştrumak için kütüphane tanımlaması yapıldı
using System.Text.RegularExpressions;
//Klasör oluşturmak , bir klasörün olup olmadığını kontrol etmek için ve resim kopyalama işlemlerini yapmak için kütüphane tanımlanması
using System.IO;



namespace FinalÖdevi
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }
        // bağlantı satırı tanımlandı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");
        
        //kullnaci ekleme güncellem işlemlerinde datagridi anlık olarak değiştirmek için
        
        //calışanları gösterme fonksiyonu
        private void calisanlari_goster() {


            baglanti.Open();
            SqlDataAdapter calisan_listele = new SqlDataAdapter("SELECT Calisan_id AS [ID],Calisan_Adi AS[AD] , Calisan_Soyadi AS[SOYAD],Calisan_Bolum_id AS[BOLUM KODU],Calisan_İse_Giris_Tarihi AS[CALIŞAN BAŞLANGICI] FROM Calisan WHERE Calisan_Durum=1 ORDER BY Calisan_Adi ASC", baglanti);
                DataSet dshafiza = new DataSet();
                calisan_listele.Fill(dshafiza);
                dataGridViewCalisanlar.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            
            
            
        }
        //anlaşmaları gösterme fonksiyonu
        private void anlasmalari_goster() {
            baglanti.Open();
            SqlDataAdapter anlasma_listele = new SqlDataAdapter("SELECT Anlasma_Id AS [İD],Anlasma_Isteyen AS [FİRMA ADI],Anlasma_Yemekler AS [İSTENİLENLER],Anlasma_Iletisim_Tel AS [TELEFON],Anlasma_Tarih AS [TARİH],Anlasma_Miktar AS [MİKTAR] FROM Anlasma WHERE Anlasma_Durum=1 ORDER BY Anlasma_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            anlasma_listele.Fill(dshafiza);
            dataGridViewAnlasmalar.DataSource = dshafiza.Tables[0];
            baglanti.Close();

        
        
        }
        //yemekleri gösterme fonksiyonu
        private void yemek_goster()
        {


            baglanti.Open();
            SqlDataAdapter yemek_listele = new SqlDataAdapter("SELECT Yemek_Id AS [ID],Yemek_Adi AS [YEMEK İSMİ],Yemek_Gonderilecek_İd AS [ANLAŞMA KODU],Yemek_Tarih [TARİH],Yemek_Sorumlu_Tel AS [SORUMLU TEL],Yemek_Durum AS [DURUM] FROM Yemekler ORDER BY Yemek_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            yemek_listele.Fill(dshafiza);
            dataGridViewYemek.DataSource = dshafiza.Tables[0];
            baglanti.Close();



        }
        //araçları gösterme fonksiyonu
        private void Arac_goster()
        {


            baglanti.Open();
            SqlDataAdapter arac_listele = new SqlDataAdapter("SELECT Arac_Id AS [ID],Arac_Adi AS [YEMEK İSMİ],Arac_Durumu AS [ANLAŞMA KODU],Arac_Adedi [TARİH] FROM Arac_Gerec ORDER BY Arac_Adi ASC", baglanti);
            DataSet dshafiza = new DataSet();
            arac_listele.Fill(dshafiza);
            dataGridViewArac.DataSource = dshafiza.Tables[0];
            baglanti.Close();



        }
        //giriş çıkış verilerini gösteme fonksiyonu
        private void Giris_goster()
        {


            baglanti.Open();
            
            SqlDataAdapter Giris_listele = new SqlDataAdapter("SELECT Giris_Id AS [ID], Giris_Ad AS [GİRİŞ İSMİ],Giris_Soyad AS [GİRİŞ SOYİSMİ],Giris_Yapan_Id [GİRİŞ YAPAM ID],Giris_Tarih [TARİH] FROM GirisCikis ORDER BY Giris_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            Giris_listele.Fill(dshafiza);
            dataGridViewGiris.DataSource = dshafiza.Tables[0];
            baglanti.Close();



        }

        //açılış animasyonu  donksiyonu
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;

        }

        //alta alma buton fonkiyonu
        private void btnalt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //çıkış buton fonksiyonu
        private void btncikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        // çıkış ve alta alma işlemlerin fonksiyonları (animasyon resim değiştirme)
        private void btncikis_MouseEnter(object sender, EventArgs e)
        {
            btncikis.ForeColor = Color.Red;

            btncikis.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

        }

        private void btncikis_MouseLeave(object sender, EventArgs e)
        {
            btncikis.ForeColor = Color.White;

            btncikis.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

        }

        private void btnalt_MouseEnter(object sender, EventArgs e)
        {
            btnalt.ForeColor = Color.LightBlue;
            btnalt.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

        }

        private void btnalt_MouseLeave(object sender, EventArgs e)
        {
            btnalt.ForeColor = Color.White;
            btnalt.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

        }
        //form taşıma için veri alımı
       
        static bool move;
        static int mouse_x;
        static int mouse_y;

        

        
        //form taşıma fonksiyonları
        private void flowLayoutpanelAnlasmalar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void flowLayoutpanelAnlasmalar_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void flowLayoutpanelAnlasmalar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
       //load anında hiçbir panel gözükmemesi için tanımlanan ayrıyetten de kullanıcı girişi için kullanılan sorgular ve kullanıcının
        // adı gibi gelen verilerin gösterilmesi ve resimlerinin değiştirlmesi Yetkilendirme işlevi de burda yapıldı 
        private void FrmAna_Load(object sender, EventArgs e)
        {
            panelGiris.Visible = false;
            panelArac.Visible = false;
            panelCalisan.Visible = false;
            panelAnlasmalar.Visible = false;
            panelYemekDurumu.Visible = false;
           
            
            SqlCommand komut = new SqlCommand();

            baglanti.Open();
            komut.Connection = baglanti;
            

            komut.CommandText = "SELECT *FROM Calisan where Calisan_id='" + FrmKGiris.gonderilecekveri + "'";
            SqlDataReader read = komut.ExecuteReader();
            if (read.Read())
            {
                if (read["Calisan_Durum"].ToString() == "True")
                {
                    labelGirisAd.Text = read["Calisan_Adi"].ToString();
                    labelGirisSoyad.Text = read["Calisan_Soyadi"].ToString();
                    if ((read["Calisan_Cinsiyet"].ToString()) == "K")
                    {
                        pictureGirisFemale.Visible = true;

                    }
                    else if ((read["Calisan_Cinsiyet"].ToString()) == "E")
                    {
                        pictureGirisMale.Visible = true;
                    }

                }
                else if (read["Calisan_Durum"].ToString() == "False")
                {
                    MessageBox.Show("Erişim Yetkiniz Bulunmamaktadır " , "Yetkisiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }
                    if (read["Calisan_Yetki"].ToString() == "1")
                {
                    btnCalisanlar.Visible = true;
                    btnAnlasma.Visible = true;
                    btnYemek.Visible = true;
                    btnArac.Visible = true;
                    btnGiris_Cikis.Visible = true;
                    buttonCikis.Visible = true;
                    btnYetki.Visible = true;
                    btnDepartmanEkle.Visible = true;
                    btnBolumEkle.Visible = true;

                }
                else if (read["Calisan_Yetki"].ToString() == "2")
                {
                    btnCalisanlar.Visible = false;
                    btnAnlasma.Visible = true;
                    btnYemek.Visible = true;
                    btnArac.Visible = false;
                    btnGiris_Cikis.Visible = false;
                    buttonCikis.Visible = true;
                    btnYetki.Visible = false;
                    btnDepartmanEkle.Visible = false;
                    btnBolumEkle.Visible = false;

                }
                else if (read["Calisan_Yetki"].ToString() == "3")
                {
                    btnCalisanlar.Visible = true;
                    btnAnlasma.Visible = true;
                    btnYemek.Visible = true;
                    btnArac.Visible = false;
                    btnGiris_Cikis.Visible = false;
                    buttonCikis.Visible = true;
                    btnYetki.Visible = false;
                    btnDepartmanEkle.Visible = false;
                    btnBolumEkle.Visible = false;

                }
                else {

                    btnCalisanlar.Visible = false;
                    btnAnlasma.Visible = false;
                    btnYemek.Visible = false;
                    btnArac.Visible = false;
                    btnGiris_Cikis.Visible = false;
                    buttonCikis.Visible = false;
                    btnYetki.Visible = false;
                    btnDepartmanEkle.Visible = false;
                    btnBolumEkle.Visible = false;
                    MessageBox.Show("Erişim Yetkiniz Bulunmamaktadır ", "Yetkisiz Giriş",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }

            baglanti.Close();
            read.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
        //basıma göre resim değiştirme işlevi

        static bool bas_kotrol=false;

        private void btnCalisanlar_MouseLeave(object sender, EventArgs e)
        {
            if (bas_kotrol == false)
            {
                btnCalisanlar.Image = Properties.Resources.calisanlar_buton_default;
            }
            else if(bas_kotrol== true)
            { 
                btnCalisanlar.Image = Properties.Resources.calisanlar_buton_selected;
            }
        }

        private void btnCalisanlar_MouseEnter(object sender, EventArgs e)
        {
            if (bas_kotrol == false)
            {
                btnCalisanlar.Image = Properties.Resources.calisanlar_buton_enter;
            }
            else if (bas_kotrol == true)
            {
                btnCalisanlar.Image = Properties.Resources.calisanlar_buton_selectedandenter;
            }

        }
        // basılan paneldeki verilerin üstüne basıldığında karşılık gelen satırı ve ıd yi diğer formlara taşıyan ve de basılan butondaki formu açan iactionların tanımlanması
        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            panelCalisan.Visible = true;
            panelGiris.Visible = false;
            panelAnlasmalar.Visible = false;
            panelYemekDurumu.Visible = false;
            panelArac.Visible = false;
            btnCalisanlar.Image = Properties.Resources.calisanlar_buton_selected;
            bas_kotrol = true;
            calisanlari_goster();
            panelCalisan.BringToFront();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Form_ARA pencere = new Form_ARA();
            pencere.Show();
        }

       

        private void btnYenile_Click(object sender, EventArgs e)
        {
            btnCalisanlar.Image = Properties.Resources.calisanlar_buton_selected;
            bas_kotrol = true;
            calisanlari_goster();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            FrmCalisanEkle pencere = new FrmCalisanEkle();
            pencere.Show();
        }
        public static string id=null;
        private void dataGridViewCalisanlar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridViewCalisanlar.SelectedCells[0].RowIndex;
            id = dataGridViewCalisanlar.Rows[secilialan].Cells[0].Value.ToString();
            FrmKlnDty pencere = new FrmKlnDty();
            
            pencere.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilialan = dataGridViewCalisanlar.SelectedCells[0].RowIndex;
            id = dataGridViewCalisanlar.Rows[secilialan].Cells[0].Value.ToString(); 
            SqlCommand komut1 = new SqlCommand(); 
            baglanti.Open();
            komut1.Connection = baglanti;
            komut1.CommandText = "SELECT *FROM Calisan where Calisan_id='" + id + "'";
            SqlDataReader reader = komut1.ExecuteReader();
            
                

            if (reader.Read())
            {
                if (reader["Calisan_Durum"].ToString() == "False") {
                    reader.Close();
                    string kayit = "update Calisan set Calisan_Durum=@Calisan_Durum where Calisan_id='" + id + "'";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@Calisan_Durum", "True");
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                }
                else if (reader["Calisan_Durum"].ToString() == "True") {
                    reader.Close();
                    string kayit = "update Calisan set Calisan_Durum=@Calisan_Durum where Calisan_id='" + id + "'";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@Calisan_Durum", "False");
                     komut.ExecuteNonQuery();
                    baglanti.Close();
                    
                }
                
            }

            
            btnYenile_Click(null,null);
            

        }

        private void btnAnlasma_Click(object sender, EventArgs e)
        {
            
            panelCalisan.Visible = false;
            panelGiris.Visible = false;
            btnCalisanlar.Image = Properties.Resources.calisanlar_buton_default;
            bas_kotrol = false;
            panelAnlasmalar.Visible = true;
            panelYemekDurumu.Visible = false;
            panelArac.Visible = false;
            anlasmalari_goster();
            panelAnlasmalar.BringToFront();
        }
        public static string anlid=null;
        private void dataGridViewAnlasmalar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridViewAnlasmalar.SelectedCells[0].RowIndex;
            anlid = dataGridViewAnlasmalar.Rows[secilialan].Cells[0].Value.ToString();
            FrmAnlDty pencere = new FrmAnlDty();

            pencere.Show();
        }

        private void btnAnlasmaEkle_Click(object sender, EventArgs e)
        {
            FrmAnlasmaEkle pencere = new FrmAnlasmaEkle();
            pencere.Show();
        }

        private void btnAnlasmaSil_Click(object sender, EventArgs e)
        {
            int secilialan = dataGridViewAnlasmalar.SelectedCells[0].RowIndex;
            anlid = dataGridViewAnlasmalar.Rows[secilialan].Cells[0].Value.ToString();
            SqlCommand komut1 = new SqlCommand();
            baglanti.Open();
            komut1.Connection = baglanti;
            komut1.CommandText = "SELECT *FROM Anlasma where Anlasma_Id='" + anlid + "'";
            SqlDataReader reader = komut1.ExecuteReader();



            if (reader.Read())
            {
                if (reader["Anlasma_Durum"].ToString() == "False")
                {
                    reader.Close();
                    string kayit = "update Calisan set Anlasma_Durum=@Anlasma_Durum where Anlasma_Id='" + anlid + "'";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@Anlasma_Durum", "True");
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                }
                else if (reader["Anlasma_Durum"].ToString() == "True")
                {
                    reader.Close();
                    string kayit = "update Anlasma set Anlasma_Durum=@Anlasma_Durum where Anlasma_Id='" + anlid + "'";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@Anlasma_Durum", "False");
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                }

            }


            btnYenile2_Click(null, null);
        }

        private void btnYenile2_Click(object sender, EventArgs e)
        {
            anlasmalari_goster();
        }

        private void btnYemek_Click(object sender, EventArgs e)
        {
            panelCalisan.Visible = false;
            btnCalisanlar.Image = Properties.Resources.calisanlar_buton_default;
            bas_kotrol = false;
            panelAnlasmalar.Visible = false;
            panelArac.Visible = false;
            panelGiris.Visible = false;
            panelYemekDurumu.Visible = true;
            yemek_goster();
            panelYemekDurumu.BringToFront();
            baglanti.Close();
        }
        
        private void dataGridViewYemek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridViewYemek.SelectedCells[0].RowIndex;
            anlid = dataGridViewYemek.Rows[secilialan].Cells[2].Value.ToString();
            FrmAnlDty pencere = new FrmAnlDty();

            pencere.Show();
        }

        static public string seciliid=null;
        private void btnSorumluDegistir_Click(object sender, EventArgs e)
        {
            FrmSrmlDgs pencere = new FrmSrmlDgs();
            pencere.Show();
            


        }
        public static string sorumlu=null;
        private void dataGridViewYemek_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            SqlDataAdapter yemek_listele = new SqlDataAdapter("SELECT Yemek_Id AS [ID],Yemek_Adi AS [YEMEK İSMİ],Yemek_Gonderilecek_İd AS [ANLAŞMA KODU],Yemek_Tarih [TARİH],Yemek_Sorumlu_Tel AS [SORUMLU TEL],Yemek_Durum AS [DURUM],Yemek_Sorumlu AS [SORUMLU] FROM Yemekler ORDER BY Yemek_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            yemek_listele.Fill(dshafiza);
           
            
            seciliid = dshafiza.Tables[0].Rows[e.RowIndex]["ID"].ToString();
            sorumlu= dshafiza.Tables[0].Rows[e.RowIndex]["SORUMLU"].ToString();
            baglanti.Close();
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            YemekEkle pencere = new YemekEkle();
            pencere.Show();
        }

        private void btnArac_Click(object sender, EventArgs e)
        {
            panelCalisan.Visible = false;
            panelGiris.Visible = false;
            btnCalisanlar.Image = Properties.Resources.calisanlar_buton_default;
            bas_kotrol = false;
            panelAnlasmalar.Visible = false;
            panelYemekDurumu.Visible = false;
            panelArac.Visible = true;
            panelArac.BringToFront();
            
            Arac_goster();
            
            baglanti.Close();
        }

        public static string aracid = null;
        private void dataGridViewArac_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridViewCalisanlar.SelectedCells[0].RowIndex;
            aracid = dataGridViewCalisanlar.Rows[secilialan].Cells[0].Value.ToString();
            FrmAracDurum pencere = new FrmAracDurum();

            pencere.Show();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            FrmAracEkle pencere = new FrmAracEkle();

            pencere.Show();
        }

        

        private void btnIslem_Click(object sender, EventArgs e)
        {
            FrmGiris pencere = new FrmGiris();

            pencere.Show();
        }

        private void btnGiris_Cikis_Click(object sender, EventArgs e)
        {
            
                

                btnCalisanlar.Image = Properties.Resources.calisanlar_buton_default;
                bas_kotrol = false;
                panelYemekDurumu.Visible = false;
                panelAnlasmalar.Visible = false;
                panelGiris.Visible = true;
                panelArac.Visible = false;
                Giris_goster();
                panelGiris.BringToFront();

                baglanti.Close();
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmKGiris pencere = new FrmKGiris();

            pencere.Show();
        }

        private void btnYetki_Click(object sender, EventArgs e)
        {
            FrmYetki pencere = new FrmYetki();

            pencere.Show();
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            FrmBolumEkle pencere = new FrmBolumEkle();

            pencere.Show();

        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            FrmDepartmanEkle pencere = new FrmDepartmanEkle();

            pencere.Show();
        }
    }
}
