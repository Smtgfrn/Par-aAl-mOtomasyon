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

    public partial class stokTakip : DevExpress.XtraEditors.XtraForm
    {
        public stokTakip()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-57A1L0H;Initial Catalog=YazılımSınamaProje;Integrated Security=True");

        private void stokTakip_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter listele = new SqlDataAdapter("Select u.UrunAdı,u.Adet,u.UrunBirimFiyatı,k.KategoriAdı from Urunler u INNER JOIN Kategoriler k ON u.kategoriid=k.kategoriid", baglanti);
            DataSet dhafıza = new DataSet();
            listele.Fill(dhafıza);
            dgvUrunler.DataSource = dhafıza.Tables[0];
            baglanti.Close();
        }
    }
}