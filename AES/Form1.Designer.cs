namespace AES
{
    partial class Form1
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.cbGizliBilgi = new System.Windows.Forms.CheckBox();
            this.txtGizliMetin = new System.Windows.Forms.TextBox();
            this.lblGizliMetin = new System.Windows.Forms.Label();
            this.btnSifreCoz = new System.Windows.Forms.Button();
            this.btnVeriOku = new System.Windows.Forms.Button();
            this.rtbSifreliAlan = new System.Windows.Forms.RichTextBox();
            this.rtbSifreCozmeAlanı = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(98, 126);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(188, 126);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(75, 23);
            this.btnSifrele.TabIndex = 1;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // cbGizliBilgi
            // 
            this.cbGizliBilgi.AutoSize = true;
            this.cbGizliBilgi.Location = new System.Drawing.Point(98, 103);
            this.cbGizliBilgi.Name = "cbGizliBilgi";
            this.cbGizliBilgi.Size = new System.Drawing.Size(67, 17);
            this.cbGizliBilgi.TabIndex = 2;
            this.cbGizliBilgi.Text = "Gizli Bilgi";
            this.cbGizliBilgi.UseVisualStyleBackColor = true;
            // 
            // txtGizliMetin
            // 
            this.txtGizliMetin.Location = new System.Drawing.Point(98, 9);
            this.txtGizliMetin.Multiline = true;
            this.txtGizliMetin.Name = "txtGizliMetin";
            this.txtGizliMetin.Size = new System.Drawing.Size(353, 88);
            this.txtGizliMetin.TabIndex = 3;
            // 
            // lblGizliMetin
            // 
            this.lblGizliMetin.AutoSize = true;
            this.lblGizliMetin.Location = new System.Drawing.Point(30, 12);
            this.lblGizliMetin.Name = "lblGizliMetin";
            this.lblGizliMetin.Size = new System.Drawing.Size(58, 13);
            this.lblGizliMetin.TabIndex = 4;
            this.lblGizliMetin.Text = "Gizli Metin:";
            // 
            // btnSifreCoz
            // 
            this.btnSifreCoz.Location = new System.Drawing.Point(281, 126);
            this.btnSifreCoz.Name = "btnSifreCoz";
            this.btnSifreCoz.Size = new System.Drawing.Size(75, 23);
            this.btnSifreCoz.TabIndex = 5;
            this.btnSifreCoz.Text = "Şifre Çöz";
            this.btnSifreCoz.UseVisualStyleBackColor = true;
            this.btnSifreCoz.Click += new System.EventHandler(this.btnSifreCoz_Click);
            // 
            // btnVeriOku
            // 
            this.btnVeriOku.Location = new System.Drawing.Point(376, 126);
            this.btnVeriOku.Name = "btnVeriOku";
            this.btnVeriOku.Size = new System.Drawing.Size(75, 23);
            this.btnVeriOku.TabIndex = 6;
            this.btnVeriOku.Text = "Veri Oku";
            this.btnVeriOku.UseVisualStyleBackColor = true;
            this.btnVeriOku.Click += new System.EventHandler(this.btnVeriOku_Click);
            // 
            // rtbSifreliAlan
            // 
            this.rtbSifreliAlan.Location = new System.Drawing.Point(98, 167);
            this.rtbSifreliAlan.Name = "rtbSifreliAlan";
            this.rtbSifreliAlan.Size = new System.Drawing.Size(183, 165);
            this.rtbSifreliAlan.TabIndex = 7;
            this.rtbSifreliAlan.Text = "";
            // 
            // rtbSifreCozmeAlanı
            // 
            this.rtbSifreCozmeAlanı.Location = new System.Drawing.Point(281, 167);
            this.rtbSifreCozmeAlanı.Name = "rtbSifreCozmeAlanı";
            this.rtbSifreCozmeAlanı.Size = new System.Drawing.Size(170, 165);
            this.rtbSifreCozmeAlanı.TabIndex = 8;
            this.rtbSifreCozmeAlanı.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 408);
            this.Controls.Add(this.rtbSifreCozmeAlanı);
            this.Controls.Add(this.rtbSifreliAlan);
            this.Controls.Add(this.btnVeriOku);
            this.Controls.Add(this.btnSifreCoz);
            this.Controls.Add(this.lblGizliMetin);
            this.Controls.Add(this.txtGizliMetin);
            this.Controls.Add(this.cbGizliBilgi);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.CheckBox cbGizliBilgi;
        private System.Windows.Forms.TextBox txtGizliMetin;
        private System.Windows.Forms.Label lblGizliMetin;
        private System.Windows.Forms.Button btnSifreCoz;
        private System.Windows.Forms.Button btnVeriOku;
        private System.Windows.Forms.RichTextBox rtbSifreliAlan;
        private System.Windows.Forms.RichTextBox rtbSifreCozmeAlanı;
    }
}

