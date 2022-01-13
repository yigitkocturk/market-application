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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        OleDbConnection Aconnection = new OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C: \Users\Yigit\Desktop\visual proje\MSS\MSS\Database11.accdb");
       
        private void Satis_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnÜrünEkleme_Click(object sender, EventArgs e)
        {
            ÜrünEkle ekle = new ÜrünEkle();
            ekle.ShowDialog();
        }
    }
}
