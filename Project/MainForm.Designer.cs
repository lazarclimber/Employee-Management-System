namespace Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            exitAppReg = new Label();
            mainFormLabel = new Label();
            panel2 = new Panel();
            signOutLbl = new Label();
            pictureBox2 = new PictureBox();
            salaryBtn = new Button();
            addEmployeeBtn = new Button();
            menuBtn = new Button();
            welcomeUserLbl = new Label();
            pictureBox1 = new PictureBox();
            salary1 = new Salary();
            addEmployee1 = new AddEmployee();
            menu1 = new Menu();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(exitAppReg);
            panel1.Controls.Add(mainFormLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 48);
            panel1.TabIndex = 0;
            // 
            // exitAppReg
            // 
            exitAppReg.AutoSize = true;
            exitAppReg.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitAppReg.Location = new Point(1064, 8);
            exitAppReg.Name = "exitAppReg";
            exitAppReg.Size = new Size(29, 29);
            exitAppReg.TabIndex = 10;
            exitAppReg.Text = "X";
            exitAppReg.Click += exitAppReg_Click;
            exitAppReg.MouseLeave += exitAppReg_MouseLeave;
            exitAppReg.MouseHover += exitAppReg_MouseHover;
            // 
            // mainFormLabel
            // 
            mainFormLabel.AutoSize = true;
            mainFormLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            mainFormLabel.Location = new Point(21, 13);
            mainFormLabel.Name = "mainFormLabel";
            mainFormLabel.Size = new Size(240, 21);
            mainFormLabel.TabIndex = 0;
            mainFormLabel.Text = "Employee Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Brown;
            panel2.Controls.Add(signOutLbl);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(salaryBtn);
            panel2.Controls.Add(addEmployeeBtn);
            panel2.Controls.Add(menuBtn);
            panel2.Controls.Add(welcomeUserLbl);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 550);
            panel2.TabIndex = 1;
            // 
            // signOutLbl
            // 
            signOutLbl.AutoSize = true;
            signOutLbl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            signOutLbl.Location = new Point(69, 509);
            signOutLbl.Name = "signOutLbl";
            signOutLbl.Size = new Size(65, 19);
            signOutLbl.TabIndex = 6;
            signOutLbl.Text = "Sign Out";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 494);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // salaryBtn
            // 
            salaryBtn.BackColor = Color.Brown;
            salaryBtn.FlatStyle = FlatStyle.Flat;
            salaryBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            salaryBtn.ForeColor = SystemColors.Control;
            salaryBtn.Location = new Point(15, 350);
            salaryBtn.Name = "salaryBtn";
            salaryBtn.Size = new Size(200, 48);
            salaryBtn.TabIndex = 4;
            salaryBtn.Text = "SALARY";
            salaryBtn.UseVisualStyleBackColor = false;
            salaryBtn.Click += salaryBtn_Click;
            // 
            // addEmployeeBtn
            // 
            addEmployeeBtn.BackColor = Color.Brown;
            addEmployeeBtn.FlatStyle = FlatStyle.Flat;
            addEmployeeBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            addEmployeeBtn.ForeColor = SystemColors.Control;
            addEmployeeBtn.Location = new Point(15, 280);
            addEmployeeBtn.Name = "addEmployeeBtn";
            addEmployeeBtn.Size = new Size(200, 48);
            addEmployeeBtn.TabIndex = 3;
            addEmployeeBtn.Text = "ADD EMPLOYEE";
            addEmployeeBtn.UseVisualStyleBackColor = false;
            addEmployeeBtn.Click += addEmployeeBtn_Click;
            // 
            // menuBtn
            // 
            menuBtn.BackColor = Color.Brown;
            menuBtn.FlatStyle = FlatStyle.Flat;
            menuBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuBtn.ForeColor = SystemColors.Control;
            menuBtn.Location = new Point(15, 210);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(200, 48);
            menuBtn.TabIndex = 2;
            menuBtn.Text = "MENU";
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // welcomeUserLbl
            // 
            welcomeUserLbl.AutoSize = true;
            welcomeUserLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeUserLbl.Location = new Point(46, 159);
            welcomeUserLbl.Name = "welcomeUserLbl";
            welcomeUserLbl.Size = new Size(0, 25);
            welcomeUserLbl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // salary1
            // 
            salary1.ForeColor = Color.Black;
            salary1.Location = new Point(230, 48);
            salary1.Name = "salary1";
            salary1.Size = new Size(876, 550);
            salary1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            addEmployee1.BackColor = Color.Transparent;
            addEmployee1.ForeColor = Color.Black;
            addEmployee1.Location = new Point(230, 48);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(876, 550);
            addEmployee1.TabIndex = 3;
            // 
            // menu1
            // 
            menu1.BorderStyle = BorderStyle.FixedSingle;
            menu1.Location = new Point(230, 48);
            menu1.Name = "menu1";
            menu1.Size = new Size(876, 550);
            menu1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 598);
            Controls.Add(menu1);
            Controls.Add(addEmployee1);
            Controls.Add(salary1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label mainFormLabel;
        private PictureBox pictureBox1;
        private Label welcomeUserLbl;
        private Label exitAppReg;
        private Button menuBtn;
        private Button salaryBtn;
        private Button addEmployeeBtn;
        private Salary salary1;
        private AddEmployee addEmployee1;
        private Menu menu1;
        private Label signOutLbl;
        private PictureBox pictureBox2;
    }
}