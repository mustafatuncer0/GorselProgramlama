using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace FinalÖdevi
{
    public partial class FrmAnlDty : Form
    {
        public FrmAnlDty()
        {
            InitializeComponent();
        }
        // bağlantı satırı yazıldı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");

        // ıd yi comboboxlarda kolaylıkla  bulmak için action tanımlandı
        private string IdBulucu(string str)
        {
            string[] sayilar = Regex.Split(str, @"\D+");
            str = null;
            foreach (string s in sayilar)
            {
                int sayi;
                if (int.TryParse(s, out sayi))
                {
                    str = str + s;
                }
            }
            return str;

        }
        static string Fiyat;
        // fomrm yüklenirken çalışacak action
        private void FrmAnlDty_Load(object sender, EventArgs e)
        {
            // form anlaşma id ye (ana formdan gelen id ye) göre 
            //değerler okundu ve ilgili allanlara yazıldı
            labelId.Text = FrmAna.anlid;
            SqlCommand komut = new SqlCommand();
            
            komut.CommandText = "SELECT *FROM Anlasma WHERE Anlasma_ID= '"+FrmAna.anlid+"'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            baglanti.Open();
            SqlDataReader dr;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                textBoxAd.Text = Convert.ToString(dr["Anlasma_Isteyen"]);
                textBoxIl.Text = Convert.ToString(dr["Anlasma_Il"]);
                textBoxIlce.Text = Convert.ToString(dr["Anlasma_Ilce"]);
                maskedTextBoxTel.Text = "0" + Convert.ToString(dr["Anlasma_Iletisim_Tel"]);
                dateTimePickerTarih.Value = Convert.ToDateTime(dr["Anlasma_Tarih"]);
                maskedTextBoxMiktar.Text = IdBulucu(Convert.ToString(dr["Anlasma_Miktar"]));
                
                Fiyat = Convert.ToString(dr["Anlasma_Fiyat"]);
                int sifir_sayisi = 6 - (Fiyat.Length);
                while (sifir_sayisi > 0)
                {
                    Fiyat = "0" + Fiyat;
                    sifir_sayisi--;

                }
                maskedTextBoxFiyat.Text = Fiyat;
                richTextBoxYemek.Text = Convert.ToString(dr["Anlasma_Yemekler"]);

                richTextBoxAdres.Text = Convert.ToString(dr["Anlasma_Adress"]);

                baglanti.Close();

            }
            



            
                

        }
        //kapatma buton tanımlanması
        private void btnExit_Click(object sender, EventArgs e)
        {
            //form kapat
            this.Hide();
        }
        //kaydet buton tanımlanması
        private void btnSave_Click(object sender, EventArgs e)
        {//değiiştirelecek olan verileri değiştirmek üçün update işlemi yapılarak data base tablo cloumn adları alındı ve değiştirildi.
            baglanti.Open();
            string kayit = "update Anlasma set Anlasma_Isteyen=@Anlasma_Isteyen,Anlasma_Il=@Anlasma_Il,Anlasma_Ilce=@Anlasma_Ilce,Anlasma_Iletisim_Tel=@Anlasma_Iletisim_Tel ,Anlasma_Tarih= Anlasma_Tarih, Anlasma_Fiyat=@Anlasma_Fiyat,Anlasma_Yemekler=@Anlasma_Yemekler,Anlasma_Adress=@Anlasma_Adress,Anlasma_Miktar=@Anlasma_Miktar where Anlasma_Id='" + labelId.Text + "'";

            SqlCommand komut = new SqlCommand(kayit, baglanti);


            komut.Parameters.AddWithValue("@Anlasma_Isteyen", textBoxAd.Text);
            komut.Parameters.AddWithValue("@Anlasma_Il ", textBoxIl.Text);
            komut.Parameters.AddWithValue("@Anlasma_Ilce", textBoxIlce.Text);
            komut.Parameters.AddWithValue("@Anlasma_Iletisim_Tel", IdBulucu(maskedTextBoxTel.Text.Substring(1)));
            komut.Parameters.AddWithValue("@Anlasma_Tarih", dateTimePickerTarih.Value.ToShortDateString());
            komut.Parameters.AddWithValue("@Anlasma_Fiyat", IdBulucu(maskedTextBoxFiyat.Text));
            komut.Parameters.AddWithValue("@Anlasma_Yemekler", richTextBoxYemek.Text);
            komut.Parameters.AddWithValue("@Anlasma_Adress", richTextBoxAdres.Text);
            komut.Parameters.AddWithValue("@Anlasma_Miktar", maskedTextBoxMiktar.Text);



            
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            //kullanıcıya bilgi verilip ana formdaki veriler güncelleniyor
            MessageBox.Show("Anlaşma Detayları Güncellendi.");
            FrmAna f1 = (FrmAna)Application.OpenForms["FrmAna"];
            baglanti.Open();
            SqlDataAdapter calisan_listele = new SqlDataAdapter("SELECT Anlasma_Id AS [İD],Anlasma_Isteyen AS [FİRMA ADI],Anlasma_Yemekler AS [İSTENİLENLER],Anlasma_Iletisim_Tel AS [TELEFON],Anlasma_Tarih AS [TARİH],Anlasma_Miktar AS [MİKTAR] FROM Anlasma WHERE Anlasma_Durum=1 ORDER BY Anlasma_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            calisan_listele.Fill(dshafiza);
            f1.dataGridViewAnlasmalar.DataSource = dshafiza.Tables[0];

            baglanti.Close();

        }

        private void maskedTextBoxMiktar_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxMiktar.SelectionStart
    = maskedTextBoxMiktar.MaskedTextProvider.LastAssignedPosition + 1;
            maskedTextBoxMiktar.SelectionLength = 0;
        }
    }
}
