namespace ParçaAlımOtomasyonu
{
    partial class PersonelleriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelleriListele));
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.cmbBölüm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoneller.Location = new System.Drawing.Point(12, 224);
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.RowTemplate.Height = 24;
            this.dgvPersoneller.Size = new System.Drawing.Size(518, 487);
            this.dgvPersoneller.TabIndex = 1;
            this.dgvPersoneller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPazarlama_CellContentClick);
            // 
            // cmbBölüm
            // 
            this.cmbBölüm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBölüm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBölüm.FormattingEnabled = true;
            this.cmbBölüm.Items.AddRange(new object[] {
            "Yönetici",
            "Satın alma",
            "Pazarlama",
            "Muhasebe",
            "İnsan kaynakları",
            "Üretim"});
            this.cmbBölüm.Location = new System.Drawing.Point(283, 82);
            this.cmbBölüm.Name = "cmbBölüm";
            this.cmbBölüm.Size = new System.Drawing.Size(175, 29);
            this.cmbBölüm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(68, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen Birim Seçiniz:";
            // 
            // btnListele
            // 
            this.btnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.Location = new System.Drawing.Point(204, 147);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(112, 45);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PersonelleriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(538, 722);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBölüm);
            this.Controls.Add(this.dgvPersoneller);
            this.Name = "PersonelleriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelleriListele";
            this.Load += new System.EventHandler(this.PersonelleriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersoneller;
        private System.Windows.Forms.ComboBox cmbBölüm;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnListele;
    }
}