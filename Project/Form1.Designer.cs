namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            registerBtn = new Button();
            registerLabel = new Label();
            labelHeading = new Label();
            pictureBox1 = new PictureBox();
            exitApp = new Label();
            loginLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            showPasswordCheckBox = new CheckBox();
            loginBtn = new Button();
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
            panel1.TabIndex = 0;
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
            registerBtn.Text = "SIGNUP";
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
            registerLabel.Size = new Size(136, 17);
            registerLabel.TabIndex = 2;
            registerLabel.Text = "Register your Account";
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
            // exitApp
            // 
            exitApp.AutoSize = true;
            exitApp.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitApp.Location = new Point(622, 9);
            exitApp.Name = "exitApp";
            exitApp.Size = new Size(29, 29);
            exitApp.TabIndex = 1;
            exitApp.Text = "X";
            exitApp.Click += exitApp_Click;
            exitApp.MouseLeave += exitApp_MouseLeave;
            exitApp.MouseHover += exitApp_MouseHover;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(353, 116);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(158, 24);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Login Account";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(334, 235);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(78, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(334, 315);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameInput.Location = new Point(334, 258);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(304, 27);
            usernameInput.TabIndex = 5;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(334, 338);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(304, 27);
            passwordInput.TabIndex = 6;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Location = new Point(530, 371);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(108, 19);
            showPasswordCheckBox.TabIndex = 7;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Brown;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.Control;
            loginBtn.Location = new Point(334, 416);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(109, 40);
            loginBtn.TabIndex = 8;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 539);
            Controls.Add(loginBtn);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(loginLabel);
            Controls.Add(exitApp);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exitApp;
        private Label loginLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordInput;
        private CheckBox showPasswordCheckBox;
        private Button loginBtn;
        private PictureBox pictureBox1;
        private Label registerLabel;
        private Label labelHeading;
        private Button registerBtn;
        public TextBox usernameInput;
    }
}
