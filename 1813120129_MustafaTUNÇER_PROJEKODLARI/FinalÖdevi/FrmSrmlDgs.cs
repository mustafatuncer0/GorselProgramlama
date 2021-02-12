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
using System.Text.RegularExpressions;

namespace FinalÖdevi
{
    public partial class FrmSrmlDgs : Form
    {
        public FrmSrmlDgs()
        {
            InitializeComponent();
        }
        //baglantı kuruluyor
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");
        
        //Id Bulucu fonksiyonu tanılanıyor (rahatça ıdleri bulabilmek için)
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
        //Form yüklenirken yapılacak işlemler
        private void FrmSrmlDgs_Load(object sender, EventArgs e)
        {
            // Calisan tablosundan veriler alınıp comboboxa ekleniyor
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
                comboBoxSorumlu.Items.Add(ad +" "+soyad+ "(" + id + ")");

            }
            baglanti.Close();

            //caslisanlar tablosundan belirtilen  Ana forumdan alınan sorulu id ye göre sorgu yapılıp verileri combobox ın tet ine yazılıyor  
            komut.CommandText = "SELECT *FROM Calisan WHERE Calisan_id='" + FrmAna.sorumlu + "'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            baglanti.Open();
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                ad = Convert.ToString(dr["Calisan_Adi"]);
                soyad= Convert.ToString(dr["Calisan_Soyadi"]);
                id=  Convert.ToInt32(dr["Calisan_id"]);
                comboBoxSorumlu.Text = ad + " " + soyad + "(" + id + ")";
            }

           
                baglanti.Close();
            dr.Close();
        }

        //Tamam butonu actionu
        private void btnOk_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // veri güncellemesi yapılmak üzere sogu yazılıyor
            string kayit = "update Yemekler set Yemek_Sorumlu=@Yemek_Sorumlu, Yemek_Sorumlu_Tel=@Yemek_Sorumlu_Tel where Yemek_Id='" + FrmAna.seciliid + "'";
            
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            // comboboxtaki ıd  bulunup yemekler tablosundaki sorumlu kısmına yazılıyor 
            komut.Parameters.AddWithValue("@Yemek_Sorumlu", IdBulucu(comboBoxSorumlu.Text));
            //eksik olan değerler tamamlanmak üzere diğer tablolardan veriler sorgulanıp tamamlanıyor
            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = "SELECT *FROM Calisan WHERE Calisan_id='" + IdBulucu(comboBoxSorumlu.Text) + "'";
            komut1.Connection = baglanti;
            komut1.CommandType = CommandType.Text;

            SqlDataReader dr1;
            
            dr1 = komut1.ExecuteReader();

            if (dr1.Read())
            {
                komut.Parameters.AddWithValue("@Yemek_Sorumlu_Tel ", Convert.ToString(dr1["Calisan_İletisim_Tel"]));
                
                    
                
            }
            dr1.Close();
            komut.ExecuteNonQuery();
            //güncellendiği bilgi verilip Ana formdaki veri tablosu güncelleniyor.
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");
            FrmAna f1 = (FrmAna)Application.OpenForms["FrmAna"];
            
            SqlDataAdapter yemeklistele = new SqlDataAdapter("SELECT Yemek_Id AS [ID],Yemek_Adi AS [YEMEK İSMİ],Yemek_Gonderilecek_İd AS [ANLAŞMA KODU],Yemek_Tarih [TARİH],Yemek_Sorumlu_Tel AS [SORUMLU TEL],Yemek_Durum AS [DURUM] FROM Yemekler ORDER BY Yemek_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            yemeklistele.Fill(dshafiza);
            f1.dataGridViewYemek.DataSource = dshafiza.Tables[0];
            baglanti.Close();
            //form kapatılıyor
            this.Close();

        }
            

            
    }
}
