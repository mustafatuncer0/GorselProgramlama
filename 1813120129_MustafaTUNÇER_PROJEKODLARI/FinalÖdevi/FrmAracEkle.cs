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
    public partial class FrmAracEkle : Form
    {
        public FrmAracEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");

        //ekle form load  actionu
        private void FrmAracEkle_Load(object sender, EventArgs e)
        {
            
            // arac gerec tablosundaki veriler sayılıp bir fazlası alınarak ıd oluşturuldu
            baglanti.Open();
            string Aracekleid = null;
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Arac_Gerec", baglanti);
            ds2.Clear();
            da2.Fill(ds2, "Arac_Gerec");
            Aracekleid = ds2.Tables["Arac_Gerec"].Rows.Count.ToString();
            Aracekleid = Convert.ToString(Convert.ToInt32(Aracekleid) + 1);

            labelId.Text = Aracekleid;
            if (labelId.Text == "")
            {
                labelId.Text = "0";
            }
            baglanti.Close();
        }

        //kaydet butonu ationu
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //arac gerec tablosuna bağlanarak veriler güncel veya direk formdan alındı ıd ise fomun loginde bulduğumuz ıd kullanıldı
            SqlCommand komut = new SqlCommand("insert into Arac_Gerec (Arac_Id,Arac_Adi,Arac_Durumu,Arac_Adedi) values ('" + labelId.Text + "','" + textBoxAd.Text + "','" + comboBoxDurum.Text + "','" + comboBoxAdet.Text + "')", baglanti);
            komut.ExecuteNonQuery();


            baglanti.Close();

            //Kullanıcıya bilgi verildi ve fomrdaki veriler güncellendi
            MessageBox.Show("Bir Arac Başarıyla Eklendi.");
            FrmAna f1 = (FrmAna)Application.OpenForms["FrmAna"];
            baglanti.Open();
            SqlDataAdapter Arac_listele = new SqlDataAdapter("SELECT Anlasma_Id AS [İD],Anlasma_Isteyen AS [FİRMA ADI],Anlasma_Yemekler AS [İSTENİLENLER],Anlasma_Iletisim_Tel AS [TELEFON],Anlasma_Tarih AS [TARİH],Anlasma_Miktar AS [MİKTAR] FROM Anlasma WHERE Anlasma_Durum=1 ORDER BY Anlasma_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            Arac_listele.Fill(dshafiza);
            f1.dataGridViewArac.DataSource = dshafiza.Tables[0];

            baglanti.Close();
            this.Close();
        }
    }
}
