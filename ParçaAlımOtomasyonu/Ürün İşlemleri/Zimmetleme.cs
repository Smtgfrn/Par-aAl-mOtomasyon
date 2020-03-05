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
    public partial class Zimmetleme : DevExpress.XtraEditors.XtraForm
    {
        public Zimmetleme()
        {
            InitializeComponent();
            txtAdet.MaxLength = 5;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-57A1L0H;Initial Catalog=YazılımSınamaProje;Integrated Security=True");
        private void Zimmetleme_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter listele = new SqlDataAdapter("Select u.urunid, u.UrunAdı,u.Adet,u.UrunBirimFiyatı,k.KategoriAdı from Urunler u INNER JOIN Kategoriler k ON u.kategoriid=k.kategoriid", baglanti);
            DataSet dhafıza = new DataSet();
            listele.Fill(dhafıza);
            dgvUrunler.DataSource = dhafıza.Tables[0];
            baglanti.Close();
            baglanti.Open();
            SqlDataAdapter listele1 = new SqlDataAdapter("Select p.personelid,p.adı,p.soyadı,b.bölüm from Personeller p INNER JOIN Bölüm b ON p.bölümid=b.bölümid", baglanti);
            DataSet dhafıza1 = new DataSet();
            listele1.Fill(dhafıza1);
            dgvPersoneller.DataSource = dhafıza1.Tables[0];
            baglanti.Close();
        }

        private void btnDene_Click(object sender, EventArgs e)
        {
            
        }

        private void btnZimmetle_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {
                MessageBox.Show("Lütfen Adet Giriniz!");
            }
            else
            {
                int urunid = (int)dgvUrunler.CurrentRow.Cells["urunid"].Value;
                int personelid = (int)dgvPersoneller.CurrentRow.Cells["personelid"].Value;
                int adet = int.Parse(txtAdet.Text);
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Select * from Urunler where urunid =@urunid", baglanti);
                komut2.Parameters.AddWithValue("@urunid", urunid);
                SqlDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    if (int.Parse(dr["Adet"].ToString()) > adet)
                    {
                        dr.Close();
                        SqlCommand komut = new SqlCommand("INSERT INTO Zimmet(urunid,personelid,adet) VALUES('" + urunid + "','" + personelid + "','" + adet + "')", baglanti);
                        komut.ExecuteNonQuery();
                        SqlCommand komut1 = new SqlCommand("UPDATE Urunler SET Adet = Adet - @adet WHERE urunid = @urunid", baglanti);
                        komut1.Parameters.AddWithValue("@adet", adet);
                        komut1.Parameters.AddWithValue("@urunid", urunid);
                        komut1.ExecuteNonQuery();
                        MessageBox.Show("Zimmetleme İşlemi Başarıyla Gerçekleştirildi.");
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Adetten Fazla Girmeyiniz!");
                    }
                }
               

                baglanti.Close();
            }
        }

        private void lblurunid_Click(object sender, EventArgs e)
        {

        }

        private void lblpersonelid_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPersoneller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(int.Parse(txtAdet.Text.Length.ToString())>5)
            {
                e.Handled = false;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

namespace ParçaAlımOtomasyonu.Ürün_İşlemleri
{
    public class ZimmetlemeControl
    {
        private int urunid;
        private int personelid;
        private int adet;

        public ZimmetlemeControl(int urunid, int personelid, int adet)
        {
            this.urunid = urunid;
            this.personelid = personelid;
            this.adet = adet;
        }
    }
}