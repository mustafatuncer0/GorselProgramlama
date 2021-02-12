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
    public partial class FrmAnlasmaEkle : Form
    {
        public FrmAnlasmaEkle()
        {
            InitializeComponent();
        }
        //ıd bulucu actionu belirlienyor 
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
        //bağlantı satırı yazılıyor 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");

        //form başlatılmada gerçekleşilecek action
        private void FrmAnlasmaEkle_Load(object sender, EventArgs e)
        {
            // maas başlangıc verisi yazılıyor ve anlaşma tablolarına eklemek için ıd oluştuurluyor
            maskedTextBoxMaas.Text = "000000  ₺ (tl)";
            dateTimePickerTarih.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            baglanti.Open();
            string calisanekleid = null;
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Anlasma", baglanti);
            ds2.Clear();
            da2.Fill(ds2, "Anlasma");
            calisanekleid = ds2.Tables["Anlasma"].Rows.Count.ToString();
            calisanekleid = Convert.ToString(Convert.ToInt32(calisanekleid) + 1);
            labelId.Text = calisanekleid;
            baglanti.Close();
        }


        // maskedTextBoxMaas basıldığında imleci başa alma işlemi
        private void maskedTextBoxMaas_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxMaas.SelectionStart
    = maskedTextBoxMaas.MaskedTextProvider.LastAssignedPosition + 1;
            maskedTextBoxMaas.SelectionLength = 0;
        }

        //iptal buton actionu
        private void btnExit_Click(object sender, EventArgs e)
        {
            // form kapatma işlemi
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            // databaseye verileri eklemek için gerekli formlara bağlanılıp veriler çekiliyor ardından veirler kaydediliyor
            SqlCommand komut = new SqlCommand("insert into Anlasma (Anlasma_Id,Anlasma_Isteyen,Anlasma_Il,Anlasma_Ilce,Anlasma_Iletisim_Tel,Anlasma_Tarih,Anlasma_Fiyat,Anlasma_Yemekler,Anlasma_Adress,Anlasma_Miktar,Anlasma_Durum) values ('" + labelId.Text + "','" + textBoxFirmaAdi.Text + "','" + textBoxIl.Text + "','" + textBoxIlce.Text + "','"  + IdBulucu(maskedTextBoxTel.Text.Substring(1)) + "','" + dateTimePickerTarih.Value.ToShortDateString() + "','"+ IdBulucu(maskedTextBoxMaas.Text) + "','" + richtextBoxYemekList.Text +"','" + richtextBoxAdres.Text + "','" + maskedTextBoxFiyat.Text+ "','" + "True" +"')", baglanti);
            komut.ExecuteNonQuery();

           
            baglanti.Close();
            MessageBox.Show("Bir Yeni Anlaşma Başarıyla Eklendi.");
            FrmAna f1 = (FrmAna)Application.OpenForms["FrmAna"];
            baglanti.Open();
            SqlDataAdapter calisan_listele = new SqlDataAdapter("SELECT Anlasma_Id AS [İD],Anlasma_Isteyen AS [FİRMA ADI],Anlasma_Yemekler AS [İSTENİLENLER],Anlasma_Iletisim_Tel AS [TELEFON],Anlasma_Tarih AS [TARİH],Anlasma_Miktar AS [MİKTAR] FROM Anlasma WHERE Anlasma_Durum=1 ORDER BY Anlasma_Tarih ASC", baglanti);
            DataSet dshafiza = new DataSet();
            calisan_listele.Fill(dshafiza);
            f1.dataGridViewAnlasmalar.DataSource = dshafiza.Tables[0];

            baglanti.Close();
            this.Close();

        }

        //imleci başa alma işlemi
        private void maskedTextBoxFiyat_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxFiyat.SelectionStart
    = maskedTextBoxFiyat.MaskedTextProvider.LastAssignedPosition + 1;
            maskedTextBoxFiyat.SelectionLength = 0;
        }
    }
}
