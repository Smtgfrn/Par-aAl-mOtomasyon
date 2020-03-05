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
    public partial class ÜrünEkleme : DevExpress.XtraEditors.XtraForm
    {
        public ÜrünEkleme()
        {
            InitializeComponent();
            txtAdet.MaxLength = 5;
            txtFiyat.MaxLength = 10;
            txtAd.MaxLength = 30;
            txtFirma.MaxLength = 50;
            for(int i=1900;i<2900;i++)
            {
                cmbYıl.Items.Add(i);
            }
            
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-57A1L0H;Initial Catalog=YazılımSınamaProje;Integrated Security=True");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string tarih;
            tarih = cmbGun.SelectedItem.ToString() + '/' + cmbAy.SelectedItem.ToString() + '/' + cmbYıl.SelectedItem.ToString();
            if(cmbTür.SelectedIndex==-1 || txtAd.Text=="" || txtAdet.Text == "" || txtFirma.Text == "" || txtFiyat.Text =="" || cmbYıl.SelectedIndex==-1 || cmbAy.SelectedIndex == -1 || cmbGun.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!");
            }
            else if(cmbTür.SelectedIndex == 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Urunler(kategoriid, UrunAdı,UrunBirimFiyatı,SatınAlmaTarihi,Firma,Adet) VALUES('"+1+"','"+txtAd.Text+"','"+txtFiyat.Text+"','"+tarih+"','"+txtFirma.Text+"','"+int.Parse(txtAdet.Text)+"')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün Eklendi.");
                this.Hide();
                baglanti.Close();
            }
            else if (cmbTür.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Urunler(kategoriid, UrunAdı,UrunBirimFiyatı,SatınAlmaTarihi,Firma,Adet) VALUES('" + 2 + "','" + txtAd.Text + "','" + txtFiyat.Text + "','" + tarih + "','" + txtFirma.Text + "','" + int.Parse(txtAdet.Text) + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün Eklendi.");
                this.Hide();
                baglanti.Close();

            }
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void cmbYıl_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cmbTür_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cmbAy_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmbGun_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void ÜrünEkleme_Load(object sender, EventArgs e)
        {
           
        }
    }
}