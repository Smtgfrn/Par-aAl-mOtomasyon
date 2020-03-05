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
    public partial class PersonelleriListele : DevExpress.XtraEditors.XtraForm
    {
        public PersonelleriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-57A1L0H;Initial Catalog=YazılımSınamaProje;Integrated Security=True");

        private void dgvPazarlama_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonelleriListele_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(cmbBölüm.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Bölüm Seçiniz!");
            }
            else if(cmbBölüm.SelectedIndex==0)
            {
                baglanti.Open();
                SqlDataAdapter listele = new SqlDataAdapter("Select p.adı,p.soyadı,u.UrunAdı, z.adet From Zimmet z INNER JOIN Urunler u ON z.urunid=u.urunid INNER JOIN Personeller p ON z.personelid=p.personelid INNER JOIN Bölüm b ON b.bölümid = p.bölümid where p.bölümid='" + 1 + "'", baglanti);
                DataSet dhafıza = new DataSet();
                listele.Fill(dhafıza);
                dgvPersoneller.DataSource = dhafıza.Tables[0];
                baglanti.Close();
            }
            else if (cmbBölüm.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter listele = new SqlDataAdapter("Select p.adı,p.soyadı,u.UrunAdı, z.adet From Zimmet z INNER JOIN Urunler u ON z.urunid=u.urunid INNER JOIN Personeller p ON z.personelid=p.personelid INNER JOIN Bölüm b ON b.bölümid = p.bölümid where p.bölümid='" + 2 + "'", baglanti);
                DataSet dhafıza = new DataSet();
                listele.Fill(dhafıza);
                dgvPersoneller.DataSource = dhafıza.Tables[0];
                baglanti.Close();
            }
            else if (cmbBölüm.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter listele = new SqlDataAdapter("Select p.adı,p.soyadı,u.UrunAdı, z.adet From Zimmet z INNER JOIN Urunler u ON z.urunid=u.urunid INNER JOIN Personeller p ON z.personelid=p.personelid INNER JOIN Bölüm b ON b.bölümid = p.bölümid where p.bölümid='" + 3 + "'", baglanti);
                DataSet dhafıza = new DataSet();
                listele.Fill(dhafıza);
                dgvPersoneller.DataSource = dhafıza.Tables[0];
                baglanti.Close();
            }
            else if (cmbBölüm.SelectedIndex == 3)
            {
                baglanti.Open();
                SqlDataAdapter listele = new SqlDataAdapter("Select p.adı,p.soyadı,u.UrunAdı, z.adet From Zimmet z INNER JOIN Urunler u ON z.urunid=u.urunid INNER JOIN Personeller p ON z.personelid=p.personelid INNER JOIN Bölüm b ON b.bölümid = p.bölümid where p.bölümid='" + 4 + "'", baglanti);
                DataSet dhafıza = new DataSet();
                listele.Fill(dhafıza);
                dgvPersoneller.DataSource = dhafıza.Tables[0];
                baglanti.Close();
            }
            else if (cmbBölüm.SelectedIndex == 4)
            {
                baglanti.Open();
                SqlDataAdapter listele = new SqlDataAdapter("Select p.adı,p.soyadı,u.UrunAdı, z.adet From Zimmet z INNER JOIN Urunler u ON z.urunid=u.urunid INNER JOIN Personeller p ON z.personelid=p.personelid INNER JOIN Bölüm b ON b.bölümid = p.bölümid where p.bölümid='" + 5 + "'", baglanti);
                DataSet dhafıza = new DataSet();
                listele.Fill(dhafıza);
                dgvPersoneller.DataSource = dhafıza.Tables[0];
                baglanti.Close();
            }
            else if (cmbBölüm.SelectedIndex == 5)
            {
                baglanti.Open();
                SqlDataAdapter listele = new SqlDataAdapter("Select p.adı,p.soyadı,u.UrunAdı, z.adet From Zimmet z INNER JOIN Urunler u ON z.urunid=u.urunid INNER JOIN Personeller p ON z.personelid=p.personelid INNER JOIN Bölüm b ON b.bölümid = p.bölümid where p.bölümid='" + 6 + "'", baglanti);
                DataSet dhafıza = new DataSet();
                listele.Fill(dhafıza);
                dgvPersoneller.DataSource = dhafıza.Tables[0];
                baglanti.Close();
            }

        }
    }
}