using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_Kelompok_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string  combo1, combo2, jml_makan, jml_minum;
            int hrg, qty_makanan, qty_minuman;
            double total = 0;

            combo1 = cbMakan.Text;
            combo2 = cbMinum.Text;
            jml_makan = txtJmlMkn.Text;
            jml_minum = txtJmlMnm.Text;

            qty_makanan = Convert.ToInt32(txtJmlMkn.Text);
            qty_minuman = Convert.ToInt32(txtJmlMnm.Text);

            if (combo1.Equals("Ayam Bakar"))
            {
                hrg = 10000;
                total = (hrg * qty_makanan);
                txtHrg.Text = hrg.ToString();
            }
            if (combo2.Equals("Es teh"))
            {

            }
        }
    }
}
