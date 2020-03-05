namespace ParçaAlımOtomasyonu
{
    partial class birimYetkiliGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(birimYetkiliGiriş));
            this.btnGiriş = new System.Windows.Forms.Button();
            this.btnAnaMenü = new System.Windows.Forms.Button();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBölüm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiriş
            // 
            this.btnGiriş.BackColor = System.Drawing.Color.Black;
            this.btnGiriş.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriş.ForeColor = System.Drawing.Color.White;
            this.btnGiriş.Image = ((System.Drawing.Image)(resources.GetObject("btnGiriş.Image")));
            this.btnGiriş.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiriş.Location = new System.Drawing.Point(327, 385);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(128, 71);
            this.btnGiriş.TabIndex = 21;
            this.btnGiriş.Text = "Giriş Yap";
            this.btnGiriş.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiriş.UseVisualStyleBackColor = false;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // btnAnaMenü
            // 
            this.btnAnaMenü.BackColor = System.Drawing.Color.Black;
            this.btnAnaMenü.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenü.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenü.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaMenü.Image")));
            this.btnAnaMenü.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaMenü.Location = new System.Drawing.Point(92, 385);
            this.btnAnaMenü.Name = "btnAnaMenü";
            this.btnAnaMenü.Size = new System.Drawing.Size(199, 71);
            this.btnAnaMenü.TabIndex = 20;
            this.btnAnaMenü.Text = "Ana Sayfaya Dön";
            this.btnAnaMenü.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnaMenü.UseVisualStyleBackColor = false;
            this.btnAnaMenü.Click += new System.EventHandler(this.btnAnaMenü_Click);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtŞifre.Location = new System.Drawing.Point(241, 258);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(214, 28);
            this.txtŞifre.TabIndex = 19;
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(241, 193);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(214, 28);
            this.txtKullanıcıAdı.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(131, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şifreniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kullanıcı Adınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "BİRİM YETKİLİ GİRİŞİ\r\n";
            // 
            // cmbBölüm
            // 
            this.cmbBölüm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBölüm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBölüm.FormattingEnabled = true;
            this.cmbBölüm.Items.AddRange(new object[] {
            "pazarlama",
            "muhasebe",
            "insan kaynakları",
            "üretim"});
            this.cmbBölüm.Location = new System.Drawing.Point(241, 315);
            this.cmbBölüm.Name = "cmbBölüm";
            this.cmbBölüm.Size = new System.Drawing.Size(214, 29);
            this.cmbBölüm.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Bölüm Seçiniz:";
            // 
            // birimYetkiliGiriş
            // 
            this.AcceptButton = this.btnGiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(576, 486);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBölüm);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.btnAnaMenü);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "birimYetkiliGiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "birimYetkiliGiriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.birimYetkiliGiriş_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.Button btnAnaMenü;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBölüm;
        private System.Windows.Forms.Label label4;
    }
}