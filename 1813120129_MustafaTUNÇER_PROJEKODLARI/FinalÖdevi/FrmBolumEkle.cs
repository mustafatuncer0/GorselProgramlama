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
    public partial class FrmBolumEkle : Form
    {
        public FrmBolumEkle()
        {
            InitializeComponent();
        }
        //bağlantı satırı yazıldı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");


        private void btnEkle_Click(object sender, EventArgs e)
        {
            // veriler direk olarak verilen ve güncel olan tarih verileriyle oluşturuldu
            baglanti.Open();
           
            string bolumid = null;
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Bolumler", baglanti);
            ds2.Clear();
            da2.Fill(ds2, "Bolumler");
            bolumid = ds2.Tables["Bolumler"].Rows.Count.ToString();
            bolumid = Convert.ToString(Convert.ToInt32(bolumid) + 1);

            SqlCommand komut = new SqlCommand("insert into Bolumler (Bolum_İd,Bolum_Adı,Bolum_Bina_Konumu) values ('" + bolumid + "','" + textBoxAd.Text + "','"  + textBoxYer.Text + "')", baglanti); 
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bir Yeni Bolum Başarıyla Eklendi.");
            this.Close();

        }
    }
}
