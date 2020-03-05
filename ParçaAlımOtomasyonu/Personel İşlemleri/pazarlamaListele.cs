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
    public partial class pazarlamaListele : DevExpress.XtraEditors.XtraForm
    {
        public pazarlamaListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-57A1L0H;Initial Catalog=YazılımSınamaProje;Integrated Security=True");
        private void pazarlamaListele_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter listele = new SqlDataAdapter("Select p.adı,p.soyadı,u.UrunAdı, z.adet From Zimmet z INNER JOIN Urunler u ON z.urunid=u.urunid INNER JOIN Personeller p ON z.personelid=p.personelid INNER JOIN Bölüm b ON b.bölümid = p.bölümid where p.bölümid='"+3+"'", baglanti);
            DataSet dhafıza = new DataSet();
            listele.Fill(dhafıza);
            dgvPazarlama.DataSource = dhafıza.Tables[0];
            baglanti.Close();
        }

        private void dgvPazarlama_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pazarlamaListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            if (anaForm.Visible == false)
            {
                Application.Exit();
            }
        }

        private void btnAnaMenü_Click(object sender, EventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            this.Hide();
            anaForm.Show();
        }
    }
}