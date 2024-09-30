using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void checkBoxPassReg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassReg.Checked)
            {
                passwordInput.UseSystemPasswordChar = false;
                confPassInput.UseSystemPasswordChar = false;
            }
            else
            {
                passwordInput.UseSystemPasswordChar = true;
                confPassInput.UseSystemPasswordChar = true;
            }
        }



        private void exitAppReg_Click(object sender, EventArgs e)
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
        private void exitAppReg_MouseHover(object sender, EventArgs e)
        {
            exitAppReg.BackColor = Color.Black;
            exitAppReg.ForeColor = Color.White;
        }

        private void exitAppReg_MouseLeave(object sender, EventArgs e)
        {
            exitAppReg.BackColor = Control.DefaultBackColor;
            exitAppReg.ForeColor = Color.Black;
        }

        bool validInputs = false;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "" || passwordInput.Text == "" || confPassInput.Text == "")
            {
                MessageBox.Show("Please input all fields!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int lengthString = passwordInput.TextLength;
                if (validInputs == true)
                {
                    string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
                    SqlConnection con = new SqlConnection(connstring);
                    con.Open();
                    //Check if user exists
                    string username = usernameInput.Text;
                    string password = passwordInput.Text;
                    string checkUser = "select count(*) from admins where username = '" + username + "'";
                    using (SqlCommand check = new SqlCommand(checkUser, con))
                    {
                        int count = (int)check.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show("This username is already taken!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }   
                        else if (passwordInput.Text != confPassInput.Text)
                        {
                            MessageBox.Show("Passwords dont match!", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (passwordInput.Text == confPassInput.Text && lengthString > 5)
                        {
                            string sql = "Insert into admins (username, password, date_register) values('" + username + "', '" + password + "', getdate())";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                            MessageBox.Show($"Registered successfully. Welcome {username}", "Account information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }

            

        }
        
        private void confPassInput_TextChanged(object sender, EventArgs e)
        {
            int lengthString = passwordInput.TextLength;
            if (passwordInput.Text != confPassInput.Text)
            {
                passwordMatchLbl.Text = "Passwords don't match";
                passwordMatchLbl.ForeColor = Color.Red;
                validInputs = false;
            }
            else if(passwordInput.Text == "" && confPassInput.Text == "")
            {
                passwordMatchLbl.Text = "";
                validInputs = false;
            }
            else if (lengthString <= 5)
            {
                passwordMatchLbl.Text = "Password is weak!";
                passwordMatchLbl.ForeColor = Color.Red;
                validInputs = false;
            }
            else if (passwordInput.Text == confPassInput.Text)
            {
                passwordMatchLbl.Text = "Passwords match";
                passwordMatchLbl.ForeColor = Color.DarkGreen;
                validInputs = true;
            }
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            int lengthString = passwordInput.TextLength;
            if (passwordInput.Text != confPassInput.Text)
            {
                passwordMatchLbl.Text = "Passwords don't match";
                passwordMatchLbl.ForeColor = Color.Red;
            }
            else if (passwordInput.Text == "" && confPassInput.Text == "")
            {
                passwordMatchLbl.Text = "";
            }
            else if (lengthString <= 5)
            {
                passwordMatchLbl.Text = "Password is weak!";
                passwordMatchLbl.ForeColor = Color.Red;
            }
            else if (passwordInput.Text == confPassInput.Text)
            {
                passwordMatchLbl.Text = "Passwords match";
                passwordMatchLbl.ForeColor = Color.DarkGreen;
                validInputs = true;
            }
        }
    }
}
