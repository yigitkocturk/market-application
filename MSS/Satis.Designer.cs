
namespace MSS
{
    partial class Satis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtUrunAdı = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatışİptal = new System.Windows.Forms.Button();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSatışListeleme = new System.Windows.Forms.Button();
            this.btnÜrünListeleme = new System.Windows.Forms.Button();
            this.btnÜrünEkleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(657, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtToplamFiyat);
            this.groupBox1.Controls.Add(this.txtSatisFiyati);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.txtUrunAdı);
            this.groupBox1.Controls.Add(this.txtBarkod);
            this.groupBox1.Location = new System.Drawing.Point(95, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toplam Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Satış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Miktar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Barkod No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(209, 206);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(205, 22);
            this.txtToplamFiyat.TabIndex = 4;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(209, 163);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(205, 22);
            this.txtSatisFiyati.TabIndex = 3;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(209, 117);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(205, 22);
            this.txtMiktar.TabIndex = 2;
            // 
            // txtUrunAdı
            // 
            this.txtUrunAdı.Location = new System.Drawing.Point(209, 76);
            this.txtUrunAdı.Name = "txtUrunAdı";
            this.txtUrunAdı.Size = new System.Drawing.Size(205, 22);
            this.txtUrunAdı.TabIndex = 1;
            this.txtUrunAdı.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(209, 33);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(205, 22);
            this.txtBarkod.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(1385, 205);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 33);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(1385, 281);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 34);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnSatışİptal
            // 
            this.btnSatışİptal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSatışİptal.ForeColor = System.Drawing.Color.Black;
            this.btnSatışİptal.Location = new System.Drawing.Point(95, 615);
            this.btnSatışİptal.Name = "btnSatışİptal";
            this.btnSatışİptal.Size = new System.Drawing.Size(120, 32);
            this.btnSatışİptal.TabIndex = 4;
            this.btnSatışİptal.Text = "Satış İptal";
            this.btnSatışİptal.UseVisualStyleBackColor = false;
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSatışYap.ForeColor = System.Drawing.Color.Black;
            this.btnSatışYap.Location = new System.Drawing.Point(1224, 654);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(116, 32);
            this.btnSatışYap.TabIndex = 5;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(1060, 669);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Toplam";
            this.label.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(1115, 662);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnÜrünListeleme);
            this.panel1.Controls.Add(this.btnÜrünEkleme);
            this.panel1.Controls.Add(this.btnSatışListeleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 142);
            this.panel1.TabIndex = 8;
            // 
            // btnSatışListeleme
            // 
            this.btnSatışListeleme.ForeColor = System.Drawing.Color.Black;
            this.btnSatışListeleme.Location = new System.Drawing.Point(657, 45);
            this.btnSatışListeleme.Name = "btnSatışListeleme";
            this.btnSatışListeleme.Size = new System.Drawing.Size(220, 40);
            this.btnSatışListeleme.TabIndex = 1;
            this.btnSatışListeleme.Text = "Satış Listeleme";
            this.btnSatışListeleme.UseVisualStyleBackColor = true;
            // 
            // btnÜrünListeleme
            // 
            this.btnÜrünListeleme.ForeColor = System.Drawing.Color.Black;
            this.btnÜrünListeleme.Location = new System.Drawing.Point(368, 45);
            this.btnÜrünListeleme.Name = "btnÜrünListeleme";
            this.btnÜrünListeleme.Size = new System.Drawing.Size(200, 43);
            this.btnÜrünListeleme.TabIndex = 9;
            this.btnÜrünListeleme.Text = "Ürün Listeleme";
            this.btnÜrünListeleme.UseVisualStyleBackColor = true;
            // 
            // btnÜrünEkleme
            // 
            this.btnÜrünEkleme.ForeColor = System.Drawing.Color.Black;
            this.btnÜrünEkleme.Location = new System.Drawing.Point(77, 47);
            this.btnÜrünEkleme.Name = "btnÜrünEkleme";
            this.btnÜrünEkleme.Size = new System.Drawing.Size(240, 41);
            this.btnÜrünEkleme.TabIndex = 10;
            this.btnÜrünEkleme.Text = "Ürün Ekleme";
            this.btnÜrünEkleme.UseVisualStyleBackColor = true;
            this.btnÜrünEkleme.Click += new System.EventHandler(this.btnÜrünEkleme_Click);
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1510, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSatışYap);
            this.Controls.Add(this.btnSatışİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Name = "Satis";
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.Satis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtUrunAdı;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatışİptal;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnÜrünListeleme;
        private System.Windows.Forms.Button btnÜrünEkleme;
        private System.Windows.Forms.Button btnSatışListeleme;
    }
}

