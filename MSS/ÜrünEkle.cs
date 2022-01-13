using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MSS
{
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C: \Users\Yigit\Desktop\visual proje\MSS\MSS\Database11.accdb");

        private void ÜrünEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("İnsert into urun(Ürün Adı,Geliş Fiyatı,Satış Fiyatı,Kar Miktarı,Stok) values (@Ürün Adı,@Geliş Fiyatı,@Satış Fiyatı,@Kar Miktarı,@Stok)", baglantı);
            komut.Parameters.AddWithValue("@Ürün Adı", txtÜrünAdi.Text);
            komut.Parameters.AddWithValue("@Geliş Fiyatı", txtÜrünGelis.Text);
            komut.Parameters.AddWithValue("@Satış Fiyatı", txtÜrünSatıs.Text);
            komut.Parameters.AddWithValue("@Kar Miktarı", txtKar.Text);
            komut.Parameters.AddWithValue("@Stok", txtStokDurumu.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ürün eklendi.");
            foreach(Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
