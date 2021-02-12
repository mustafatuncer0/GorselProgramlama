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
    public partial class Form_ARA : Form
    {
        public Form_ARA()
        {
            InitializeComponent();
        }

        

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");
            FrmAna f1 = (FrmAna)Application.OpenForms["FrmAna"];
            try
            {
               

                switch (secim)
                {
                    
                case 1:
                        
                        baglanti.Open();
                        SqlDataAdapter calisan_listele = new SqlDataAdapter("SELECT Calisan_id AS [ID],Calisan_Adi AS[AD] , Calisan_Soyadi AS[SOYAD],Calisan_Bolum_id AS[BOLUM KODU],Calisan_İse_Giris_Tarihi AS[CALIŞAN BAŞLANGICI] FROM Calisan WHERE Calisan_id='"+ Convert.ToInt32(textBox1.Text) +"'", baglanti);
                        DataSet dshafiza = new DataSet();
                        calisan_listele.Fill(dshafiza);
                        f1.dataGridViewCalisanlar.DataSource = dshafiza.Tables[0];
                        textBox1.Text = null;
                        baglanti.Close();
                        break;

                    case 2:

                        baglanti.Open();
                        SqlDataAdapter calisan_listele1 = new SqlDataAdapter("SELECT Calisan_id AS [ID],Calisan_Adi AS[AD] , Calisan_Soyadi AS[SOYAD],Calisan_Bolum_id AS[BOLUM KODU],Calisan_İse_Giris_Tarihi AS[CALIŞAN BAŞLANGICI] FROM Calisan WHERE Calisan_Adi='" + Convert.ToString(textBox1.Text) + "'", baglanti);
                        DataSet dshafiza1 = new DataSet();
                        calisan_listele1.Fill(dshafiza1);
                        f1.dataGridViewCalisanlar.DataSource = dshafiza1.Tables[0];
                        textBox1.Text = null;
                        baglanti.Close();
                        break;

                    case 3:
                        
                        baglanti.Open();
                        SqlDataAdapter calisan_listele2 = new SqlDataAdapter("SELECT Calisan_id AS [ID],Calisan_Adi AS[AD] , Calisan_Soyadi AS[SOYAD],Calisan_Bolum_id AS[BOLUM KODU],Calisan_İse_Giris_Tarihi AS[CALIŞAN BAŞLANGICI] FROM Calisan WHERE Calisan_Soyadi='" + Convert.ToString(textBox1.Text) + "'", baglanti);
                        DataSet dshafiza2 = new DataSet();
                        calisan_listele2.Fill(dshafiza2);
                        f1.dataGridViewCalisanlar.DataSource = dshafiza2.Tables[0];
                        textBox1.Text = null;
                        baglanti.Close();
                        break;

                        
                case 4:
                        
                        baglanti.Open();
                        SqlDataAdapter calisan_listele3 = new SqlDataAdapter("SELECT Calisan_id AS [ID],Calisan_Adi AS[AD] , Calisan_Soyadi AS[SOYAD],Calisan_Bolum_id AS[BOLUM KODU],Calisan_İse_Giris_Tarihi AS[CALIŞAN BAŞLANGICI] FROM Calisan WHERE Calisan_Adi='" + Convert.ToString(textBox1.Text) + "' AND Calisan_Soyadi='" + Convert.ToString(textBoxSoyad.Text) + "'", baglanti);
                        DataSet dshafiza3 = new DataSet();
                        calisan_listele3.Fill(dshafiza3);
                        f1.dataGridViewCalisanlar.DataSource = dshafiza3.Tables[0];
                        textBox1.Text = null;
                        textBoxSoyad.Text = null;
                        baglanti.Close();
                        break;
                    



                }
            }
            catch
            {
                
                MessageBox.Show("Bir hata oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static byte secim = 0;
        private void radioButtonAd_CheckedChanged(object sender, EventArgs e)
        {
            labelId.Visible = false;
            labelAd.Visible = true;
            labelSoyad.Visible = false;
            labelSoyad2.Visible = false;
            flowLayoutPanel1.Visible = false;
            secim = 2;

        }

        private void radiobtnAra_CheckedChanged(object sender, EventArgs e)
        {
            labelId.Visible = true;
            labelAd.Visible = false;
            labelSoyad.Visible = false;
            labelSoyad2.Visible = false;
            flowLayoutPanel1.Visible = false;
            secim = 1;
        }

        private void radioButtonSoyad_CheckedChanged(object sender, EventArgs e)
        {
            labelId.Visible = false;
            labelAd.Visible = false;
            labelSoyad.Visible = true;
            labelSoyad2.Visible = false;
            flowLayoutPanel1.Visible = false;
            secim = 3;
        }

        private void radioButtonKisi_CheckedChanged(object sender, EventArgs e)
        {
            labelId.Visible = false;
            labelAd.Visible = true;
            labelSoyad.Visible = false;
            labelSoyad2.Visible = true;
            flowLayoutPanel1.Visible = true;
            secim = 4;
        }

        private void Form_ARA_Load(object sender, EventArgs e)
        {
            radiobtnAra.Checked = true;
            secim = 1;
        }
    }
}
