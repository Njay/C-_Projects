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
using System.Data;
namespace UTS_Kelompok_6
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        string database = "server = localhost; database= user_db; uid = root; pwd=''";
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;

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
        private void button1_Click(object sender, EventArgs e)
        {
            Input("insert into user values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text +"')");
            MessageBox.Show("Registered Succsessfully, Redirecting to Login Form");

            Login l = new Login();
            l.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show(); this.Hide();
        }
    }
}
