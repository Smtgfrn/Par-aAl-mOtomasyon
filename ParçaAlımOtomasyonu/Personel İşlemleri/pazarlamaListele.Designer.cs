namespace ParçaAlımOtomasyonu
{
    partial class pazarlamaListele
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
            this.dgvPazarlama = new System.Windows.Forms.DataGridView();
            this.btnAnaMenü = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazarlama)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPazarlama
            // 
            this.dgvPazarlama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPazarlama.Location = new System.Drawing.Point(0, 3);
            this.dgvPazarlama.Name = "dgvPazarlama";
            this.dgvPazarlama.RowTemplate.Height = 24;
            this.dgvPazarlama.Size = new System.Drawing.Size(518, 487);
            this.dgvPazarlama.TabIndex = 0;
            this.dgvPazarlama.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPazarlama_CellContentClick);
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenü.Appearance.Options.UseFont = true;
            this.btnAnaMenü.Location = new System.Drawing.Point(0, 489);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(518, 72);
            this.btnAnaMenü.TabIndex = 3;
            this.btnAnaMenü.Text = "Ana Menüye Dön";
            this.btnAnaMenü.Click += new System.EventHandler(this.btnAnaMenü_Click);
            // 
            // pazarlamaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 556);
            this.Controls.Add(this.btnAnaMenü);
            this.Controls.Add(this.dgvPazarlama);
            this.Name = "pazarlamaListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pazarlamaListele";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pazarlamaListele_FormClosing);
            this.Load += new System.EventHandler(this.pazarlamaListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPazarlama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPazarlama;
        private DevExpress.XtraEditors.SimpleButton btnAnaMenü;
    }
}