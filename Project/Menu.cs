using System.Data.SqlClient;

namespace Project
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            displayAllEmp();
            displayActEmp();
            displayInactEmp();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
                displayAllEmp();
                displayActEmp();
                displayInactEmp();
            
        }

        public void displayAllEmp()
        {
            string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string checkEmployee = "select count (*) from employees";
            using (SqlCommand check = new SqlCommand(checkEmployee, con))
            {
                int count = (int)check.ExecuteScalar();
                totalEmployeesLbl.Text = count.ToString();
            }
        }

        public void displayActEmp()
        {
            string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string checkEmployee = "select count (*) from employees where status = 'Active'";
            using (SqlCommand check = new SqlCommand(checkEmployee, con))
            {
                int count = (int)check.ExecuteScalar();
                activeEmployeesLbl.Text = count.ToString();
            }
        }

        public void displayInactEmp()
        {
            string connstring = "Data Source=DESKTOP-N8R81BJ\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string checkEmployee = "select count (*) from employees where status = 'Inactive'";
            using (SqlCommand check = new SqlCommand(checkEmployee, con))
            {
                int count = (int)check.ExecuteScalar();
                inactiveEmployeesLbl.Text = count.ToString();
            }
        }

    }
}
