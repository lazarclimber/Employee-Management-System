namespace Project
{
    partial class Salary
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
            clearBtn = new Button();
            updateBtn = new Button();
            salaryText = new TextBox();
            positionText = new TextBox();
            fullNameText = new TextBox();
            employeeIDText = new TextBox();
            salaryLbl = new Label();
            positionLbl = new Label();
            fullNameLbl = new Label();
            employeeIDLbl = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(salaryText);
            panel1.Controls.Add(positionText);
            panel1.Controls.Add(fullNameText);
            panel1.Controls.Add(employeeIDText);
            panel1.Controls.Add(salaryLbl);
            panel1.Controls.Add(positionLbl);
            panel1.Controls.Add(fullNameLbl);
            panel1.Controls.Add(employeeIDLbl);
            panel1.Location = new Point(17, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 510);
            panel1.TabIndex = 0;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Brown;
            clearBtn.FlatAppearance.BorderColor = Color.Brown;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            clearBtn.ForeColor = SystemColors.Control;
            clearBtn.Location = new Point(142, 314);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 41);
            clearBtn.TabIndex = 13;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Brown;
            updateBtn.FlatAppearance.BorderColor = Color.Brown;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            updateBtn.ForeColor = SystemColors.Control;
            updateBtn.Location = new Point(21, 314);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 41);
            updateBtn.TabIndex = 13;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // salaryText
            // 
            salaryText.Location = new Point(21, 230);
            salaryText.Name = "salaryText";
            salaryText.Size = new Size(215, 23);
            salaryText.TabIndex = 1;
            // 
            // positionText
            // 
            positionText.Location = new Point(21, 172);
            positionText.Name = "positionText";
            positionText.Size = new Size(215, 23);
            positionText.TabIndex = 1;
            // 
            // fullNameText
            // 
            fullNameText.Location = new Point(21, 114);
            fullNameText.Name = "fullNameText";
            fullNameText.Size = new Size(215, 23);
            fullNameText.TabIndex = 1;
            // 
            // employeeIDText
            // 
            employeeIDText.Location = new Point(21, 56);
            employeeIDText.Name = "employeeIDText";
            employeeIDText.Size = new Size(215, 23);
            employeeIDText.TabIndex = 1;
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.ForeColor = Color.Black;
            salaryLbl.Location = new Point(21, 212);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(41, 15);
            salaryLbl.TabIndex = 0;
            salaryLbl.Text = "Salary:";
            // 
            // positionLbl
            // 
            positionLbl.AutoSize = true;
            positionLbl.ForeColor = Color.Black;
            positionLbl.Location = new Point(21, 154);
            positionLbl.Name = "positionLbl";
            positionLbl.Size = new Size(53, 15);
            positionLbl.TabIndex = 0;
            positionLbl.Text = "Position:";
            // 
            // fullNameLbl
            // 
            fullNameLbl.AutoSize = true;
            fullNameLbl.ForeColor = Color.Black;
            fullNameLbl.Location = new Point(21, 96);
            fullNameLbl.Name = "fullNameLbl";
            fullNameLbl.Size = new Size(64, 15);
            fullNameLbl.TabIndex = 0;
            fullNameLbl.Text = "Full Name:";
            // 
            // employeeIDLbl
            // 
            employeeIDLbl.AutoSize = true;
            employeeIDLbl.ForeColor = Color.Black;
            employeeIDLbl.Location = new Point(21, 38);
            employeeIDLbl.Name = "employeeIDLbl";
            employeeIDLbl.Size = new Size(76, 15);
            employeeIDLbl.TabIndex = 0;
            employeeIDLbl.Text = "Employee ID:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(294, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 510);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(517, 430);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 11);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salary";
            Size = new Size(876, 550);
            Load += Salary_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox employeeIDText;
        private Label employeeIDLbl;
        private TextBox positionText;
        private TextBox fullNameText;
        private Label positionLbl;
        private Label fullNameLbl;
        private TextBox salaryText;
        private Label salaryLbl;
        private Button clearBtn;
        private Button updateBtn;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
