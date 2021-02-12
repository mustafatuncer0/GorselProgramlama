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
    public partial class FrmDepartmanEkle : Form
    {
        public FrmDepartmanEkle()
        {
            InitializeComponent();
        }
        //bağlantı satırı yazıldı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Departman eklemek için verilen veri ve toplanan veriler data baseye yazıldı.ve execute edildi.
            baglanti.Open();

            string departmanid = null;
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Departmanlar", baglanti);
            ds2.Clear();
            da2.Fill(ds2, "Departmanlar");
            departmanid = ds2.Tables["Departmanlar"].Rows.Count.ToString();
            departmanid = Convert.ToString(Convert.ToInt32(departmanid) + 1);

            SqlCommand komut = new SqlCommand("insert into Departmanlar (Bolum_İd,Bolum_Adı,Bolum_Bina_Konumu) values ('" + departmanid + "','" + textBoxAd.Text   + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bir Yeni Calışan Başarıyla Eklendi.");
            this.Close();
        }

        
    }
}
