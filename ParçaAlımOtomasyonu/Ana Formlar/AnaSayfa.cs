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

namespace ParçaAlımOtomasyonu
{
    public partial class AnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        
        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminGiriş adminForm = new adminGiriş();
            this.Hide();
            adminForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satınAlmaGiriş saForm = new satınAlmaGiriş();
            this.Hide();
            saForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            birimYetkiliGiriş byForm = new birimYetkiliGiriş();
            this.Hide();
            byForm.Show();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            birimYetkiliGiriş byForm = new birimYetkiliGiriş();
            satınAlmaGiriş saForm = new satınAlmaGiriş();
            adminGiriş adminForm = new adminGiriş();
            if (byForm.Visible==false && saForm.Visible==false && adminForm.Visible==false)
            {
                Application.Exit();
            }
        }
    }
}