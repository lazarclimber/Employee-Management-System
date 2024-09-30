namespace Project
{
    public partial class MainForm : Form
    {
        private Form1 form;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            form = new Form1();
            welcomeUserLbl.Text = "Welcome User";
     
        }

        private void exitAppReg_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void exitAppReg_MouseHover(object sender, EventArgs e)
        {
            exitAppReg.BackColor = Color.White;
            exitAppReg.ForeColor = Color.Brown;
        }

        private void exitAppReg_MouseLeave(object sender, EventArgs e)
        {
            exitAppReg.BackColor = Color.Brown;
            exitAppReg.ForeColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirmation message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            menu1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

            Menu menu = menu1 as Menu;

            if(menu != null)
                menu.RefreshData();
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            menu1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;

            AddEmployee emp = addEmployee1 as AddEmployee;

            if (emp != null)
                emp.RefreshData(); 
        }

        private void salaryBtn_Click(object sender, EventArgs e)
        {
            menu1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;

            Salary salary = salary1 as Salary;

            if(salary != null)
            {
                salary.RefreshData();
            }
        }
    }

}
