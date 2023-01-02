namespace Luna_Hotel
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Abdalrhman" && textBox2.Text == "1907")
            {
                this.Hide();
                open Open = new open();
                Open.Show();
            }
            else
            {
                MessageBox.Show("wrong user name or password.       ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}