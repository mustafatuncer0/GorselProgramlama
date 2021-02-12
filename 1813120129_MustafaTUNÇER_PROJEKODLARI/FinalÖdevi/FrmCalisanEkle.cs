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
    public partial class FrmCalisanEkle : Form
    {
        public FrmCalisanEkle()
        {
            InitializeComponent();
        }
        // ıd bulmayı kolaylaştırıcı fonksiyon yazıldı
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
        //bağlantı satırı tanımlandı
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");

        
        // Form yüklenme esnasındaki action
        private void FrmCalisanEkle_Load(object sender, EventArgs e)
        {

            // masked text boxa başlangıç değeri verildi
            maskedTextBoxMaas.Text = "000000  ₺ (tl)";
            // Bolum ve departman tablolarına bağlanarak istenilen veirler çekildi comboboxlara yazdırıldı , Çalışan eklemek  gerekli veriler ve ıd bulundu 

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Bolumler";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();

            string ad;
            int id;
            while (dr.Read())
            {
                ad = Convert.ToString(dr["Bolum_Adı"]);
                id = Convert.ToInt32(dr["Bolum_id"]);
                comboBoxBolum.Items.Add(ad + "(" + id + ")");

            }
            baglanti.Close();


            komut.CommandText = "SELECT *FROM Departmanlar";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;


            baglanti.Open();
            dr = komut.ExecuteReader();


            while (dr.Read())
            {
                ad = Convert.ToString(dr["Departman_Adi"]);
                id = Convert.ToInt32(dr["Departman_Id"]);
                comboBoxDepartman.Items.Add(ad + "(" + id + ")");

            }
            baglanti.Close();
            dateTimePickerTarih.Value= Convert.ToDateTime(DateTime.Now.ToShortDateString());

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;




            baglanti.Open();
            string calisanekleid = null;
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Calisan", baglanti);
            ds2.Clear();
            da2.Fill(ds2, "Calisan");
            calisanekleid = ds2.Tables["Calisan"].Rows.Count.ToString();
            calisanekleid = Convert.ToString(Convert.ToInt32(calisanekleid) + 1);
            labelId.Text = calisanekleid;
            baglanti.Close();
        }

        //kaydet butonu basıldığındaki action
        private void btnSave_Click(object sender, EventArgs e)
        {// maaslar tablosunda yeni maas verisi oluşturuldu ve tüm toplanan ve data base tablolarından çekilen veriler Calisan tablosuna eklendi
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Calisan (Calisan_İd,Calisan_Adi,Calisan_Soyadi,Calisan_Tc_Kimlik,Calisan_KanGrub,Calisan_Departman_id,Calisan_Bolum_id,Calisan_Cinsiyet,Calisan_İletisim_Tel,Calisan_İse_Giris_Tarihi,Calisan_Adress,Calisan_Durum) values ('" + labelId.Text + "','" + textBoxAd.Text + "','" + textBoxSoyad.Text + "','" + maskedTextBoxTc.Text + "','" + comboBoxKanGrub.Text + "','" + IdBulucu(comboBoxDepartman.Text) + "','" + IdBulucu(comboBoxBolum.Text) + "','" + comboBoxCinsiyet.Text.Substring(0, 1).ToUpper() + "','" + IdBulucu(maskedTextBoxTel.Text.Substring(1)) + "','" + dateTimePickerTarih.Value.ToShortDateString() + "','" + richTextBoxAdres.Text + "','" + "True"+"')", baglanti);
            komut.ExecuteNonQuery();

            {
                string kayit2 = "update Calisan set Calisan_maas_id=@Calisan_maas_id where Calisan_id='" + labelId.Text + "'";
                SqlCommand komut2 = new SqlCommand(kayit2, baglanti);

                SqlCommand cmd = new SqlCommand();
                        cmd.Connection = baglanti;



                        string maas_id, calisan_id, degisim_tarihi, yeni_maas;
                        maas_id = calisan_id = degisim_tarihi = yeni_maas = null;
                        DataSet ds2 = new DataSet();
                        SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Maas", baglanti);
                        ds2.Clear();
                        da2.Fill(ds2, "Maas");
                        maas_id = ds2.Tables["Maas"].Rows.Count.ToString();
                        maas_id = Convert.ToString(Convert.ToInt32(maas_id) + 1);
                        calisan_id = labelId.Text;
                        degisim_tarihi = DateTime.Now.ToShortDateString();
                        yeni_maas = IdBulucu(maskedTextBoxMaas.Text);
                        cmd.CommandText = "insert into Maas(Maas_id,Calisan_id,Degisim_Tarih,Yeni_Maas) VALUES('" + maas_id + "','" + calisan_id + "','" + degisim_tarihi + "','" + yeni_maas + "')";
                        cmd.ExecuteNonQuery();
                        komut2.Parameters.AddWithValue("@Calisan_maas_id", maas_id);
                        komut2.ExecuteNonQuery();

            }

            baglanti.Close();
            //kullanıcıya bilgi verildi ve ana fordaki veriler güncellendi
            MessageBox.Show("Bir Yeni Calışan Başarıyla Eklendi.");


            FrmAna f1 = (FrmAna)Application.OpenForms["FrmAna"];
            baglanti.Open();
            SqlDataAdapter calisan_listele = new SqlDataAdapter("SELECT Calisan_id AS [ID],Calisan_Adi AS[AD] , Calisan_Soyadi AS[SOYAD],Calisan_Bolum_id AS[BOLUM KODU],Calisan_İse_Giris_Tarihi AS[CALIŞAN BAŞLANGICI] FROM Calisan WHERE Calisan_Durum=1 ORDER BY Calisan_Adi ASC", baglanti);
            DataSet dshafiza = new DataSet();
            calisan_listele.Fill(dshafiza);
            f1.dataGridViewCalisanlar.DataSource = dshafiza.Tables[0];
            
            baglanti.Close();



        }

        //çıkış butonu actionu
        private void btnExit_Click(object sender, EventArgs e)
            {
            //form kapatıldı
                this.Hide();
            }
        
        // yeni ıd tanımlama(demo)
        private void buttonId_Click(object sender, EventArgs e)
        {

            maskedTextBoxYeniId.Text=labelId.Text;
            panel3.Visible = true;
            

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            labelId.Text = maskedTextBoxYeniId.Text;
            panel3.Visible = false;
        }

        private void maskedTextBoxTc_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxTc.SelectionStart
    = maskedTextBoxTc.MaskedTextProvider.LastAssignedPosition + 1;
            maskedTextBoxTc.SelectionLength = 0;
        }

        private void maskedTextBoxYeniId_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxYeniId.SelectionStart
                = maskedTextBoxYeniId.MaskedTextProvider.LastAssignedPosition + 1;
            maskedTextBoxYeniId.SelectionLength = 0;
        }

        private void maskedTextBoxMaas_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxMaas.SelectionStart
    = maskedTextBoxMaas.MaskedTextProvider.LastAssignedPosition + 1;
            maskedTextBoxMaas.SelectionLength = 0;
        }

      







      
    }
        }
   
  