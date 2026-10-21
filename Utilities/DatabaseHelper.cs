using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Utilities
{
    /// <summary>
    /// Utility methods for database diagnostics, error parsing, and test connections.
    /// </summary>
    public static class DatabaseHelper
    {
        /// <summary>
        /// Tests the database connection and returns connection status details.
        /// </summary>
        public static bool TestConnection(out string message)
        {
            try
            {
                using (var db = new EmployeeManagementDataContext())
                {
                    if (db.DatabaseExists())
                    {
                        message = "Connected to EmployeeManagementDB successfully.";
                        return true;
                    }
                    else
                    {
                        message = "EmployeeManagementDB database was not found on the SQL server instance.";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Database connection error: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Translates SQL Server exceptions into clear, actionable, friendly messages for the user.
        /// </summary>
        public static string GetFriendlyErrorMessage(Exception ex)
        {
            if (ex == null) return "An unknown error occurred.";

            Exception current = ex;
            while (current != null)
            {
                if (current is SqlException sqlEx)
                {
                    switch (sqlEx.Number)
                    {
                        case 2627: // Unique constraint violation
                        case 2601: // Unique index violation
                            if (sqlEx.Message.Contains("UQ_Employees_Email"))
                            {
                                return "An employee with this Email address already exists. Please use a unique email address.";
                            }
                            if (sqlEx.Message.Contains("UQ_Departments_Code"))
                            {
                                return "A department with this code already exists.";
                            }
                            if (sqlEx.Message.Contains("UQ_Departments_Name"))
                            {
                                return "A department with this name already exists.";
                            }
                            return "A record with identical unique details already exists in the system.";

                        case 547: // Check constraint or Foreign Key violation
                            if (sqlEx.Message.Contains("CK_Employees_Dates"))
                            {
                                return "Constraint check failed: Hire date must be on or after the employee's birth date.";
                            }
                            if (sqlEx.Message.Contains("CK_Employees_Salary"))
                            {
                                return "Constraint check failed: Salary must be greater than or equal to zero.";
                            }
                            if (sqlEx.Message.Contains("CK_Employees_Sex"))
                            {
                                return "Constraint check failed: Please select a valid sex ('Female', 'Male', or 'Prefer not to say').";
                            }
                            if (sqlEx.Message.Contains("CK_Employees_Status"))
                            {
                                return "Constraint check failed: Invalid employment status.";
                            }
                            if (sqlEx.Message.Contains("CK_History_Dates"))
                            {
                                return "Constraint check failed: End date cannot precede the start date.";
                            }
                            if (sqlEx.Message.Contains("FK_History_Employee"))
                            {
                                return "Foreign key constraint: The referenced employee does not exist.";
                            }
                            if (sqlEx.Message.Contains("FK_Employees_Departments"))
                            {
                                return "Foreign key constraint: The selected department is invalid or was removed.";
                            }
                            return "The database rejected this operation due to a data constraint or relationship conflict.";

                        case 4060:
                            return "Cannot open database 'EmployeeManagementDB'. Please verify that the database exists and you have permissions.";

                        case 18456:
                            return "SQL Server login failed. Please verify credentials or Windows authentication.";

                        case 2:
                        case 53:
                            return "A network-related or instance-specific error occurred while establishing a connection to SQL Server. Ensure SQL Server (SQLEXPRESS) service is running.";
                    }
                }
                current = current.InnerException;
            }

            return ex.Message;
        }

        /// <summary>
        /// Displays a user-friendly error dialog for database or application exceptions.
        /// </summary>
        public static void ShowErrorDialog(Exception ex, string caption = "Database Operation Error")
        {
            string friendlyMsg = GetFriendlyErrorMessage(ex);
            MessageBox.Show(friendlyMsg, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
