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
    public partial class muhasebeListele : DevExpress.XtraEditors.XtraForm
    {
        public muhasebeListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-57A1L0H;Initial Catalog=YazılımSınamaProje;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void muhasebeListele_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter listele = new SqlDataAdapter("Select p.adı,p.soyadı,u.UrunAdı, z.adet From Zimmet z INNER JOIN Urunler u ON z.urunid=u.urunid INNER JOIN Personeller p ON z.personelid=p.personelid INNER JOIN Bölüm b ON b.bölümid = p.bölümid where p.bölümid='" + 5 + "'", baglanti);
            DataSet dhafıza = new DataSet();
            listele.Fill(dhafıza);
            dgvMuhasebe.DataSource = dhafıza.Tables[0];
            baglanti.Close();
        }

        private void muhasebeListele_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvMuhasebe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}