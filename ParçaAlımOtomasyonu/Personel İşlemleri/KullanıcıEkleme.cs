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
    public partial class KullanıcıEkleme : DevExpress.XtraEditors.XtraForm
    {
        public KullanıcıEkleme()
        {
            InitializeComponent();
            txtKullanıcıAdı.MaxLength = 20;
            txtSifre.MaxLength = 20;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-57A1L0H;Initial Catalog=YazılımSınamaProje;Integrated Security=True");
        private void KullanıcıEkleme_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Bölüm", baglanti);
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbBölüm.Items.Add(dr["bölüm"]);
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbBölüm.SelectedIndex == -1 || txtKullanıcıAdı.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş yer bırakmayınız");
            }
            else if(cmbBölüm.SelectedIndex==0)
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("INSERT INTO Kullanıcılar(KullanıcıTipid,KullanıcıAdı,Şifre) VALUES('"+1+"','"+txtKullanıcıAdı.Text+"','"+txtSifre.Text+"')", baglanti);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
                this.Hide();
            }
            else if(cmbBölüm.SelectedIndex==1)
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("INSERT INTO Kullanıcılar(KullanıcıTipid,KullanıcıAdı,Şifre) VALUES('" + 2 + "','" + txtKullanıcıAdı.Text + "','" + txtSifre.Text + "')", baglanti);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
                this.Hide();
            }
            else if(cmbBölüm.SelectedIndex==2)
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("INSERT INTO Kullanıcılar(KullanıcıTipid,KullanıcıAdı,Şifre) VALUES('" + 3 + "','" + txtKullanıcıAdı.Text + "','" + txtSifre.Text + "')", baglanti);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
                this.Hide();
            }
            else if (cmbBölüm.SelectedIndex == 3)
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("INSERT INTO Kullanıcılar(KullanıcıTipid,KullanıcıAdı,Şifre) VALUES('" + 4 + "','" + txtKullanıcıAdı.Text + "','" + txtSifre.Text + "')", baglanti);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
                this.Hide();
            }
            else if (cmbBölüm.SelectedIndex == 4)
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("INSERT INTO Kullanıcılar(KullanıcıTipid,KullanıcıAdı,Şifre) VALUES('" + 5 + "','" + txtKullanıcıAdı.Text + "','" + txtSifre.Text + "')", baglanti);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
                this.Hide();
            }
            else 
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("INSERT INTO Kullanıcılar(KullanıcıTipid,KullanıcıAdı,Şifre) VALUES('" + 6 + "','" + txtKullanıcıAdı.Text + "','" + txtSifre.Text + "')", baglanti);
                komut1.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
                this.Hide();
            }

        }
    }
}