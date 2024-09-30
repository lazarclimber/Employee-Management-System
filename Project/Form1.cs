using System.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitApp_MouseHover(object sender, EventArgs e)
        {
            exitApp.BackColor = Color.Black;
            exitApp.ForeColor = Color.White;
        }

        private void exitApp_MouseLeave(object sender, EventArgs e)
        {
            exitApp.BackColor = Control.DefaultBackColor;
            exitApp.ForeColor = Color.Black;
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordInput.UseSystemPasswordChar = false;
            }
            else
            {
                passwordInput.UseSystemPasswordChar = true;
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            //Check if user exists
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string checkUser = "select count(*) from admins where username = '" + username + "' and password = '" + password + "'";
            using (SqlCommand check = new SqlCommand(checkUser, con))
            {
                int count = (int)check.ExecuteScalar();

                if (count >= 1)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                    MessageBox.Show("Login successfull!", "Account information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Wrong username or password!", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}