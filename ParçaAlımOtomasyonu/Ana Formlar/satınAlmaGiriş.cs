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
    public partial class satınAlmaGiriş : DevExpress.XtraEditors.XtraForm
    {
        public satınAlmaGiriş()
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

        private void satınAlmaGiriş_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            if (anaForm.Visible == false)
            {
                Application.Exit();
            }
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            string komut = "Select * from Kullanıcılar where KullanıcıAdı = '" + txtKullanıcıAdı.Text + "'and Şifre ='" + txtŞifre.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(komut, baglanti);
            DataTable tablo = new DataTable();
            sda.Fill(tablo);
            if (tablo.Rows.Count == 1)
            {
                SatınAlmaPanel sap = new SatınAlmaPanel();
                this.Hide();
                sap.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı veya şifrenizi hatalı girdiniz");
            }
        }
    }
}

namespace ParçaAlımOtomasyonu.Ana_Formlar
{
    public class SatınAlmaControl
    {
        private string kullanıcıAdı;
        private string şifre;

        public SatınAlmaControl(string kullanıcıAdı, string şifre)
        {
            this.kullanıcıAdı = kullanıcıAdı;
            this.şifre = şifre;
        }
    }
}