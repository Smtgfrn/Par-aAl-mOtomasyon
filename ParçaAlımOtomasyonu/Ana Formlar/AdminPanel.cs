using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ParçaAlımOtomasyonu
{
    public partial class AdminPanel : DevExpress.XtraEditors.XtraForm
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            ÜrünEkleme üe = new ÜrünEkleme();
            üe.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            KullanıcıEkleme ke = new KullanıcıEkleme();
            ke.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            stokTakip st = new stokTakip();
            st.ShowDialog();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            this.Hide();
            anaForm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            if (anaForm.Visible == false)
            {
                Application.Exit();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Zimmetleme zim = new Zimmetleme();
            zim.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtıkKontrol ak = new AtıkKontrol();
            ak.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelleriListele pl = new PersonelleriListele();
            pl.ShowDialog();
        }
    }
}