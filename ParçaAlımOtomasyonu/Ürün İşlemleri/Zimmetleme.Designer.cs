namespace ParçaAlımOtomasyonu
{
    partial class Zimmetleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zimmetleme));
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.lblurunid = new System.Windows.Forms.Label();
            this.lblpersonelid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnZimmetle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(599, 135);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(631, 252);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellContentClick);
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoneller.Location = new System.Drawing.Point(18, 135);
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.RowTemplate.Height = 24;
            this.dgvPersoneller.Size = new System.Drawing.Size(535, 252);
            this.dgvPersoneller.TabIndex = 1;
            this.dgvPersoneller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersoneller_CellContentClick);
            // 
            // lblurunid
            // 
            this.lblurunid.AutoSize = true;
            this.lblurunid.BackColor = System.Drawing.Color.Transparent;
            this.lblurunid.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblurunid.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblurunid.Location = new System.Drawing.Point(618, 78);
            this.lblurunid.Name = "lblurunid";
            this.lblurunid.Size = new System.Drawing.Size(121, 34);
            this.lblurunid.TabIndex = 2;
            this.lblurunid.Text = "Ürünler";
            this.lblurunid.Click += new System.EventHandler(this.lblurunid_Click);
            // 
            // lblpersonelid
            // 
            this.lblpersonelid.AutoSize = true;
            this.lblpersonelid.BackColor = System.Drawing.Color.Transparent;
            this.lblpersonelid.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpersonelid.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblpersonelid.Location = new System.Drawing.Point(27, 78);
            this.lblpersonelid.Name = "lblpersonelid";
            this.lblpersonelid.Size = new System.Drawing.Size(173, 34);
            this.lblpersonelid.TabIndex = 3;
            this.lblpersonelid.Text = "Personeller";
            this.lblpersonelid.Click += new System.EventHandler(this.lblpersonelid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(55, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adet Giriniz:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(197, 489);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(131, 32);
            this.txtAdet.TabIndex = 6;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // btnZimmetle
            // 
            this.btnZimmetle.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetle.Appearance.Options.UseFont = true;
            this.btnZimmetle.Location = new System.Drawing.Point(919, 464);
            this.btnZimmetle.Name = "btnZimmetle";
            this.btnZimmetle.Size = new System.Drawing.Size(265, 109);
            this.btnZimmetle.TabIndex = 7;
            this.btnZimmetle.Text = "Zimmetle";
            this.btnZimmetle.Click += new System.EventHandler(this.btnZimmetle_Click);
            // 
            // Zimmetleme
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1264, 632);
            this.Controls.Add(this.btnZimmetle);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpersonelid);
            this.Controls.Add(this.lblurunid);
            this.Controls.Add(this.dgvPersoneller);
            this.Controls.Add(this.dgvUrunler);
            this.Name = "Zimmetleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zimmetleme";
            this.Load += new System.EventHandler(this.Zimmetleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.DataGridView dgvPersoneller;
        private System.Windows.Forms.Label lblurunid;
        private System.Windows.Forms.Label lblpersonelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdet;
        private DevExpress.XtraEditors.SimpleButton btnZimmetle;
    }
}