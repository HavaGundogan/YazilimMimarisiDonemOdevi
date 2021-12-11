namespace YazilimMimarisiDonemOdevi
{
    partial class AdminForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_diyetisyenad = new System.Windows.Forms.Label();
            this.txt_diyetisyenad = new System.Windows.Forms.TextBox();
            this.lbl_diyetisyensoyad = new System.Windows.Forms.Label();
            this.txt_diyetisyensoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_diyetisyenad
            // 
            this.lbl_diyetisyenad.AutoSize = true;
            this.lbl_diyetisyenad.Location = new System.Drawing.Point(199, 82);
            this.lbl_diyetisyenad.Name = "lbl_diyetisyenad";
            this.lbl_diyetisyenad.Size = new System.Drawing.Size(77, 13);
            this.lbl_diyetisyenad.TabIndex = 0;
            this.lbl_diyetisyenad.Text = "Diyetisyen Ad :";
            // 
            // txt_diyetisyenad
            // 
            this.txt_diyetisyenad.Location = new System.Drawing.Point(306, 79);
            this.txt_diyetisyenad.Name = "txt_diyetisyenad";
            this.txt_diyetisyenad.Size = new System.Drawing.Size(100, 20);
            this.txt_diyetisyenad.TabIndex = 1;
            // 
            // lbl_diyetisyensoyad
            // 
            this.lbl_diyetisyensoyad.AutoSize = true;
            this.lbl_diyetisyensoyad.Location = new System.Drawing.Point(199, 114);
            this.lbl_diyetisyensoyad.Name = "lbl_diyetisyensoyad";
            this.lbl_diyetisyensoyad.Size = new System.Drawing.Size(94, 13);
            this.lbl_diyetisyensoyad.TabIndex = 2;
            this.lbl_diyetisyensoyad.Text = "Diyetisyen Soyad :";
            // 
            // txt_diyetisyensoyad
            // 
            this.txt_diyetisyensoyad.Location = new System.Drawing.Point(306, 111);
            this.txt_diyetisyensoyad.Name = "txt_diyetisyensoyad";
            this.txt_diyetisyensoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_diyetisyensoyad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Diyetisyen TCNO :";
            // 
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(306, 145);
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(100, 20);
            this.txt_tcno.TabIndex = 5;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(199, 178);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(85, 13);
            this.lbl_sifre.TabIndex = 6;
            this.lbl_sifre.Text = "Diyetisyen Şifre :";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(306, 175);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 7;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(270, 214);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 332);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.txt_tcno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_diyetisyensoyad);
            this.Controls.Add(this.lbl_diyetisyensoyad);
            this.Controls.Add(this.txt_diyetisyenad);
            this.Controls.Add(this.lbl_diyetisyenad);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_diyetisyenad;
        private System.Windows.Forms.TextBox txt_diyetisyenad;
        private System.Windows.Forms.Label lbl_diyetisyensoyad;
        private System.Windows.Forms.TextBox txt_diyetisyensoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_kaydet;
    }
}

