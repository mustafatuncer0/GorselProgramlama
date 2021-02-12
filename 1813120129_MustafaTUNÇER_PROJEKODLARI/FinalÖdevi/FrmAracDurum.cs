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
    public partial class FrmAracDurum : Form
    {
        public FrmAracDurum()
        {
            InitializeComponent();
        }
        //bağlantı actionu gösterildi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");

        // ıd loda da labelde göserildi
        private void FrmAracDurum_Load(object sender, EventArgs e)
        {
            labelId.Text = FrmAna.aracid;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {//seçilen checkboxa göre durum değiştirldi labellerle aynı olacak şekilde
            if (checkBoxEksik.Checked==true ) {
                string kayit2 = "update Arac_Gerec set Arac_Durumu=@Arac_Durumu where Arac_Id='" + labelId.Text + "'";
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand(kayit2, baglanti);
                komut2.Parameters.AddWithValue("@Arac_Durumu",checkBoxEksik.Text );


                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            if (checkBoxTam.Checked == true)
            {
                string kayit2 = "update Arac_Gerec set Arac_Durumu=@Arac_Durumu where Arac_Id='" + labelId.Text + "'";
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand(kayit2, baglanti);
                komut2.Parameters.AddWithValue("@Arac_Durumu", checkBoxTam.Text);


                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            if (checkBoxYok.Checked == true)
            {
                string kayit2 = "update Arac_Gerec set Arac_Durumu=@Arac_Durumu where Arac_Id='" + labelId.Text + "'";
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand(kayit2, baglanti);
                komut2.Parameters.AddWithValue("@Arac_Durumu", checkBoxYok.Text);


                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            
        }

        private void checkBoxEksik_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxTam.Checked =false;
            checkBoxYok.Checked = false;
        }

        private void checkBoxTam_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxEksik.Checked = false;
            checkBoxYok.Checked = false;
        }

        private void checkBoxYok_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxEksik.Checked = false;
            checkBoxTam.Checked = false;
        }

       
    }
}
