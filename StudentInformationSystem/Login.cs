namespace StudentInformationSystem
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboardPage = new Dashboard();
            dashboardPage.Show();
            this.Hide();    
        }

        private void groupLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
