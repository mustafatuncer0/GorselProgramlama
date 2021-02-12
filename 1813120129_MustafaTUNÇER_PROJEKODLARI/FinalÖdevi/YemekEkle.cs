using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalÖdevi
{
    public partial class YemekEkle : Form
    {
        public YemekEkle()
        {
            InitializeComponent();
        }
        // Id bulmak için RegularExpressions clası içeri dahil ederek Regex içersindeki Split fonksiyonlarıyla yanlızca sayıları çekip dönderdim.
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
        //Sql Data Baseyle Bağlantı Sağlandı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");

        //Yemek ekle ekrano yüklenirken işlemler taımlandı
        private void YemekEkle_Load(object sender, EventArgs e)
        {
            // Comboxa Db den okunup Calisan ile ilgili bilgiler koyuldu
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Calisan";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            string ad;
            string soyad;
            int id;
            while (dr.Read())
            {
                ad = Convert.ToString(dr["Calisan_Adi"]);
                soyad = Convert.ToString(dr["Calisan_Soyadi"]);
                id = Convert.ToInt32(dr["Calisan_id"]);
                comboBoxSorumlu.Items.Add(ad + "(" + id + ")");

            }
            baglanti.Close();//bağlantı kapatıldı
            komut.CommandText = "SELECT *FROM Anlasma";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            //başka bir comboboxa Anlasma verileri yazıldı 
            baglanti.Open();
            dr = komut.ExecuteReader();


            while (dr.Read())
            {
                ad = Convert.ToString(dr["Anlasma_Isteyen"]);
                id = Convert.ToInt32(dr["Anlasma_Id"]);
                comboBoxAnlasma.Items.Add(ad + "(" + id + ")");

            }
            baglanti.Close();

            // Yemekler için sırayla ıd üretmek için arkada data base çalıştırılıp satır sayısının bir fazlası alındı ve labele yazıldı
            baglanti.Open();// bağlantı açıldı
            string yemekekleid = null;
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Yemekler", baglanti);
            ds2.Clear();
            da2.Fill(ds2, "Yemekler");
            yemekekleid = ds2.Tables["Yemekler"].Rows.Count.ToString();
            yemekekleid = Convert.ToString(Convert.ToInt32(yemekekleid) + 1);
            labelId.Text = yemekekleid;
            baglanti.Close();
        }

        // KAydet butonu fonksiyonu(actionu)
        private void btnSave_Click(object sender, EventArgs e)
        {
            // yemekler tablosuna veriler yazıldı ve kaydedildi
            baglanti.Open();//bağlantı açıldı

            SqlCommand komut = new SqlCommand("insert into Yemekler (Yemek_Id,Yemek_Adi,Yemek_Gonderilecek_İd,Yemek_Sorumlu,Yemek_Durum) values ('" + labelId.Text + "','" + textBoxAd.Text + "','" + IdBulucu(comboBoxAnlasma.Text) + "','" + IdBulucu(comboBoxSorumlu.Text) +  "')", baglanti);
            komut.ExecuteNonQuery();
            // başka bağlantı açılıp yemekler tablosundaki eksik kalan veriler tamamlandı.
            string kayit2 = "update Yemekler set Yemek_Sorumlu_Tel=@Yemek_Sorumlu_Tel, Yemek_Tarih=@Yemek_Tarih where Yemek_Id='" + labelId.Text + "'";
            SqlCommand komut2 = new SqlCommand(kayit2, baglanti);
           
            // Calisanlar tablosundaki istenile caliisan bulunarak calisan bilgilerine ulasildi 
            SqlCommand komut3 = new SqlCommand();
            komut3.CommandText = "SELECT *FROM Calisan WHERE Calisan_id='"+IdBulucu(comboBoxSorumlu.Text)+"'";
            komut3.Connection = baglanti;
            komut3.CommandType = CommandType.Text;

            SqlDataReader da;
            
            da = komut3.ExecuteReader();
            if (da.Read())
            {
                 
                komut2.Parameters.AddWithValue("@Yemek_Sorumlu_Tel", Convert.ToString(da["Calisan_İletisim_Tel"]));
                


            }
            komut3.CommandText = "SELECT *FROM Anlasma WHERE Anlasma_Id='" + IdBulucu(comboBoxAnlasma.Text) + "'";
            komut3.Connection = baglanti;
            komut3.CommandType = CommandType.Text;

            SqlDataReader da2;
            
            da2 = komut3.ExecuteReader();
            if (da2.Read())
            {

                komut2.Parameters.AddWithValue("@Yemek_Tarih", (Convert.ToDateTime(da2["Anlasma_Tarih"])).ToShortDateString());



            }
            
            komut2.ExecuteNonQuery();
            // eklendiği bilgi verildi
            MessageBox.Show("Bir Yeni Calışan Başarıyla Eklendi.");

            // verilerin tablosu güncellendi
            FrmAna f1 = (FrmAna)Application.OpenForms["Form2"];
            
            SqlDataAdapter yemek_listele = new SqlDataAdapter("SELECT Yemek_Id AS [ID],Yemek_Adi AS [YEMEK İSMİ],Yemek_Gonderilecek_İd AS [ANLAŞMA KODU],Yemek_Tarih [TARİH],Yemek_Sorumlu_Tel AS [SORUMLU TEL],Yemek_Durum AS [DURUM] FROM Yemekler ORDER BY Yemek_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            yemek_listele.Fill(dshafiza);
            f1.dataGridViewYemek.DataSource = dshafiza.Tables[0];

            baglanti.Close();
            this.Close();
        }
    }
}
