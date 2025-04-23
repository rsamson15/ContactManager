namespace Project1_CRUD_
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            cbAssignedEmployee = new ComboBox();
            btnClearAssignments = new Button();
            cbincomplete = new CheckBox();
            cbCompleted = new CheckBox();
            dtpDateAssigned = new DateTimePicker();
            btDelete = new Button();
            btEdit = new Button();
            btAdd = new Button();
            tbProblemDescription = new TextBox();
            tbPhone = new TextBox();
            tbAddress = new TextBox();
            tbOwnerLastName = new TextBox();
            tbOwnerFirstName = new TextBox();
            lbCompleted = new Label();
            lbProblemDescription = new Label();
            lbPhone = new Label();
            lbAddress = new Label();
            lbOwnerLastName = new Label();
            lbOwnerFirstName = new Label();
            lbDateAssigned = new Label();
            dvAssignments = new DataGridView();
            tabPage2 = new TabPage();
            btnClearEmployees = new Button();
            btClear = new Button();
            btSearch = new Button();
            tbSearchLastName = new TextBox();
            tbSearchFirstName = new TextBox();
            lbSearchLastName = new Label();
            lbSeachFirstName = new Label();
            lbSearchEmployeeID = new Label();
            dvEmployees = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            tblastname = new TextBox();
            lblastname = new Label();
            tbfirstname = new TextBox();
            lbfirstname = new Label();
            btnNewEmp = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvAssignments).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvEmployees).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1256, 452);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbAssignedEmployee);
            tabPage1.Controls.Add(btnClearAssignments);
            tabPage1.Controls.Add(cbincomplete);
            tabPage1.Controls.Add(cbCompleted);
            tabPage1.Controls.Add(dtpDateAssigned);
            tabPage1.Controls.Add(btDelete);
            tabPage1.Controls.Add(btEdit);
            tabPage1.Controls.Add(btAdd);
            tabPage1.Controls.Add(tbProblemDescription);
            tabPage1.Controls.Add(tbPhone);
            tabPage1.Controls.Add(tbAddress);
            tabPage1.Controls.Add(tbOwnerLastName);
            tabPage1.Controls.Add(tbOwnerFirstName);
            tabPage1.Controls.Add(lbCompleted);
            tabPage1.Controls.Add(lbProblemDescription);
            tabPage1.Controls.Add(lbPhone);
            tabPage1.Controls.Add(lbAddress);
            tabPage1.Controls.Add(lbOwnerLastName);
            tabPage1.Controls.Add(lbOwnerFirstName);
            tabPage1.Controls.Add(lbDateAssigned);
            tabPage1.Controls.Add(dvAssignments);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1248, 424);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Assignments";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 378);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 25;
            label1.Text = "Assigned Employee:";
            // 
            // cbAssignedEmployee
            // 
            cbAssignedEmployee.FormattingEnabled = true;
            cbAssignedEmployee.Location = new Point(535, 375);
            cbAssignedEmployee.Name = "cbAssignedEmployee";
            cbAssignedEmployee.Size = new Size(121, 23);
            cbAssignedEmployee.TabIndex = 24;
            // 
            // btnClearAssignments
            // 
            btnClearAssignments.Location = new Point(1073, 378);
            btnClearAssignments.Name = "btnClearAssignments";
            btnClearAssignments.Size = new Size(75, 23);
            btnClearAssignments.TabIndex = 23;
            btnClearAssignments.Text = "Clear";
            btnClearAssignments.UseVisualStyleBackColor = true;
            btnClearAssignments.Click += btnClearAssignments_Click;
            // 
            // cbincomplete
            // 
            cbincomplete.AutoSize = true;
            cbincomplete.Location = new Point(17, 15);
            cbincomplete.Name = "cbincomplete";
            cbincomplete.Size = new Size(213, 19);
            cbincomplete.TabIndex = 22;
            cbincomplete.Text = "Show Incomplete Assignment only.";
            cbincomplete.UseVisualStyleBackColor = true;
            cbincomplete.CheckedChanged += cbincomplete_CheckedChanged;
            // 
            // cbCompleted
            // 
            cbCompleted.AutoSize = true;
            cbCompleted.Location = new Point(748, 381);
            cbCompleted.Name = "cbCompleted";
            cbCompleted.Size = new Size(15, 14);
            cbCompleted.TabIndex = 21;
            cbCompleted.UseVisualStyleBackColor = true;
            // 
            // dtpDateAssigned
            // 
            dtpDateAssigned.Location = new Point(748, 345);
            dtpDateAssigned.Name = "dtpDateAssigned";
            dtpDateAssigned.Size = new Size(200, 23);
            dtpDateAssigned.TabIndex = 20;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(1164, 376);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 26);
            btDelete.TabIndex = 19;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(1164, 347);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(75, 23);
            btEdit.TabIndex = 18;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(1073, 349);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 17;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAddAssignment_Click;
            // 
            // tbProblemDescription
            // 
            tbProblemDescription.Location = new Point(535, 346);
            tbProblemDescription.Name = "tbProblemDescription";
            tbProblemDescription.Size = new Size(121, 23);
            tbProblemDescription.TabIndex = 15;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(294, 375);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(116, 23);
            tbPhone.TabIndex = 14;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(294, 346);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(116, 23);
            tbAddress.TabIndex = 13;
            // 
            // tbOwnerLastName
            // 
            tbOwnerLastName.Location = new Point(114, 375);
            tbOwnerLastName.Name = "tbOwnerLastName";
            tbOwnerLastName.Size = new Size(116, 23);
            tbOwnerLastName.TabIndex = 12;
            // 
            // tbOwnerFirstName
            // 
            tbOwnerFirstName.Location = new Point(114, 346);
            tbOwnerFirstName.Name = "tbOwnerFirstName";
            tbOwnerFirstName.Size = new Size(116, 23);
            tbOwnerFirstName.TabIndex = 11;
            // 
            // lbCompleted
            // 
            lbCompleted.AutoSize = true;
            lbCompleted.Location = new Point(662, 380);
            lbCompleted.Name = "lbCompleted";
            lbCompleted.Size = new Size(69, 15);
            lbCompleted.TabIndex = 9;
            lbCompleted.Text = "Completed:";
            // 
            // lbProblemDescription
            // 
            lbProblemDescription.AutoSize = true;
            lbProblemDescription.Location = new Point(416, 351);
            lbProblemDescription.Name = "lbProblemDescription";
            lbProblemDescription.Size = new Size(118, 15);
            lbProblemDescription.TabIndex = 8;
            lbProblemDescription.Text = "Problem Description:";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(244, 378);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(44, 15);
            lbPhone.TabIndex = 7;
            lbPhone.Text = "Phone:";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(236, 349);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(52, 15);
            lbAddress.TabIndex = 6;
            lbAddress.Text = "Address:";
            // 
            // lbOwnerLastName
            // 
            lbOwnerLastName.AutoSize = true;
            lbOwnerLastName.Location = new Point(7, 378);
            lbOwnerLastName.Name = "lbOwnerLastName";
            lbOwnerLastName.Size = new Size(101, 15);
            lbOwnerLastName.TabIndex = 5;
            lbOwnerLastName.Text = "Owner LastName:";
            // 
            // lbOwnerFirstName
            // 
            lbOwnerFirstName.AutoSize = true;
            lbOwnerFirstName.Location = new Point(6, 348);
            lbOwnerFirstName.Name = "lbOwnerFirstName";
            lbOwnerFirstName.Size = new Size(102, 15);
            lbOwnerFirstName.TabIndex = 4;
            lbOwnerFirstName.Text = "Owner FirstName:";
            // 
            // lbDateAssigned
            // 
            lbDateAssigned.AutoSize = true;
            lbDateAssigned.Location = new Point(662, 351);
            lbDateAssigned.Name = "lbDateAssigned";
            lbDateAssigned.Size = new Size(85, 15);
            lbDateAssigned.TabIndex = 3;
            lbDateAssigned.Text = "Date Assigned:";
            // 
            // dvAssignments
            // 
            dvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvAssignments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvAssignments.DefaultCellStyle = dataGridViewCellStyle1;
            dvAssignments.Location = new Point(7, 40);
            dvAssignments.Name = "dvAssignments";
            dvAssignments.Size = new Size(1232, 288);
            dvAssignments.TabIndex = 0;
            dvAssignments.CellClick += dvAssignments_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnClearEmployees);
            tabPage2.Controls.Add(btClear);
            tabPage2.Controls.Add(btSearch);
            tabPage2.Controls.Add(tbSearchLastName);
            tabPage2.Controls.Add(tbSearchFirstName);
            tabPage2.Controls.Add(lbSearchLastName);
            tabPage2.Controls.Add(lbSeachFirstName);
            tabPage2.Controls.Add(lbSearchEmployeeID);
            tabPage2.Controls.Add(dvEmployees);
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnEdit);
            tabPage2.Controls.Add(tblastname);
            tabPage2.Controls.Add(lblastname);
            tabPage2.Controls.Add(tbfirstname);
            tabPage2.Controls.Add(lbfirstname);
            tabPage2.Controls.Add(btnNewEmp);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1248, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Employees";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearEmployees
            // 
            btnClearEmployees.Location = new Point(676, 221);
            btnClearEmployees.Name = "btnClearEmployees";
            btnClearEmployees.Size = new Size(75, 23);
            btnClearEmployees.TabIndex = 17;
            btnClearEmployees.Text = "Clear";
            btnClearEmployees.UseVisualStyleBackColor = true;
            btnClearEmployees.Click += button1_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(444, 57);
            btClear.Name = "btClear";
            btClear.Size = new Size(96, 23);
            btClear.TabIndex = 16;
            btClear.Text = "Clear Search";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(342, 57);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(75, 23);
            btSearch.TabIndex = 15;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // tbSearchLastName
            // 
            tbSearchLastName.Location = new Point(185, 73);
            tbSearchLastName.Name = "tbSearchLastName";
            tbSearchLastName.Size = new Size(119, 23);
            tbSearchLastName.TabIndex = 14;
            // 
            // tbSearchFirstName
            // 
            tbSearchFirstName.Location = new Point(185, 44);
            tbSearchFirstName.Name = "tbSearchFirstName";
            tbSearchFirstName.Size = new Size(119, 23);
            tbSearchFirstName.TabIndex = 13;
            // 
            // lbSearchLastName
            // 
            lbSearchLastName.AutoSize = true;
            lbSearchLastName.Location = new Point(49, 76);
            lbSearchLastName.Name = "lbSearchLastName";
            lbSearchLastName.Size = new Size(104, 15);
            lbSearchLastName.TabIndex = 11;
            lbSearchLastName.Text = "Search Last Name:";
            // 
            // lbSeachFirstName
            // 
            lbSeachFirstName.AutoSize = true;
            lbSeachFirstName.Location = new Point(48, 47);
            lbSeachFirstName.Name = "lbSeachFirstName";
            lbSeachFirstName.Size = new Size(105, 15);
            lbSeachFirstName.TabIndex = 10;
            lbSeachFirstName.Text = "Search First Name:";
            // 
            // lbSearchEmployeeID
            // 
            lbSearchEmployeeID.AutoSize = true;
            lbSearchEmployeeID.Location = new Point(20, 19);
            lbSearchEmployeeID.Name = "lbSearchEmployeeID";
            lbSearchEmployeeID.Size = new Size(0, 15);
            lbSearchEmployeeID.TabIndex = 9;
            // 
            // dvEmployees
            // 
            dvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            dvEmployees.Location = new Point(39, 118);
            dvEmployees.Name = "dvEmployees";
            dvEmployees.Size = new Size(426, 249);
            dvEmployees.TabIndex = 8;
            dvEmployees.CellClick += dvEmployees_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(676, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(676, 163);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tblastname
            // 
            tblastname.Location = new Point(552, 160);
            tblastname.Name = "tblastname";
            tblastname.Size = new Size(100, 23);
            tblastname.TabIndex = 5;
            // 
            // lblastname
            // 
            lblastname.AutoSize = true;
            lblastname.Location = new Point(480, 163);
            lblastname.Name = "lblastname";
            lblastname.Size = new Size(66, 15);
            lblastname.TabIndex = 4;
            lblastname.Text = "Last Name:";
            // 
            // tbfirstname
            // 
            tbfirstname.Location = new Point(552, 131);
            tbfirstname.Name = "tbfirstname";
            tbfirstname.Size = new Size(100, 23);
            tbfirstname.TabIndex = 3;
            // 
            // lbfirstname
            // 
            lbfirstname.AutoSize = true;
            lbfirstname.Location = new Point(479, 134);
            lbfirstname.Name = "lbfirstname";
            lbfirstname.Size = new Size(67, 15);
            lbfirstname.TabIndex = 2;
            lbfirstname.Text = "First Name:";
            // 
            // btnNewEmp
            // 
            btnNewEmp.Location = new Point(676, 134);
            btnNewEmp.Name = "btnNewEmp";
            btnNewEmp.Size = new Size(75, 23);
            btnNewEmp.TabIndex = 1;
            btnNewEmp.Text = "Add";
            btnNewEmp.UseVisualStyleBackColor = true;
            btnNewEmp.Click += btnNewEmp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 476);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Project1 Property Management";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvAssignments).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnNewEmp;
        private Label lbfirstname;
        private Label lblastname;
        private TextBox tbfirstname;
        private TextBox tblastname;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dvEmployees;
        private DataGridView dvAssignments;
        private TextBox tbProblemDescription;
        private TextBox tbPhone;
        private TextBox tbAddress;
        private TextBox tbOwnerLastName;
        private TextBox tbOwnerFirstName;
        private Label lbCompleted;
        private Label lbProblemDescription;
        private Label lbPhone;
        private Label lbAddress;
        private Label lbOwnerLastName;
        private Label lbOwnerFirstName;
        private Label lbDateAssigned;
        private Button btDelete;
        private Button btEdit;
        private Button btAdd;
        private DateTimePicker dtpDateAssigned;
        private CheckBox cbCompleted;
        private CheckBox cbincomplete;
        private Label lbSearchEmployeeID;
        private Label lbSeachFirstName;
        private Label lbSearchLastName;
        private TextBox tbSearchLastName;
        private TextBox tbSearchFirstName;
        private Button btSearch;
        private Button btClear;
        private Button btnClearEmployees;
        private Button btnClearAssignments;
        private Label label1;
        private ComboBox cbAssignedEmployee;
    }
}
