using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B321_Project
{
    internal class clsDBUtil
    {
        
        public static string getConnectionString()
        {
            // Define the connection string to connect to the database
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "uscb-garcia-arias.database.windows.net"; // Update with your server name  
            builder.InitialCatalog = "b320"; // Update with your database name
            builder.UserID = "B321_sp25_Team05"; // Update with your username
            builder.Password = "P4ssword!"; // Update with your password
            builder.Encrypt = false;

            return builder.ConnectionString.ToString();
        }
        #region Private Helper Methods: Data-to-C# Conversion
        public static string convertFromDBType_DateTimeToString(object obj)
        {
            if ((obj == null) || DBNull.Value.Equals(obj))
            {
                return string.Empty;
            }
            else
            {
                DateTime temp = (DateTime)obj;
                return temp.ToString();
            }
        }

        public static Double convertFromDBType_FloatToDouble(object obj, Double defaultValue)
        {
            if ((obj == null) || DBNull.Value.Equals(obj))
            {
                return defaultValue;
            }
            else
            {
                Double temp = Convert.ToDouble(obj);
                return temp;
            }
        }

        public static int convertFromDBType_IntToInt(object obj, int defaultValue)
        {
            if ((obj == null) || DBNull.Value.Equals(obj))
            {
                return defaultValue;
            }
            else
            {
                int temp = (int)obj;
                return temp;
            }
        }

        public static string convertFromDBType_VarcharToString(object obj)
        {
            if ((obj == null) || DBNull.Value.Equals(obj))
            {
                return string.Empty;
            }
            else
            {
                return (string)obj; // Ensure this is returning the correct value
            }
        }

        private string convertToDBType_BoolToBool(bool boolValue)
        {
            return boolValue.ToString();
        }

        private string convertToDBType_StringToVarchar(string stringValue)
        {
            return "'" + stringValue.Replace("'", "''") + "'";
        }

        private string convertToDBType_StringToDate(string stringValue)
        {
            if (stringValue == "")
            {
                return "NULL";
            }
            else
            {
                return "'" + stringValue.Replace("'", "''") + "'";
            }
        }


        #endregion
    }
}
