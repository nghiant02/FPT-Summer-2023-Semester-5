namespace PRN211_nghiant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Equals("admin") && password.Equals("1234"))
            {
                // dang nhap thanh cong
                //MessageBox.Show("Dang nhap thanh cong", "Thong bao", MessageBoxButtons.OK);

                this.Hide();
                Form form = new Management();
                form.ShowDialog();
            }
            else
            {
                // dang nhap that bai
                MessageBox.Show("Dang nhap that bai", "Thong bao", MessageBoxButtons.OK);
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
