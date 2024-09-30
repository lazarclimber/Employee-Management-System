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

namespace Project
{
    public partial class Salary : UserControl
    {
        public Salary()
        {
            InitializeComponent();
        }

        public void displayData()
        {
            string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string sql = "select employee_id, full_name, position, salary from employees";
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
            displayData();
            clear();
        }

        public void clear()
        {
            employeeIDText.Text = "";
            fullNameText.Text = "";
            positionText.Text = "";
            salaryText.Text = "";
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            displayData();
            employeeIDText.Enabled = false;
            fullNameText.Enabled = false;
            positionText.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                employeeIDText.Text = row.Cells[0].Value.ToString();
                fullNameText.Text = row.Cells[1].Value.ToString();
                positionText.Text = row.Cells[2].Value.ToString();
                salaryText.Text = row.Cells[3].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (employeeIDText.Text != "" && fullNameText.Text != "" && positionText.Text != "" && salaryText.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to update salary to {fullNameText.Text}?", "Update conformation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
                        SqlConnection con = new SqlConnection(connstring);
                        con.Open();

                        string sql = "update employees set salary = '" + salaryText.Text + "' where employee_id = '" + employeeIDText.Text + "' ";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        salaryText.Text = "";
                        MessageBox.Show("Successfully Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                        //Show table after input
                        displayData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("You must fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
