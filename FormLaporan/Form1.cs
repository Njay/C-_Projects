using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormLaporan
{
    public partial class Form1 : Form { 

        public string database = "server = localhost; database= db_mahasiswa; uid = root; pwd=''";
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
    
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        public DataTable tampil()
        {
            string sql = "SELECT * FROM mhs";
            DataTable dt = new DataTable();
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                cmd = new MySqlCommand(sql,koneksi);
                adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                bindingSource1.DataSource= dt;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            koneksi.Close();
            return dt;
        }

        public void ketextbox()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["nim"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["nama"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["jeniskelamin"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["kelas"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["alamat"].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ketextbox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.DefaultPageSettings.Landscape = false;
            printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var font = new Font("Khmer UI", 12);
            e.Graphics.DrawString("\t\t\t Data Mahasiswa /n/n/n", font, Brushes.Black, 25, 10);
            e.Graphics.DrawString("NIM              \t:" + textBox1.Text + "\n\n", font, Brushes.Black, 20, 30);
            e.Graphics.DrawString("Nama              \t:" + textBox2.Text + "\n\n", font, Brushes.Black, 20, 50);
            e.Graphics.DrawString("Jenis Kelamin              \t:" + textBox3.Text + "\n\n", font, Brushes.Black, 20, 80);
            e.Graphics.DrawString("Kelas              \t:" + textBox4.Text + "\n\n", font, Brushes.Black, 20, 110);
            e.Graphics.DrawString("Alamat              \t:" + textBox5.Text + "\n\n", font, Brushes.Black, 20, 130);


        }
        
            
        
    }
}
