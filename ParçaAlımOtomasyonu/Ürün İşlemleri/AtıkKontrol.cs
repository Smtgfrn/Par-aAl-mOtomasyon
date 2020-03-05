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
    public partial class AtıkKontrol : DevExpress.XtraEditors.XtraForm
    {
        public AtıkKontrol()
        {
            InitializeComponent();
            txtAdet.MaxLength = 5;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-57A1L0H;Initial Catalog=YazılımSınamaProje;Integrated Security=True");
        private void AtıkKontrol_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter listele = new SqlDataAdapter("Select z.zimmetid, p.adı,p.soyadı,u.UrunAdı, z.adet From Zimmet z INNER JOIN Urunler u ON z.urunid=u.urunid INNER JOIN Personeller p ON z.personelid=p.personelid", baglanti);
            DataSet dhafıza = new DataSet();
            listele.Fill(dhafıza);
            dgvZimmet.DataSource = dhafıza.Tables[0];
            baglanti.Close();
        }

        private void btnAtık_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {
                MessageBox.Show("Lütfen Adet Giriniz!");
            }
            else
            {
                int zimmetid = (int)dgvZimmet.CurrentRow.Cells["zimmetid"].Value;
                int adet = int.Parse(txtAdet.Text);
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Select * from Zimmet where zimmetid =@zimmetid", baglanti);
                komut2.Parameters.AddWithValue("@zimmetid", zimmetid);
                SqlDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    if(int.Parse(dr["adet"].ToString()) >= adet)
                    {
                        dr.Close();
                        SqlCommand komut = new SqlCommand("INSERT INTO Atık_Kontrol(zimmetid,adet) VALUES('"+zimmetid+"','"+adet+"')", baglanti);
                        komut.ExecuteNonQuery();
                        SqlCommand komut1 = new SqlCommand("UPDATE Zimmet SET adet = adet - @adet WHERE zimmetid = @zimmetid", baglanti);
                        komut1.Parameters.AddWithValue("@adet", adet);
                        komut1.Parameters.AddWithValue("@zimmetid", zimmetid);
                        komut1.ExecuteNonQuery();
                        MessageBox.Show("Ürün Çıkarma İşlemi Başarıyla Gerçekleştirildi.");
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Adetten Fazla Girmeyiniz!");
                    }
                }
            }
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

namespace ParçaAlımOtomasyonu.Ürün_İşlemleri
{
    public class AtıkKontrolControl
    {
        private int urunid;
        private int personelid;
        private int adet;

        public AtıkKontrolControl(int urunid, int personelid, int adet)
        {
            this.urunid = urunid;
            this.personelid = personelid;
            this.adet = adet;
        }
    }
}