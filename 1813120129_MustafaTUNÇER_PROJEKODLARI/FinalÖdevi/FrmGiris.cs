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

namespace FinalÖdevi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        //bağlantı cümlesi yapıldı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");
        
        // giris buton ationu tanımlandı
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //hata verme ihtimaline karşın try catch yapısı kullanıldı
            try { 
                baglanti.Open();
                string GirisCikisekleid = null;
                //Giriş çıkış yapılabilmesi için bütün veriler toplanıp data base içersinde ıd oluşturulup sonrasında ıd ye göre
                // işlem yapılmak suratiyle verileri data baseye kaydedildi (girş için)
                DataSet ds2 = new DataSet();
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM GirisCikis", baglanti);
                ds2.Clear();
                da2.Fill(ds2, "GirisCikis");
                GirisCikisekleid = ds2.Tables["GirisCikis"].Rows.Count.ToString();
                GirisCikisekleid = Convert.ToString(Convert.ToInt32(GirisCikisekleid) + 1);
            string durum = "Giriş";
                SqlCommand komut = new SqlCommand("insert into GirisCikis (Giris_Id,Giris_Yapan_Id,Giris_Durum) values ('" + GirisCikisekleid + "','" + textBoxId.Text+ "','" + durum + "')", baglanti);
                komut.ExecuteNonQuery();

                string kayit2 = "update GirisCikis set Giris_Ad=@Giris_Ad,Giris_Soyad=@Giris_Soyad,Giris_Tarih=@Giris_Tarih  where Giris_Id='" + GirisCikisekleid + "'";
                SqlCommand komut2 = new SqlCommand(kayit2, baglanti);

                SqlCommand komut3 = new SqlCommand();

                
                komut3.Connection = baglanti;
            string tarih = Convert.ToString(DateTime.Now);

            komut3.CommandText = "SELECT *FROM Calisan WHERE Calisan_id='" + textBoxId.Text + "'";
                SqlDataReader readd = komut3.ExecuteReader();
                if (readd.Read())
                {
                
                    komut2.Parameters.AddWithValue("@Giris_Ad", readd["Calisan_Adi"].ToString());
                    komut2.Parameters.AddWithValue("@Giris_Soyad", readd["Calisan_Soyadi"].ToString());
                    komut2.Parameters.AddWithValue("@Giris_Tarih", DateTime.Parse(tarih));

                
            }
                

                readd.Close();
            komut2.ExecuteNonQuery();


            baglanti.Close();

            baglanti.Open();





            FrmAna f1 = (FrmAna)Application.OpenForms["FrmAna"];

            SqlDataAdapter Giris_listele = new SqlDataAdapter("SELECT Giris_Id AS [ID], Giris_Ad AS [GİRİŞ İSMİ],Giris_Soyad AS [GİRİŞ SOYİSMİ],Giris_Yapan_Id [GİRİŞ YAPAM ID],Giris_Tarih [TARİH] FROM GirisCikis ORDER BY Giris_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            Giris_listele.Fill(dshafiza);
            f1.dataGridViewGiris.DataSource = dshafiza.Tables[0];

            baglanti.Close();
            this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Id Kontrol Ederek Tekrar Deneyin");
            }




        }

        private void btnCikis_Click(object sender, EventArgs e)
        {//Giriş çıkış yapılabilmesi için bütün veriler toplanıp data base içersinde ıd oluşturulup sonrasında ıd ye göre
         // işlem yapılmak suratiyle verileri data baseye kaydedildi (çıkış için)
            try
            {
                baglanti.Open();
                string GirisCikisekleid = null;

                DataSet ds2 = new DataSet();
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM GirisCikis", baglanti);
                ds2.Clear();
                da2.Fill(ds2, "GirisCikis");
                GirisCikisekleid = ds2.Tables["GirisCikis"].Rows.Count.ToString();
                GirisCikisekleid = Convert.ToString(Convert.ToInt32(GirisCikisekleid) + 1);
                string durum = "Çıkış";
                SqlCommand komut = new SqlCommand("insert into GirisCikis (Giris_Id,Giris_Yapan_Id,Giris_Durum) values ('" + GirisCikisekleid + "','" + textBoxId.Text + "','" + durum + "')", baglanti);
                komut.ExecuteNonQuery();

                string kayit2 = "update GirisCikis set Giris_Ad=@Giris_Ad,Giris_Soyad=@Giris_Soyad,Giris_Tarih=@Giris_Tarih  where Giris_Id='" + GirisCikisekleid + "'";
                SqlCommand komut2 = new SqlCommand(kayit2, baglanti);

                SqlCommand komut3 = new SqlCommand();


                komut3.Connection = baglanti;
                string tarih = Convert.ToString(DateTime.Now);

                komut3.CommandText = "SELECT *FROM Calisan WHERE Calisan_id='" + textBoxId.Text + "'";
                SqlDataReader readd = komut3.ExecuteReader();
                if (readd.Read())
                {

                    komut2.Parameters.AddWithValue("@Giris_Ad", readd["Calisan_Adi"].ToString());
                    komut2.Parameters.AddWithValue("@Giris_Soyad", readd["Calisan_Soyadi"].ToString());
                    komut2.Parameters.AddWithValue("@Giris_Tarih", DateTime.Parse(tarih));


                }


                readd.Close();
                komut2.ExecuteNonQuery();


                baglanti.Close();

                baglanti.Open();





                FrmAna f1 = (FrmAna)Application.OpenForms["FrmAna"];

                SqlDataAdapter Giris_listele = new SqlDataAdapter("SELECT Giris_Id AS [ID], Giris_Ad AS [GİRİŞ İSMİ],Giris_Soyad AS [GİRİŞ SOYİSMİ],Giris_Yapan_Id [GİRİŞ YAPAM ID],Giris_Tarih [TARİH] FROM GirisCikis ORDER BY Giris_Tarih ASC", baglanti);
                DataSet dshafiza = new DataSet();
                Giris_listele.Fill(dshafiza);
                f1.dataGridViewGiris.DataSource = dshafiza.Tables[0];

                baglanti.Close();
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Id Kontrol Ederek Tekrar Deneyin");

            }
        }
    }
}
