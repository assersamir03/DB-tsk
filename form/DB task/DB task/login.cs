namespace DB_task
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && password.Text == "")
            {
                MessageBox.Show("Please enter username and password");
            }

            if (username.Text == "admin" && password.Text == "admin")
            {
                this.Hide();
                Employee dashboard = new Employee();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

    }
}