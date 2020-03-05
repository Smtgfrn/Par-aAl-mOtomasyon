using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ParçaAlımOtomasyonu
{
    public partial class adminGiriş : DevExpress.XtraEditors.XtraForm
    {
        public adminGiriş()
        {
            InitializeComponent();
            txtŞifre.PasswordChar = '*';
            txtKullanıcıAdı.MaxLength = 30;
            txtŞifre.MaxLength = 30;

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-57A1L0H;Initial Catalog=YazılımSınamaProje;Integrated Security=True");
        private void btnAnaMenü_Click(object sender, EventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            this.Hide();
            anaForm.Show();
        }

        private void adminGiriş_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            if(anaForm.Visible==false)
            {
                Application.Exit();
            }
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * From Kullanıcılar", baglanti);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                if (int.Parse(dr["KullanıcıTipid"].ToString()) == 1)
                {
                    dr.Close();
                    string komut = "Select * from Kullanıcılar where KullanıcıAdı = '" + txtKullanıcıAdı.Text + "'and Şifre ='" + txtŞifre.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(komut, baglanti);
                    DataTable tablo = new DataTable();
                    sda.Fill(tablo);
                    if (tablo.Rows.Count == 1)
                    {
                        AdminPanel adminForm = new AdminPanel();
                        this.Hide();
                        adminForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adınızı veya şifrenizi hatalı girdiniz");
                    }
                    break;
                }
                else
                {
                    MessageBox.Show("Lütfen Admin Hesabıyla Giriş Yapınız!");
                }

            }
            baglanti.Close();
        }
    }
}

namespace ParçaAlımOtomasyonu.Ana_Formlar
{
    public class AdminControl
    {
        public string KullanıcıAdı;
        public string Sifre;
        public AdminControl(string kullanıcıAdı,string sifre)
        {
            KullanıcıAdı = kullanıcıAdı;
            Sifre = sifre;
        }
    }
}