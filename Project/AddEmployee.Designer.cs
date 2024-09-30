namespace Project
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            addBtn = new Button();
            clearBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            importImgBtn = new Button();
            pictureBoxHolder = new PictureBox();
            statusInput = new ComboBox();
            positionInput = new ComboBox();
            phoneNumInput = new TextBox();
            fullNameInput = new TextBox();
            employeeIDInput = new TextBox();
            statusLbl = new Label();
            positionLbl = new Label();
            phoneNumberLbl = new Label();
            genderLbl = new Label();
            genderInput = new ComboBox();
            fullNameLbl = new Label();
            employeeidLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHolder).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 281);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(788, 202);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee's Data";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(clearBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(importImgBtn);
            panel2.Controls.Add(pictureBoxHolder);
            panel2.Controls.Add(statusInput);
            panel2.Controls.Add(positionInput);
            panel2.Controls.Add(phoneNumInput);
            panel2.Controls.Add(fullNameInput);
            panel2.Controls.Add(employeeIDInput);
            panel2.Controls.Add(statusLbl);
            panel2.Controls.Add(positionLbl);
            panel2.Controls.Add(phoneNumberLbl);
            panel2.Controls.Add(genderLbl);
            panel2.Controls.Add(genderInput);
            panel2.Controls.Add(fullNameLbl);
            panel2.Controls.Add(employeeidLbl);
            panel2.Location = new Point(17, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 214);
            panel2.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Brown;
            addBtn.FlatAppearance.BorderColor = Color.Brown;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            addBtn.ForeColor = SystemColors.Control;
            addBtn.Location = new Point(200, 164);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 41);
            addBtn.TabIndex = 12;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += AddBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Brown;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            clearBtn.ForeColor = SystemColors.Control;
            clearBtn.Location = new Point(560, 164);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 41);
            clearBtn.TabIndex = 12;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Brown;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            deleteBtn.ForeColor = SystemColors.Control;
            deleteBtn.Location = new Point(440, 164);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 41);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Brown;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            updateBtn.ForeColor = SystemColors.Control;
            updateBtn.Location = new Point(320, 164);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 41);
            updateBtn.TabIndex = 12;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // importImgBtn
            // 
            importImgBtn.BackColor = Color.Brown;
            importImgBtn.FlatAppearance.BorderSize = 0;
            importImgBtn.FlatStyle = FlatStyle.Flat;
            importImgBtn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            importImgBtn.ForeColor = SystemColors.Control;
            importImgBtn.Location = new Point(727, 138);
            importImgBtn.Name = "importImgBtn";
            importImgBtn.Size = new Size(86, 27);
            importImgBtn.TabIndex = 11;
            importImgBtn.Text = "Import";
            importImgBtn.UseVisualStyleBackColor = false;
            importImgBtn.Click += importImgBtn_Click;
            // 
            // pictureBoxHolder
            // 
            pictureBoxHolder.BackColor = SystemColors.ControlDark;
            pictureBoxHolder.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHolder.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHolder.Location = new Point(727, 34);
            pictureBoxHolder.Name = "pictureBoxHolder";
            pictureBoxHolder.Size = new Size(86, 104);
            pictureBoxHolder.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHolder.TabIndex = 10;
            pictureBoxHolder.TabStop = false;
            // 
            // statusInput
            // 
            statusInput.FormattingEnabled = true;
            statusInput.Items.AddRange(new object[] { "Active", "Inactive" });
            statusInput.Location = new Point(483, 112);
            statusInput.Name = "statusInput";
            statusInput.Size = new Size(139, 23);
            statusInput.TabIndex = 9;
            // 
            // positionInput
            // 
            positionInput.FormattingEnabled = true;
            positionInput.Items.AddRange(new object[] { "Admin", "Front-End Developer", "Back-End Developer", "QA Tester", "UI/UX Design" });
            positionInput.Location = new Point(483, 73);
            positionInput.Name = "positionInput";
            positionInput.Size = new Size(139, 23);
            positionInput.TabIndex = 8;
            // 
            // phoneNumInput
            // 
            phoneNumInput.Location = new Point(483, 31);
            phoneNumInput.Name = "phoneNumInput";
            phoneNumInput.Size = new Size(116, 23);
            phoneNumInput.TabIndex = 7;
            // 
            // fullNameInput
            // 
            fullNameInput.Location = new Point(128, 73);
            fullNameInput.Name = "fullNameInput";
            fullNameInput.Size = new Size(139, 23);
            fullNameInput.TabIndex = 6;
            // 
            // employeeIDInput
            // 
            employeeIDInput.Location = new Point(128, 31);
            employeeIDInput.Name = "employeeIDInput";
            employeeIDInput.Size = new Size(108, 23);
            employeeIDInput.TabIndex = 6;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.ForeColor = Color.Black;
            statusLbl.Location = new Point(435, 115);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(42, 15);
            statusLbl.TabIndex = 5;
            statusLbl.Text = "Status:";
            // 
            // positionLbl
            // 
            positionLbl.AutoSize = true;
            positionLbl.ForeColor = Color.Black;
            positionLbl.Location = new Point(424, 76);
            positionLbl.Name = "positionLbl";
            positionLbl.Size = new Size(53, 15);
            positionLbl.TabIndex = 4;
            positionLbl.Text = "Position:";
            // 
            // phoneNumberLbl
            // 
            phoneNumberLbl.AutoSize = true;
            phoneNumberLbl.ForeColor = Color.Black;
            phoneNumberLbl.Location = new Point(386, 34);
            phoneNumberLbl.Name = "phoneNumberLbl";
            phoneNumberLbl.Size = new Size(91, 15);
            phoneNumberLbl.TabIndex = 3;
            phoneNumberLbl.Text = "Phone Number:";
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.ForeColor = Color.Black;
            genderLbl.Location = new Point(74, 118);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(48, 15);
            genderLbl.TabIndex = 2;
            genderLbl.Text = "Gender:";
            // 
            // genderInput
            // 
            genderInput.FormattingEnabled = true;
            genderInput.Items.AddRange(new object[] { "Male", "Female" });
            genderInput.Location = new Point(128, 115);
            genderInput.Name = "genderInput";
            genderInput.Size = new Size(139, 23);
            genderInput.TabIndex = 1;
            // 
            // fullNameLbl
            // 
            fullNameLbl.AutoSize = true;
            fullNameLbl.ForeColor = Color.Black;
            fullNameLbl.Location = new Point(58, 76);
            fullNameLbl.Name = "fullNameLbl";
            fullNameLbl.Size = new Size(64, 15);
            fullNameLbl.TabIndex = 0;
            fullNameLbl.Text = "Full Name:";
            // 
            // employeeidLbl
            // 
            employeeidLbl.AutoSize = true;
            employeeidLbl.ForeColor = Color.Black;
            employeeidLbl.Location = new Point(46, 34);
            employeeidLbl.Name = "employeeidLbl";
            employeeidLbl.Size = new Size(76, 15);
            employeeidLbl.TabIndex = 0;
            employeeidLbl.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(876, 550);
            Load += AddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHolder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label fullNameLbl;
        private Label employeeidLbl;
        private Label genderLbl;
        private ComboBox genderInput;
        private Label phoneNumberLbl;
        private TextBox fullNameInput;
        private TextBox employeeIDInput;
        private Label statusLbl;
        private Label positionLbl;
        private ComboBox statusInput;
        private ComboBox positionInput;
        private TextBox phoneNumInput;
        private Button importImgBtn;
        private PictureBox pictureBoxHolder;
        private Button updateBtn;
        private Button addBtn;
        private Button clearBtn;
        private Button deleteBtn;
    }
}
