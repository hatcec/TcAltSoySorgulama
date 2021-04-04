
namespace TcAltSoySorgulama
{
    partial class Form1
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
            this.BtnSorgula = new System.Windows.Forms.Button();
            this.TxtTarih = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSorgula
            // 
            this.BtnSorgula.Location = new System.Drawing.Point(34, 151);
            this.BtnSorgula.Name = "BtnSorgula";
            this.BtnSorgula.Size = new System.Drawing.Size(122, 22);
            this.BtnSorgula.TabIndex = 9;
            this.BtnSorgula.Text = "Kimlik No Sorgula";
            this.BtnSorgula.UseVisualStyleBackColor = true;
            this.BtnSorgula.Click += new System.EventHandler(this.BtnSorgula_Click);
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(34, 110);
            this.TxtTarih.MaxLength = 4;
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(122, 20);
            this.TxtTarih.TabIndex = 8;
            this.TxtTarih.Text = "Doğum Tarihi Giriniz..";
            this.TxtTarih.Enter += new System.EventHandler(this.TxtTarih_Enter);
            this.TxtTarih.Leave += new System.EventHandler(this.TxtTarih_Leave);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(34, 84);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(122, 20);
            this.TxtSoyad.TabIndex = 7;
            this.TxtSoyad.Text = "Soyisim Giriniz..";
            this.TxtSoyad.Enter += new System.EventHandler(this.TxtSoyad_Enter);
            this.TxtSoyad.Leave += new System.EventHandler(this.TxtSoyad_Leave);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(34, 58);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(122, 20);
            this.TxtAd.TabIndex = 6;
            this.TxtAd.Text = "İsim Giriniz..";
            this.TxtAd.Enter += new System.EventHandler(this.TxtAd_Enter);
            this.TxtAd.Leave += new System.EventHandler(this.TxtAd_Leave);
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(34, 32);
            this.TxtTc.MaxLength = 11;
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(122, 20);
            this.TxtTc.TabIndex = 5;
            this.TxtTc.Text = "Kimlik Numarası Giriniz..";
            this.TxtTc.Enter += new System.EventHandler(this.TxtTc_Enter);
            this.TxtTc.Leave += new System.EventHandler(this.TxtTc_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSorgula);
            this.Controls.Add(this.TxtTarih);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.TxtTc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSorgula;
        private System.Windows.Forms.TextBox TxtTarih;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtTc;
    }
}

