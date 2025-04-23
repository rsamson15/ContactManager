using MySql.Data.MySqlClient;  
using System.Data;             
using System.Windows.Forms;
namespace Project1_CRUD_     
{
    public partial class Form1 : Form
    {
        // These variables store selected Employee and Assignment IDs for tracking during updates or deletions.
        private int selectedEmployeeID = -1;
        private int selectedAssignmentID = -1;

        public Form1()
        {
            InitializeComponent();
        }

        // This function runs when the form opens and loads data from the MySQL database.
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAssignments();
            LoadEmployees();
            LoadAssignedEmployeeComboBox();
        }

        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbfirstname.Text) || string.IsNullOrEmpty(tblastname.Text))  // Checks if fields are empty before adding an employee.
            {
                MessageBox.Show("All fields are required");
            }
            else
            {


                string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;";


                using (MySqlConnection connection = new MySqlConnection(connectionString))  // Creates a database connection (MySqlConnection).
                {
                    // Executes an SQL INSERT statement to add the employee
                    string insertQuery = "Insert into Employees (EmployeeFirstName, EmployeeLastName) values (@FirstName, @LastName)";  
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@FirstName", tbfirstname.Text);
                        cmd.Parameters.AddWithValue("@LastName", tblastname.Text);


                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Employee Added");
                            LoadEmployees();  // Reload the employee data and refresh the DataGridView.
                            LoadAssignedEmployeeComboBox();   //Refreshes the employee list after adding.
                            button1_Click(null, null);  // Clears input fields.
                        }
                        Console.WriteLine(rowsAffected);

                    }

                }
            }


        }

        private void LoadEmployees()
        {
            string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;";


            using (MySqlConnection connection = new MySqlConnection(connectionString))   // Creates a database connection (MySqlConnection).
            {
                try
                {
                    string query = "SELECT * FROM employees";

                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection)) // Fetches all employees from the employees table.
                    {
                        DataTable dt = new DataTable(); 
                        adapter.Fill(dt); // // Fills the DataGridView (dvEmployees) with employee records.
                        dvEmployees.DataSource = dt;  // Datagridview for Employees
                    }
                    dvEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;  // Adjusts row heights to fit content.
                }
                catch (Exception ex) //Handles errors if something goes wrong.
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void LoadAssignments()
        {
            string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;";


            using (MySqlConnection connection = new MySqlConnection(connectionString)) // Creates a database connection (MySqlConnection).
            {
                try
                {
                    string query = ""; 
                    if (cbincomplete.Checked) // Checks if a checkbox (cbincomplete) is checked.
                    {
                        // Retrieves all assignment records to include employee data. Orders results by DateAssigned
                        query = "SELECT AssignmentID, DateAssigned, OwnerFirstName, OwnerLastName, Address, Phone, ProblemDescription, Completed, a.EmployeeID, EmployeeFirstname, EmployeeLastName FROM assignments a LEFT JOIN Employees e ON e.EmployeeID = a.EmployeeID WHERE Completed = false ORDER BY DateAssigned;";
                    }
                    else
                    {
                        query = "SELECT AssignmentID, DateAssigned, OwnerFirstName, OwnerLastName, Address, Phone, ProblemDescription, Completed, a.EmployeeID, EmployeeFirstname, EmployeeLastName FROM assignments a LEFT JOIN Employees e ON e.EmployeeID = a.EmployeeID ORDER BY DateAssigned;";
                    }
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable(); // Creates an empty DataTable (dt).
                        adapter.Fill(dt);    // Fills dt with the result of the SQL query.
                        dvAssignments.DataSource = dt; // Datagridview for asignments
                    }
                    dvAssignments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;  // Adjusts row heights to fit content.
                }
                catch (Exception ex) // Catches any exceptions that occur.
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbfirstname.Text) || string.IsNullOrEmpty(tblastname.Text))  // Checks if either the tbfirstname or tblastname textboxes are empty or null.
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                if (selectedEmployeeID == -1)    // If the fields are not empty, the code checks if an employee has been selected and the selectedEmployeeID should not be -1. A value of -1 indicates no employee has been selected.
                {
                    MessageBox.Show("Please select a record to update.");
                    return;
                }
                string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;"; 
                using (MySqlConnection connection = new MySqlConnection(connectionString)) // Creates a database connection (MySqlConnection).
                {
                    connection.Open();
                    string query = "UPDATE Employees SET EmployeeFirstName = @firstName, EmployeeLastName = @lastName WHERE EmployeeID = @id";  //Query is defined to update an employee’s first and last names in the Employees table. 

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Parameters are added to the command:
                        cmd.Parameters.AddWithValue("@id", selectedEmployeeID);   // Use stored EmployeeID
                        cmd.Parameters.AddWithValue("@firstName", tbfirstname.Text); 
                        cmd.Parameters.AddWithValue("@lastName", tblastname.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Record updated successfully!");
                LoadEmployees();  // Reload the employee data and refresh the DataGridView.
                LoadAssignedEmployeeComboBox(); // reload a combo box that lists employees.
                button1_Click(null, null); // Clear the infut fields.
            }
        }

        private void dvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dvEmployees.Rows[e.RowIndex].IsNewRow)  // Ensure a valid row is clicked
            {
                DataGridViewRow row = dvEmployees.Rows[e.RowIndex];

                selectedEmployeeID = Convert.ToInt32(row.Cells["EmployeeID"].Value); //Store EmployeeID
                tbfirstname.Text = row.Cells["EmployeeFirstName"].Value.ToString();
                tblastname.Text = row.Cells["EmployeeLastName"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == -1) // Ensure Employee is selected
            {
                MessageBox.Show("Please select a record to delte.");
                return;
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Employees WHERE EmployeeID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedEmployeeID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record Deleted successfully!");
                    LoadEmployees();  // Refresh DataGridView
                    LoadAssignedEmployeeComboBox();
                    button1_Click(null, null);
                }
            }
        }

        private void btAddAssignment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOwnerFirstName.Text) || string.IsNullOrEmpty(tbOwnerLastName.Text)
                || string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbProblemDescription.Text)
                || cbAssignedEmployee.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;";


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    string insertQuery = "Insert into Assignments (DateAssigned, OwnerFirstName, OwnerLastName, Address, Phone, ProblemDescription, Completed, EmployeeID) " +
                        "values (@DateAssigned, @OwnerFirstName, @OwnerLastName, @Address, @Phone, @ProblemDescription, @Completed, @EmployeeID)";
                    connection.Open();
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {

                            cmd.Parameters.AddWithValue("@DateAssigned", dtpDateAssigned.Value);
                            cmd.Parameters.AddWithValue("@OwnerFirstName", tbOwnerFirstName.Text);
                            cmd.Parameters.AddWithValue("@OwnerLastName", tbOwnerLastName.Text);
                            cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                            cmd.Parameters.AddWithValue("@Phone", tbPhone.Text);
                            cmd.Parameters.AddWithValue("@ProblemDescription", tbProblemDescription.Text);
                            cmd.Parameters.AddWithValue("@Completed", cbCompleted.Checked);
                            cmd.Parameters.AddWithValue("@EmployeeID", cbAssignedEmployee.SelectedValue);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 1)
                            {
                                MessageBox.Show("Assignment Added");
                                LoadAssignments();
                                btnClearAssignments_Click(null, null);
                            }
                            Console.WriteLine(rowsAffected);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }


            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbOwnerFirstName.Text) || string.IsNullOrEmpty(tbOwnerLastName.Text)
                || string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbProblemDescription.Text)
                || cbAssignedEmployee.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {

                if (selectedAssignmentID == -1)
                {
                    MessageBox.Show("Please select a record to update.");
                    return;
                }
                string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Assignments SET DateAssigned = @dateAssigned, OwnerFirstName = @ownerfirstName, OwnerLastName = @ownerlastName, Phone = @phone, ProblemDescription = @problemDescription, Completed = @completed, EmployeeID = @EmployeeID WHERE AssignmentID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@dateAssigned", dtpDateAssigned.Value);
                        cmd.Parameters.AddWithValue("@ownerfirstName", tbOwnerFirstName.Text);
                        cmd.Parameters.AddWithValue("@ownerlastName", tbOwnerLastName.Text);
                        cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                        cmd.Parameters.AddWithValue("@problemDescription", tbProblemDescription.Text);
                        cmd.Parameters.AddWithValue("@completed", cbCompleted.Checked);
                        cmd.Parameters.AddWithValue("@EmployeeID", cbAssignedEmployee.SelectedValue);
                        cmd.Parameters.AddWithValue("@id", selectedAssignmentID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Record updated successfully!");
                LoadAssignments();  // Refresh DataGridView
                btnClearAssignments_Click(null, null);
            }
        }

        private void dvAssignments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dvAssignments.Rows[e.RowIndex].IsNewRow)  // Ensure a valid row is clicked
            {
                DataGridViewRow row = dvAssignments.Rows[e.RowIndex];

                selectedAssignmentID = Convert.ToInt32(row.Cells["AssignmentID"].Value); //Store EmployeeID
                dtpDateAssigned.Text = row.Cells["DateAssigned"].Value.ToString();
                tbOwnerFirstName.Text = row.Cells["OwnerFirstName"].Value.ToString();
                tbOwnerLastName.Text = row.Cells["OwnerLastName"].Value.ToString();
                tbAddress.Text = row.Cells["Address"].Value.ToString();
                tbPhone.Text = row.Cells["Phone"].Value.ToString();
                tbProblemDescription.Text = row.Cells["ProblemDescription"].Value.ToString();
                cbCompleted.Text = row.Cells["Completed"].Value.ToString();
                cbAssignedEmployee.SelectedValue = row.Cells["EmployeeID"].Value;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (selectedAssignmentID == -1)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Assignments WHERE AssignmentID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedAssignmentID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record Deleted successfully!");
                    LoadAssignments();  // Refresh DataGridView
                    btnClearAssignments_Click(null, null);
                }
            }
        }

        private void cbincomplete_CheckedChanged(object sender, EventArgs e)
        {
            LoadAssignments();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM employees WHERE 1=1";

                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(tbSearchFirstName.Text))
                        {
                            query += " AND LOWER(EmployeeFirstName) LIKE LOWER(@firstName)";
                            cmd.Parameters.AddWithValue("@firstName", tbSearchFirstName.Text.ToLower() + "%");
                        }

                        if (!string.IsNullOrWhiteSpace(tbSearchLastName.Text))
                        {
                            query += " AND LOWER(EmployeeLastName) LIKE LOWER(@lastName)";
                            cmd.Parameters.AddWithValue("@lastName", tbSearchLastName.Text.ToLower() + "%");
                        }

                        cmd.CommandText = query;
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dvEmployees.DataSource = dt; // Datagridview for employees
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbSearchFirstName.Clear();
            tbSearchLastName.Clear();
            LoadEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This button Clear the Employee
            selectedEmployeeID = -1;

            tbfirstname.Clear();
            tblastname.Clear();

        }

        private void btnClearAssignments_Click(object sender, EventArgs e)
        {

            selectedAssignmentID = -1;

            dtpDateAssigned.Value = DateTime.Now;
            tbOwnerFirstName.Clear();
            tbOwnerLastName.Clear();
            tbAddress.Clear();
            tbPhone.Clear();
            tbProblemDescription.Clear();
            cbCompleted.Checked = false;
            cbAssignedEmployee.SelectedValue = 0;

        }

        private void LoadAssignedEmployeeComboBox()
        {
            string connectionString = "Server=localhost;Database=Project1;Uid=root;Pwd=samson;";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT EmployeeID, CONCAT(EmployeeFirstname, ' ', EmployeeLastName) AS FullName FROM employees";

                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        DataRow row = dt.NewRow();
                        row[0] = 0;
                        row[1] = "Please select";
                        dt.Rows.InsertAt(row, 0);

                        cbAssignedEmployee.DataSource = dt;
                        cbAssignedEmployee.DisplayMember = "FullName";
                        cbAssignedEmployee.ValueMember = "EmployeeID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}



