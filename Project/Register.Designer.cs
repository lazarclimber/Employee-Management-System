namespace Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            registerBtn = new Button();
            registerLabel = new Label();
            labelHeading = new Label();
            pictureBox1 = new PictureBox();
            signupBtn = new Button();
            checkBoxPassReg = new CheckBox();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            loginLabel = new Label();
            exitAppReg = new Label();
            confPassInput = new TextBox();
            confirmPasslabel = new Label();
            passwordMatchLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(labelHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 539);
            panel1.TabIndex = 1;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Maroon;
            registerBtn.FlatStyle = FlatStyle.Popup;
            registerBtn.Font = new Font("Arial Unicode MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = SystemColors.Control;
            registerBtn.Location = new Point(47, 490);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(217, 37);
            registerBtn.TabIndex = 3;
            registerBtn.Text = "SIGN IN";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = SystemColors.Control;
            registerLabel.Location = new Point(89, 458);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(143, 17);
            registerLabel.TabIndex = 2;
            registerLabel.Text = "Sign in to your Account";
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHeading.ForeColor = SystemColors.Control;
            labelHeading.Location = new Point(12, 273);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(282, 26);
            labelHeading.TabIndex = 1;
            labelHeading.Text = "Employee Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.Brown;
            signupBtn.FlatStyle = FlatStyle.Flat;
            signupBtn.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupBtn.ForeColor = SystemColors.Control;
            signupBtn.Location = new Point(334, 435);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(109, 40);
            signupBtn.TabIndex = 16;
            signupBtn.Text = "SIGNUP";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += loginBtn_Click;
            // 
            // checkBoxPassReg
            // 
            checkBoxPassReg.AutoSize = true;
            checkBoxPassReg.Location = new Point(530, 387);
            checkBoxPassReg.Name = "checkBoxPassReg";
            checkBoxPassReg.Size = new Size(108, 19);
            checkBoxPassReg.TabIndex = 15;
            checkBoxPassReg.Text = "Show Password";
            checkBoxPassReg.UseVisualStyleBackColor = true;
            checkBoxPassReg.CheckedChanged += checkBoxPassReg_CheckedChanged;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(334, 281);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(304, 27);
            passwordInput.TabIndex = 14;
            passwordInput.UseSystemPasswordChar = true;
            passwordInput.TextChanged += passwordInput_TextChanged;
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameInput.Location = new Point(334, 208);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(304, 27);
            usernameInput.TabIndex = 13;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(334, 258);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(334, 185);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "Username:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(353, 71);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(185, 24);
            loginLabel.TabIndex = 10;
            loginLabel.Text = "Register Account";
            // 
            // exitAppReg
            // 
            exitAppReg.AutoSize = true;
            exitAppReg.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitAppReg.Location = new Point(622, 9);
            exitAppReg.Name = "exitAppReg";
            exitAppReg.Size = new Size(29, 29);
            exitAppReg.TabIndex = 9;
            exitAppReg.Text = "X";
            exitAppReg.Click += exitAppReg_Click;
            exitAppReg.MouseLeave += exitAppReg_MouseLeave;
            exitAppReg.MouseHover += exitAppReg_MouseHover;
            // 
            // confPassInput
            // 
            confPassInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confPassInput.Location = new Point(334, 354);
            confPassInput.Name = "confPassInput";
            confPassInput.Size = new Size(304, 27);
            confPassInput.TabIndex = 17;
            confPassInput.UseSystemPasswordChar = true;
            confPassInput.TextChanged += confPassInput_TextChanged;
            // 
            // confirmPasslabel
            // 
            confirmPasslabel.AutoSize = true;
            confirmPasslabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasslabel.Location = new Point(334, 331);
            confirmPasslabel.Name = "confirmPasslabel";
            confirmPasslabel.Size = new Size(130, 20);
            confirmPasslabel.TabIndex = 18;
            confirmPasslabel.Text = "Confirm Password:";
            // 
            // passwordMatchLbl
            // 
            passwordMatchLbl.AutoSize = true;
            passwordMatchLbl.ForeColor = Color.DarkGreen;
            passwordMatchLbl.Location = new Point(334, 391);
            passwordMatchLbl.Name = "passwordMatchLbl";
            passwordMatchLbl.Size = new Size(0, 15);
            passwordMatchLbl.TabIndex = 19;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 539);
            Controls.Add(passwordMatchLbl);
            Controls.Add(confirmPasslabel);
            Controls.Add(confPassInput);
            Controls.Add(signupBtn);
            Controls.Add(checkBoxPassReg);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(loginLabel);
            Controls.Add(exitAppReg);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button registerBtn;
        private Label registerLabel;
        private Label labelHeading;
        private PictureBox pictureBox1;
        private Button signupBtn;
        private CheckBox checkBoxPassReg;
        private TextBox passwordInput;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label loginLabel;
        private Label exitAppReg;
        private TextBox confPassInput;
        private Label confirmPasslabel;
        private Label passwordMatchLbl;
        public TextBox usernameInput;
    }
}