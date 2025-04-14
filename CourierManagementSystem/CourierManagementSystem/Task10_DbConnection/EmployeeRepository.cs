using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CourierManagementSystem.Task5_OOP; // This namespace contains the Employee class
using CourierManagementSystem.Task10_DbConnection; // Add this namespace for ConnectionUtil

namespace CourierManagementSystem.Task10_DbConnection
{
    // EmployeeRepository class handles database operations related to Employee entities
    public class EmployeeRepository
    {
        private SqlConnection connection; // Stores the connection to the database

        // Constructor initializes the connection using the ConnectionUtil class
        public EmployeeRepository()
        {
            // Use ConnectionUtil to get the connection instance
            connection = ConnectionUtil.GetConnection();
        }

        // Adds a new employee to the database
        public void AddEmployee(Employee emp)
        {
            // Define the SQL query to insert a new employee into the Employees table
            using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Employees 
                                                    (EmployeeName, Email, ContactNumber, Role, Salary)
                                                    VALUES (@EmployeeName, @Email, @ContactNumber, @Role, @Salary)", connection))
            {
                // Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@ContactNumber", emp.ContactNumber);
                cmd.Parameters.AddWithValue("@Role", emp.Role);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);

                // Open the connection, execute the query, and close the connection
                connection.Open();
                cmd.ExecuteNonQuery(); // Executes the insert query to add the employee
                connection.Close(); // Close the connection after execution
            }
        }

        // Retrieves all employee records from the database
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>(); // List to hold the retrieved employees

            // Define the SQL query to select all employee records from the Employees table
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", connection))
            {
                connection.Open(); // Open the connection to the database
                SqlDataReader reader = cmd.ExecuteReader(); // Execute the query and get a data reader

                // Loop through all records in the data reader
                while (reader.Read())
                {
                    // Create a new Employee object for each record in the database
                    Employee emp = new Employee
                    {
                        EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                        EmployeeName = reader["EmployeeName"].ToString(),
                        Email = reader["Email"].ToString(),
                        ContactNumber = reader["ContactNumber"].ToString(),
                        Role = reader["Role"].ToString(),
                        Salary = Convert.ToDouble(reader["Salary"])
                    };

                    // Add the newly created employee to the list
                    employees.Add(emp);
                }

                connection.Close(); // Close the connection after reading all data
            }

            // Return the list of all employees
            return employees;
        }
    }
}
