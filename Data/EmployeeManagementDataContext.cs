using System;
using System.Configuration;

namespace EmployeeManagementSystem.Data
{
    public partial class EmployeeManagementDataContext
    {
        /// <summary>
        /// Initializes a new instance of EmployeeManagementDataContext using the connection string
        /// from App.config ("EmployeeDb" or Properties.Settings).
        /// </summary>
        public EmployeeManagementDataContext() :
            base(GetConnectionString(), mappingSource)
        {
            OnCreated();
        }

        /// <summary>
        /// Retrieves the active connection string from configuration.
        /// </summary>
        public static string GetConnectionString()
        {
            try
            {
                if (ConfigurationManager.ConnectionStrings["EmployeeDb"] != null &&
                    !string.IsNullOrWhiteSpace(ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString))
                {
                    return ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString;
                }

                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.EmployeeManagementDBConnectionString))
                {
                    return Properties.Settings.Default.EmployeeManagementDBConnectionString;
                }
            }
            catch
            {
                // Fallback to default local express connection string
            }

            return @"Data Source=.\SQLEXPRESS;Initial Catalog=EmployeeManagementDB;Integrated Security=True;TrustServerCertificate=True";
        }
    }
}
