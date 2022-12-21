namespace UTS_Kelompok_6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;

            if (user.Equals("Arief") && pass.Equals("21041001"))
            {
                Form2 f = new Form2();
                f.Show(); this.Hide();

            }
            else if (user.Equals("Iqbal") && pass.Equals("21041009"))
            {
                Form2 f = new Form2();
                f.Show(); this.Hide();

            }
            else if (user.Equals("Kokoh") && pass.Equals("21041086"))
            {
                Form2 f = new Form2();
                f.Show(); this.Hide();

            }
            else if (user.Equals("Suhar") && pass.Equals("2104102"))
            {
                Form2 f = new Form2();
                f.Show(); this.Hide();

            }
            else if (user.Equals("Ulya") && pass.Equals("2104104"))
            {
                Form2 f = new Form2();
                f.Show(); this.Hide();

            }
            else
            {
                MessageBox.Show("Username atau Password Salah!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}