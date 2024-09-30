using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            employeeIDInput.Text = "";
            fullNameInput.Text = "";
            genderInput.Text = "";
            phoneNumInput.Text = "";
            positionInput.Text = "";
            statusInput.Text = "";
            pictureBoxHolder.Image = null;
        }

        public void DisplayData()
        {
            string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string sql = "select * from employees";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)Refresh);
                return;
            }
            DisplayData();
            
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeIDInput.Text != "" && fullNameInput.Text != "" && genderInput.Text != "" && phoneNumInput.Text != "" && positionInput.Text != "" && pictureBoxHolder.Image != null && statusInput.Text != "")
                {
                    //============ Input values into table ============//
                    string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
                    SqlConnection con = new SqlConnection(connstring);
                    con.Open();
                    string checkEmployee = "select count (*) from employees where employee_id = '" + employeeIDInput.Text + "'";
                    using (SqlCommand check = new SqlCommand(checkEmployee, con))
                    {
                        int count = (int)check.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show("That Employee ID already exist!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //======== import image ==========//
                            string path = Path.Combine(@"C:\projekti visual studio\C#\Windows Form Application\Login Form2\Project\Project\Directory\" + employeeIDInput.Text + ".jpg");
                            string directoryPath = Path.GetDirectoryName(path);
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }
                            File.Copy(pictureBoxHolder.ImageLocation, path, true);
                            //============//
                            string sql = "insert into employees (employee_id, full_name, gender, contact_number, position, image, insert_date, status) values('" + employeeIDInput.Text + "', '" + fullNameInput.Text + "', '" + genderInput.Text + "', '" + phoneNumInput.Text + "', '" + positionInput.Text + "', '" + path + "', getDate(), '" + statusInput.Text + "')";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            Clear();
                            MessageBox.Show("Successfully Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();

                            //Show table after input
                            DisplayData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please input all the fields!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to update {fullNameInput.Text}?", "Update conformation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (employeeIDInput.Text != "" && fullNameInput.Text != "" && genderInput.Text != "" && phoneNumInput.Text != "" && positionInput.Text != "" && pictureBoxHolder.Image != null && statusInput.Text != "")
                    {
                        //=========== Update values from table ============//
                        string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
                        SqlConnection con = new SqlConnection(connstring);
                        con.Open();

                        string sql = "update employees set full_name = '" + fullNameInput.Text + "', gender = '" + genderInput.Text + "', contact_number = '" + phoneNumInput.Text + "', position = '" + positionInput.Text + "', update_date = getDate(), status = '" + statusInput.Text + "' where employee_id = '" + employeeIDInput.Text + "';";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        Clear();
                        MessageBox.Show("Successfully Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                        //Show table after input
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Please input all the fields!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(dialogResult == DialogResult.No)
            {

            }
             
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {fullNameInput.Text}?", "Delete conformation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (employeeIDInput.Text != "")
                    {
                        string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
                        SqlConnection con = new SqlConnection(connstring);
                        con.Open();
                        string sql = "delete from employees where employee_id = '" + employeeIDInput.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        Clear();
                        MessageBox.Show("Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Put employee_id");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Employee ID doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(dialogResult == DialogResult.No)
            {
                
            }
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void importImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    pictureBoxHolder.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                employeeIDInput.Text = row.Cells[1].Value.ToString();
                fullNameInput.Text = row.Cells[2].Value.ToString();
                genderInput.Text = row.Cells[3].Value.ToString();
                phoneNumInput.Text = row.Cells[4].Value.ToString();
                positionInput.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                try
                {
                    if (imagePath != null)
                    {
                        pictureBoxHolder.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        pictureBoxHolder.Image = null;
                    }
                }
                catch
                {

                }
                

                statusInput.Text = row.Cells[10].Value.ToString();
            }
        }
    }
}
