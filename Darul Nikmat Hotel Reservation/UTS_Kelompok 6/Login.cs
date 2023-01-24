using MySql.Data.MySqlClient;

namespace UTS_Kelompok_6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string database = "server = localhost; database= user_db; uid = root; pwd=''";
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataReader reader;

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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM user WHERE user='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Successfully Sign In!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 f = new Form2();
                    f.Show(); this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password not match!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetPassword rs = new ResetPassword();
            rs.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show(); this.Hide();
        }
    }
}