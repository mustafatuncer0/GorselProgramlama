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
    public partial class FrmKlnDty : Form
    {
        public FrmKlnDty()
        {
            InitializeComponent();
        }
        // sec actionu tanımlanıyor
        private void sec(string deger) {
            int Item_sayisi=(Convert.ToInt32( comboBoxKanGrub.Items.Count.ToString()))-1;
            while (Item_sayisi>-1) {

                if (deger == comboBoxKanGrub.Items[Item_sayisi].ToString())
                {
                    comboBoxKanGrub.SelectedIndex = Item_sayisi;
                    comboBoxKanGrub.SelectedValue = comboBoxKanGrub.Items[Item_sayisi].ToString();
                }


                Item_sayisi--;
            }
        
        
        }
        // secip ayıklayacak action tanımlanıyor
        private void ayir_sec(string deger ,ComboBox combobox) {

            int Item_sayisi = (Convert.ToInt32(combobox.Items.Count.ToString())) - 1;
            while (Item_sayisi > -1)
            {

                if (deger == IdBulucu(combobox.Items[Item_sayisi].ToString()))
                {
                    combobox.Text = combobox.Items[Item_sayisi].ToString();
                }


                Item_sayisi--;

            }


        }

        // ıd bulucu tanımlanıyor
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

        // baglantı cümlesi yazılıyor
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");
        static string maas;
        static string maas_id = null;

        // Formun yüklenirken yapılan işlemler tanımlanıyor
        private void FrmKlnDty_Load(object sender, EventArgs e)
        {
            //combo boxa bolum bilgisi ve id yazılıyor
            labelId.Text = FrmAna.id;
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
            
            
            // departman comboboxuna departman bilgileri ve id yazılıyor

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

            //  seçilen tablodaki veriye göre ıd  kullanılıp o calışanın verileri gösterilmek üzere data baseden okunuyor
            komut.CommandText = "SELECT *FROM Calisan WHERE Calisan_id='"+labelId.Text+"'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            baglanti.Open();
            dr = komut.ExecuteReader();
            
            if (dr.Read())
            {
                textBoxAd.Text = Convert.ToString(dr["Calisan_Adi"]);
                textBoxSoyad.Text = Convert.ToString(dr["Calisan_Soyadi"]);
                textBoxTc.Text = Convert.ToString(dr["Calisan_Tc_Kimlik"]);
                sec(Convert.ToString(dr["Calisan_KanGrub"]));
                maskedTextBoxTel.Text = "0" + Convert.ToString(dr["Calisan_İletisim_Tel"]);

                _ = (Convert.ToString(dr["Calisan_Cinsiyet"]) == "E") ? comboBoxCinsiyet.SelectedIndex = 0 : comboBoxCinsiyet.SelectedIndex = 1;

                dateTimePickerTarih.Value = Convert.ToDateTime(dr["Calisan_İse_Giris_Tarihi"]);
                richTextBoxAdres.Text=Convert.ToString(dr["Calisan_Adress"]);
                ayir_sec(Convert.ToString(dr["Calisan_Bolum_id"]), comboBoxBolum);
                ayir_sec(Convert.ToString(dr["Calisan_Departman_id"]), comboBoxDepartman);

                maas_id= Convert.ToString(dr["Calisan_maas_id"]); 

            }
            baglanti.Close();


            // maas gösterilmek üzere maaslar tablosuna gidilip baştaki  sıfır sayıları atılıyor
            komut.CommandText = "SELECT *FROM Maas WHERE Maas_id='"+maas_id+"'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            baglanti.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                maas = Convert.ToString(dr["Yeni_Maas"]);
                int sifir_sayisi = 6-(maas.Length);
                while ( sifir_sayisi>0)
                {
                    maas = "0" + maas;
                    sifir_sayisi--;

                }
                maskedTextBoxMaas.Text = maas;


            }
            baglanti.Close();

        }
         
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //iptal butonu actionunda form kapatıldı
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //kaydet butonuna clik özelliği tanımlandı ve özellikleri yazıldı
        private void btnSave_Click(object sender, EventArgs e)
        {
            // calisanlar tablosundaki cloumnların data base tarafından istenilen türe dönüşümü sağlandı ve değiiştirildi 
            baglanti.Open();
            string kayit = "update Calisan set Calisan_Adi=@Calisan_Adi,Calisan_Soyadi=@Calisan_Soyadi,Calisan_Tc_Kimlik=@Calisan_Tc_Kimlik,Calisan_KanGrub=@Calisan_KanGrub ,Calisan_Departman_id=@Calisan_Departman_id ,Calisan_Bolum_id=@Calisan_Bolum_id,Calisan_Cinsiyet=@Calisan_Cinsiyet,Calisan_İletisim_Tel=@Calisan_İletisim_Tel,Calisan_İse_Giris_Tarihi=@Calisan_İse_Giris_Tarihi,Calisan_maas_id=@Calisan_maas_id ,Calisan_Adress=@Calisan_Adress where Calisan_id='"+labelId.Text+"'";
            
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            
            komut.Parameters.AddWithValue("@Calisan_Adi", textBoxAd.Text);
            komut.Parameters.AddWithValue("@Calisan_Soyadi ", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@Calisan_Tc_Kimlik", textBoxTc.Text);
            komut.Parameters.AddWithValue("@Calisan_KanGrub", comboBoxKanGrub.Text);
            komut.Parameters.AddWithValue("@Calisan_Departman_id", IdBulucu(comboBoxDepartman.Text));
            komut.Parameters.AddWithValue("@Calisan_Bolum_id", IdBulucu(comboBoxBolum.Text)); 
            komut.Parameters.AddWithValue("@Calisan_Cinsiyet", comboBoxCinsiyet.Text.Substring(0, 1).ToUpper());
            komut.Parameters.AddWithValue("@Calisan_İletisim_Tel", IdBulucu(maskedTextBoxTel.Text.Substring(1)));
            komut.Parameters.AddWithValue("@Calisan_İse_Giris_Tarihi", dateTimePickerTarih.Value.ToShortDateString());
            //maas masked text kutusunun eski maaş değeri ile aynı olup olmadığı kontrol edildi
            if (maskedTextBoxMaas.Text != maas + "  ₺ (tl)")
            {
                // eğer farklıysa yeni bir maas id oluşturuldu e değer DB'e kaydedildi
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
                komut.Parameters.AddWithValue("@Calisan_maas_id", maas_id);


            }
            else {
                //eğer aynıysa değiştirlmedi.
                komut.Parameters.AddWithValue("@Calisan_maas_id", maas_id);
            }
             komut.Parameters.AddWithValue("@Calisan_Adress", richTextBoxAdres.Text);

            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            // ana formdaki veriler güncellendi
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");
            FrmAna f1 = (FrmAna)Application.OpenForms["FrmAna"];
            baglanti.Open();
            SqlDataAdapter calisan_listele = new SqlDataAdapter("SELECT Calisan_id AS [ID],Calisan_Adi AS[AD] , Calisan_Soyadi AS[SOYAD],Calisan_Bolum_id AS[BOLUM KODU],Calisan_İse_Giris_Tarihi AS[CALIŞAN BAŞLANGICI] FROM Calisan WHERE Calisan_Durum=1 ORDER BY Calisan_Adi ASC", baglanti);
            DataSet dshafiza = new DataSet();
            calisan_listele.Fill(dshafiza);
            f1.dataGridViewCalisanlar.DataSource = dshafiza.Tables[0];

            baglanti.Close();
        }
    }
}
