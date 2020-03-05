namespace ParçaAlımOtomasyonu
{
    partial class insanKaynaklarıListele
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
            this.dgvİnsanKaynakları = new System.Windows.Forms.DataGridView();
            this.btnAnaMenü = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvİnsanKaynakları)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvİnsanKaynakları
            // 
            this.dgvİnsanKaynakları.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvİnsanKaynakları.Location = new System.Drawing.Point(0, 3);
            this.dgvİnsanKaynakları.Name = "dgvİnsanKaynakları";
            this.dgvİnsanKaynakları.RowTemplate.Height = 24;
            this.dgvİnsanKaynakları.Size = new System.Drawing.Size(518, 482);
            this.dgvİnsanKaynakları.TabIndex = 1;
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenü.Appearance.Options.UseFont = true;
            this.btnAnaMenü.Location = new System.Drawing.Point(0, 484);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(518, 72);
            this.btnAnaMenü.TabIndex = 3;
            this.btnAnaMenü.Text = "Ana Menüye Dön";
            this.btnAnaMenü.Click += new System.EventHandler(this.btnAnaMenü_Click);
            // 
            // insanKaynaklarıListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 556);
            this.Controls.Add(this.btnAnaMenü);
            this.Controls.Add(this.dgvİnsanKaynakları);
            this.Name = "insanKaynaklarıListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insanKaynaklarıListele";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.insanKaynaklarıListele_FormClosing);
            this.Load += new System.EventHandler(this.insanKaynaklarıListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvİnsanKaynakları)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvİnsanKaynakları;
        private DevExpress.XtraEditors.SimpleButton btnAnaMenü;
    }
}