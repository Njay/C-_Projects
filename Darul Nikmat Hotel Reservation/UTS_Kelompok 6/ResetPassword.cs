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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }
        string database = "server = localhost; database= user_db; uid = root; pwd=''";
        public MySqlConnection koneksi;
        public MySqlCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();

                string update = "UPDATE user SET password = '"+textBox3.Text + "' WHERE id ='" + textBox1.Text + "'";
                cmd = new MySqlCommand(update, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Password Changed!, Redirecting to Login Form");
                Login l = new Login();
                l.Show(); this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show(); this.Hide();
        }
    }
}
