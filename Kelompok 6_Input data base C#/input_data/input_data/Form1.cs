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

namespace input_data
{
    public partial class Form1 : Form
    {
        string database = "server = localhost; database= db_mahasiswa; uid = root; pwd=''";
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public Form1()
        {
            InitializeComponent();
        }
        public void konek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Open();
        }
        public void diskonek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Close();
        }
        public DataTable baca()
        {
            string sql = "select * from mhs";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                this.dt.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            diskonek();
            return dt;
        }
        public void Input(string query)
        {
            koneksi = new MySqlConnection(database);
            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }
        public void Update()
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();

                string update = "UPDATE mhs SET nama='" + txtNama.Text + "',jeniskelamin ='" + txtJk.Text + "',alamat = '" + txtAlamat.Text + "',kelas = '" + txtKelas.Text + "'WHERE nim ='" + txtNim.Text + "'";
                cmd = new MySqlCommand(update, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Update data berhasil");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Delete()
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();

                string delete = "DELETE FROM mhs WHERE nim='" + txtNim.Text + "'";
                cmd = new MySqlCommand(delete, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInput_Click(object sender, EventArgs e)
        {
               Input("insert into mhs values('" + this.txtNim.Text + "','" + this.txtNama.Text + "','" + this.txtJk.Text + "','" + this.txtKelas.Text + "','" + this.txtAlamat.Text + "')");
                MessageBox.Show("Insert Data Berhasil");
                baca();

        }

        private void btCari_Click(object sender, EventArgs e)
        {
            txtNim.Text = "";
            txtNama.Text = "";
            txtJk.Text = "";
            txtKelas.Text = "";
            txtAlamat.Text = "";

            baca();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Update();
            baca();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            Delete();
            baca();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
