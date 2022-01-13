
namespace MSS
{
    partial class ÜrünEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.txtÜrünAdi = new System.Windows.Forms.TextBox();
            this.txtÜrünGelis = new System.Windows.Forms.TextBox();
            this.txtÜrünSatıs = new System.Windows.Forms.TextBox();
            this.txtKar = new System.Windows.Forms.TextBox();
            this.txtStokDurumu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(54, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Geliş Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(54, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Satış Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuText;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(54, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kar Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuText;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(54, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stok Durumu";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txtÜrünAdi
            // 
            this.txtÜrünAdi.Location = new System.Drawing.Point(307, 57);
            this.txtÜrünAdi.Name = "txtÜrünAdi";
            this.txtÜrünAdi.Size = new System.Drawing.Size(152, 22);
            this.txtÜrünAdi.TabIndex = 5;
            this.txtÜrünAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtÜrünGelis
            // 
            this.txtÜrünGelis.Location = new System.Drawing.Point(307, 105);
            this.txtÜrünGelis.Name = "txtÜrünGelis";
            this.txtÜrünGelis.Size = new System.Drawing.Size(152, 22);
            this.txtÜrünGelis.TabIndex = 6;
            // 
            // txtÜrünSatıs
            // 
            this.txtÜrünSatıs.Location = new System.Drawing.Point(307, 148);
            this.txtÜrünSatıs.Name = "txtÜrünSatıs";
            this.txtÜrünSatıs.Size = new System.Drawing.Size(152, 22);
            this.txtÜrünSatıs.TabIndex = 7;
            // 
            // txtKar
            // 
            this.txtKar.Location = new System.Drawing.Point(307, 191);
            this.txtKar.Name = "txtKar";
            this.txtKar.Size = new System.Drawing.Size(152, 22);
            this.txtKar.TabIndex = 8;
            // 
            // txtStokDurumu
            // 
            this.txtStokDurumu.Location = new System.Drawing.Point(307, 233);
            this.txtStokDurumu.Name = "txtStokDurumu";
            this.txtStokDurumu.Size = new System.Drawing.Size(152, 22);
            this.txtStokDurumu.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(348, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ÜrünEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStokDurumu);
            this.Controls.Add(this.txtKar);
            this.Controls.Add(this.txtÜrünSatıs);
            this.Controls.Add(this.txtÜrünGelis);
            this.Controls.Add(this.txtÜrünAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ÜrünEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÜrünEkle";
            this.Load += new System.EventHandler(this.ÜrünEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtÜrünAdi;
        private System.Windows.Forms.TextBox txtÜrünGelis;
        private System.Windows.Forms.TextBox txtÜrünSatıs;
        private System.Windows.Forms.TextBox txtKar;
        private System.Windows.Forms.TextBox txtStokDurumu;
        private System.Windows.Forms.Button button1;
    }
}