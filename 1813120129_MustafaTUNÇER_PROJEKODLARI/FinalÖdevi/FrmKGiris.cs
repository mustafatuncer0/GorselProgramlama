using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FinalÖdevi
{
    public partial class FrmKGiris : Form
    {
        public FrmKGiris()
        {
            InitializeComponent();
        }
        public static string gonderilecekveri;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OPPSKN6\\SQLEXPRESS;Initial Catalog=YemekFabrikasi_Otomasyonu;Integrated Security=True");

        // evenlere göre işlemler yapıldı (üzerine gelince holer efekti vb..)
        private void btncikis_MouseEnter(object sender, EventArgs e)
        {
            btncikis.ForeColor = Color.Red;
            
            btncikis.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            
        }

        private void btncikis_MouseLeave(object sender, EventArgs e)
        {
            btncikis.ForeColor = Color.White;
            
            btncikis.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        // alta alma tuşu tanımlandı ve içeriği yazıldı
        private void btnalt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // üzerine gelince yapılacak işlem tanımlandı
        private void btnalt_MouseEnter(object sender, EventArgs e)
        {// fore color değiştirildi
            btnalt.ForeColor = Color.LightBlue;
            btnalt.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

        }

        //taşıma  işlemi için özellikler yapıldı
        private void btnalt_MouseLeave(object sender, EventArgs e)
        {
            btnalt.ForeColor = Color.White;
            btnalt.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void FrmKGiris_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;


        }

        private void FrmKGiris_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void FrmKGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
            
        }

        //resim değiştirme işlemleri yapıldı
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.giris_yap_2;
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.giris_yap;

        }
        
        // giriş butonuna basıldığındaki işlemler yapıldı
               private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username" && textBox2.Text == "Password")
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
            }
            else  if (textBox1.Text == "Username" || textBox2.Text == "Password")
            {
                if (textBox1.Text == "Username")
                {
                    label3.Visible = true;
                    label4.Visible = false;
                    label5.Visible = false;
                }
                else if (textBox2.Text == "Password") {
                    label3.Visible = false;
                    label4.Visible = true;
                    label5.Visible = false;
                }

            }
            
            else {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                SqlCommand komut = new SqlCommand();
                
                baglanti.Open();
                komut.Connection = baglanti;
               
                
                komut.CommandText = "SELECT *FROM Sifreler where Kullanici_Adi='" + textBox1.Text + "'AND Sifre='" + textBox2.Text + "'";
                SqlDataReader read = komut.ExecuteReader();
                
                if (read.Read())
                {
                    gonderilecekveri = (read["Calisan_id"].ToString());
                    FrmAna pencere = new FrmAna();
                    pencere.Show();
                    this.Hide();



                }
                else
                {
                    label5.Visible = true;

                }
                baglanti.Close();
            }


        }

        //  kullanıcı adında Enter girişe basma  ataması yapıldı
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
                              

            }
        }
        // şifrede Enter girişe basma  ataması yapıldı
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());


            }

        }
        
        // boş olduğunda içerisne username value değeri atamsı yapıldı dolu iken ise silinmesi söylendi
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.DarkGray;
            }

            
            
        }

        //veri girişinde renk ayarlaması yapıldı
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        //formun yüklenmesi esnasında yapılacka işlemler tanımlandı
        //parola karakteri atandı Vb.
        private void FrmKGiris_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Text = "Username";


            textBox2.ForeColor = Color.DarkGray;
            textBox2.Text = "Password";
            textBox2.PasswordChar = Convert.ToChar(none);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }

        }
        char? none = null;
        //içerisinde şifre yazılıyor mu diiye kontrol ettirilip ona göre renk ayarlandı ve karakter none(karaktersiz) yapıldı 
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.DarkGray;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }
    }
}
