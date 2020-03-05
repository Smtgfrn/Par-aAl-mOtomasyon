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
    public partial class birimYetkiliGiriş : DevExpress.XtraEditors.XtraForm
    {
        public birimYetkiliGiriş()
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

        private void birimYetkiliGiriş_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            if (anaForm.Visible == false)
            {
                Application.Exit();
            }
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (cmbBölüm.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Bölüm Seçiniz");
            }
            else if (cmbBölüm.SelectedIndex == 0)
            {
                string komut = "Select * from Kullanıcılar where KullanıcıAdı = '" + txtKullanıcıAdı.Text + "'and Şifre ='" + txtŞifre.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(komut, baglanti);
                DataTable tablo = new DataTable();
                sda.Fill(tablo);
                if (tablo.Rows.Count == 1)
                {
                    pazarlamaListele pl = new pazarlamaListele();
                    this.Hide();
                    pl.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı veya şifrenizi hatalı girdiniz");
                }
            }
            else if (cmbBölüm.SelectedIndex == 1)
            {
                string komut = "Select * from Kullanıcılar where KullanıcıAdı = '" + txtKullanıcıAdı.Text + "'and Şifre ='" + txtŞifre.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(komut, baglanti);
                DataTable tablo = new DataTable();
                sda.Fill(tablo);
                if (tablo.Rows.Count == 1)
                {
                    muhasebeListele ml = new muhasebeListele();
                    this.Hide();
                    ml.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı veya şifrenizi hatalı girdiniz");
                }

            }
            else if (cmbBölüm.SelectedIndex == 2)
            {
                string komut = "Select * from Kullanıcılar where KullanıcıAdı = '" + txtKullanıcıAdı.Text + "'and Şifre ='" + txtŞifre.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(komut, baglanti);
                DataTable tablo = new DataTable();
                sda.Fill(tablo);
                if (tablo.Rows.Count == 1)
                {
                    insanKaynaklarıListele il = new insanKaynaklarıListele();
                    this.Hide();
                    il.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı veya şifrenizi hatalı girdiniz");
                }
            }
            else if (cmbBölüm.SelectedIndex == 3)
            {
                string komut = "Select * from Kullanıcılar where KullanıcıAdı = '" + txtKullanıcıAdı.Text + "'and Şifre ='" + txtŞifre.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(komut, baglanti);
                DataTable tablo = new DataTable();
                sda.Fill(tablo);
                if (tablo.Rows.Count == 1)
                {
                    üretimListele ül = new üretimListele();
                    this.Hide();
                    ül.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı veya şifrenizi hatalı girdiniz");
                }
            }
        }
    }
}

namespace ParçaAlımOtomasyonu.Ana_Formlar
{
    public class BirimYetkiliControl
    {
        private string kullanıcıAdı;
        private string şifre;
        private int bölüm;

        public BirimYetkiliControl(string kullanıcıAdı, string şifre, int bölüm)
        {
            this.kullanıcıAdı = kullanıcıAdı;
            this.şifre = şifre;
            this.bölüm = bölüm;
            
        }
    }
}