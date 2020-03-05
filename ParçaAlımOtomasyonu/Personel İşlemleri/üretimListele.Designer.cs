namespace ParçaAlımOtomasyonu
{
    partial class üretimListele
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
            this.dgvÜretim = new System.Windows.Forms.DataGridView();
            this.btnAnaMenü = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvÜretim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvÜretim
            // 
            this.dgvÜretim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvÜretim.Location = new System.Drawing.Point(0, 3);
            this.dgvÜretim.Name = "dgvÜretim";
            this.dgvÜretim.RowTemplate.Height = 24;
            this.dgvÜretim.Size = new System.Drawing.Size(518, 486);
            this.dgvÜretim.TabIndex = 1;
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenü.Appearance.Options.UseFont = true;
            this.btnAnaMenü.Location = new System.Drawing.Point(0, 488);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(518, 72);
            this.btnAnaMenü.TabIndex = 2;
            this.btnAnaMenü.Text = "Ana Menüye Dön";
            this.btnAnaMenü.Click += new System.EventHandler(this.btnAnaMenü_Click);
            // 
            // üretimListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 556);
            this.Controls.Add(this.btnAnaMenü);
            this.Controls.Add(this.dgvÜretim);
            this.Name = "üretimListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "üretimListele";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.üretimListele_FormClosing);
            this.Load += new System.EventHandler(this.üretimListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvÜretim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvÜretim;
        private DevExpress.XtraEditors.SimpleButton btnAnaMenü;
    }
}