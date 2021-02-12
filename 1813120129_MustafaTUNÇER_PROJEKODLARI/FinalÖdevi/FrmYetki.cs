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
    public partial class FrmYetki : Form
    {
        public FrmYetki()
        {
            InitializeComponent();
        }
        //bağlantı commenti yazıldı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");
        
        // Id bulucu fonksiyon tanımlandı
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

        // yetki formunun yüklenirken yapılması gereken işlemler tanımlandı
        private void FrmYetki_Load(object sender, EventArgs e)
        {

            //calisan verileri çekilip combo boxa eklendi
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
            baglanti.Close();
            // yetkilinin ıd si ve yetki tanımı comboboxa eklendi

            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = "SELECT *FROM Yetki";
            komut1.Connection = baglanti;
            komut1.CommandType = CommandType.Text;

            SqlDataReader dr2;
            baglanti.Open();
            dr2 = komut1.ExecuteReader();

            string yetkiad;
            
            
            while (dr2.Read())
            {
                yetkiad = Convert.ToString(dr2["Yetki_Tanım"]);
                
                id = Convert.ToInt32(dr2["Yetki_id"]);
                comboBoxYetki.Items.Add(yetkiad + "(" + id + ")");

            }
            baglanti.Close();
        }
        // Ekle butonu actionu
        private void btnEkle_Click(object sender, EventArgs e)
        {   //yetkiliye Şifre oluşturmak için  şifreler tablosunun satır sayısı ile Id hesaplanıyor   
            baglanti.Open();
            string sifreekleid = null;
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Sifreler", baglanti);
            ds2.Clear();
            da2.Fill(ds2, "Sifreler");
            sifreekleid = ds2.Tables["Sifreler"].Rows.Count.ToString();
            sifreekleid = Convert.ToString(Convert.ToInt32(sifreekleid) + 1);
            string calisanid = IdBulucu(comboBoxSorumlu.Text);
                        
            
            //Sifreler tablosuna değerler ekleniyor ve calisanlar tablosunda sifre ıd deiştirilip id tanımlaması bitiriliyor
            SqlCommand komut = new SqlCommand("insert into Sifreler (Sifreİd,Calisan_id,Kullanici_Adi,Sifre) values ('" + sifreekleid + "','" + calisanid + "','" + textBoxKAdi.Text + "','" + textBoxSifre.Text + "')", baglanti);
            komut.ExecuteNonQuery();
           
            string kayit = "update Calisan set Sifreİd=@Sifreİd , Calisan_Yetki=@Calisan_Yetki where Calisan_id='" + calisanid + "'";

            komut.Parameters.AddWithValue("@Sifreİd", sifreekleid);
            komut.Parameters.AddWithValue("@Calisan_Yetki ", comboBoxYetki.Text);
            komut.ExecuteNonQuery();
            //Çalışanlar tablosuna yetki şifre id
            //şifre tablosuna kullanıcı adı ve şifre ve şifre id calisan id 
            baglanti.Close();
        }
    }
}
