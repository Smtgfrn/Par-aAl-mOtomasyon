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
    public partial class SatınAlmaPanel : DevExpress.XtraEditors.XtraForm
    {
        public SatınAlmaPanel()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ÜrünEkleme üe = new ÜrünEkleme();
            üe.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void SatınAlmaPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            if (anaForm.Visible == false)
            {
                Application.Exit();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            AnaSayfa anaForm = new AnaSayfa();
            this.Hide();
            anaForm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Zimmetleme zim = new Zimmetleme();
            zim.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            stokTakip st = new stokTakip();
            st.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            PersonelleriListele pl = new PersonelleriListele();
            pl.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtıkKontrol ak = new AtıkKontrol();
            ak.ShowDialog();
        }
    }
}