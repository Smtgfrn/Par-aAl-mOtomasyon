namespace ParçaAlımOtomasyonu
{
    partial class AtıkKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtıkKontrol));
            this.btnAtık = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvZimmet = new System.Windows.Forms.DataGridView();
            this.lblpersonelid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZimmet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtık
            // 
            this.btnAtık.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAtık.Appearance.Options.UseFont = true;
            this.btnAtık.Location = new System.Drawing.Point(331, 425);
            this.btnAtık.Name = "btnAtık";
            this.btnAtık.Size = new System.Drawing.Size(265, 109);
            this.btnAtık.TabIndex = 14;
            this.btnAtık.Text = "Ürünü Çıkart";
            this.btnAtık.Click += new System.EventHandler(this.btnAtık_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(156, 452);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(131, 32);
            this.txtAdet.TabIndex = 13;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adet Giriniz:";
            // 
            // dgvZimmet
            // 
            this.dgvZimmet.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvZimmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZimmet.Location = new System.Drawing.Point(18, 96);
            this.dgvZimmet.Name = "dgvZimmet";
            this.dgvZimmet.RowTemplate.Height = 24;
            this.dgvZimmet.Size = new System.Drawing.Size(624, 311);
            this.dgvZimmet.TabIndex = 9;
            // 
            // lblpersonelid
            // 
            this.lblpersonelid.AutoSize = true;
            this.lblpersonelid.BackColor = System.Drawing.Color.Transparent;
            this.lblpersonelid.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpersonelid.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblpersonelid.Location = new System.Drawing.Point(12, 43);
            this.lblpersonelid.Name = "lblpersonelid";
            this.lblpersonelid.Size = new System.Drawing.Size(160, 34);
            this.lblpersonelid.TabIndex = 11;
            this.lblpersonelid.Text = "Zimmetler";
            // 
            // AtıkKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(654, 577);
            this.Controls.Add(this.btnAtık);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpersonelid);
            this.Controls.Add(this.dgvZimmet);
            this.Name = "AtıkKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtıkKontrol";
            this.Load += new System.EventHandler(this.AtıkKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZimmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAtık;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZimmet;
        private System.Windows.Forms.Label lblpersonelid;
    }
}