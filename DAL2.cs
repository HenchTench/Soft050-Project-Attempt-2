using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Data.SqlClient;
using System.Data;

namespace Soft050_Project_Attempt_2
{
    public class DAL2
    {
        public static string GetFilePath(string strFileName)
        {
            string strDirectoryLocation;
            string strFilePath;

            strDirectoryLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            strFilePath = Path.Combine(strDirectoryLocation, strFileName);

            return strFilePath;
        }

        public static void LocalServerVerification() //This subroutine is functioning correctly for now.
        {
            string strFilePath = GetFilePath("GoHomeData.sqlite");
            if (!File.Exists(strFilePath))
            {
                try
                {
                    SQLiteConnection.CreateFile(strFilePath);
                    using (var SQLconnection = new SQLiteConnection($"Data Source={strFilePath};Version=3;"))
                    {
                        SQLconnection.Open();
                        string strSQLQuery = "CREATE TABLE PropertyTable (PropertyID INTEGER PRIMARY KEY AUTOINCREMENT, PropertyName TEXT NOT NULL, CurrentValuation REAL NOT NULL, CurrentRentPerMonth REAL NOT NULL);";
                        SQLiteCommand command = new SQLiteCommand(strSQLQuery, SQLconnection);
                        command.ExecuteNonQuery();
                        Logging.DebugLog("Tables created");
                    }
                }
                catch (Exception VerifyException)
                {//Fix This to have proper text later.
                    MessageBox.Show("An error has occured of the following case: " + VerifyException, "An Error Has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logging.DebugLog("Following error occurred: " + VerifyException);
                }
                try
                {
                    using (var SQLconnection = new SQLiteConnection($"Data Source={strFilePath};Version=3;"))
                    {
                        SQLconnection.Open();
                        string strSQLQuery = "SELECT name FROM sqlite_master WHERE type='table' AND name='PropertyTable';";
                        SQLiteCommand command = new SQLiteCommand(strSQLQuery, SQLconnection);
                        var strQueryReturn = command.ExecuteScalar();
                        Logging.DebugLog("PropertyTable existence confirmed");
                    }
                }
                catch (Exception VerifyException)
                {
                    MessageBox.Show("An error has occurred verifying the existence of the table of the following case: " + VerifyException, "An Error Has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logging.DebugLog("Following error occurred: " + VerifyException);
                }

            }
            else
            {
                Logging.DebugLog("Datebase already existed");
            }
        }

        public static void CreateDataProperty()//Insert parameters here later.
        {
            string strFilePath = GetFilePath("GoHomeData.sqlite");
            try
            {
                using (var SQLConnection = new SQLiteConnection($"Data Source={strFilePath};Version=3;"))
                {
                    string strSQLQuery;
                    SQLConnection.Open();
                    strSQLQuery = "INSERT INTO PropertyTable (PropertyName, CurrentValuation, CurrentRentPerMonth) VALUES('Oakwood Apartments', 1200000.00, 1500.00),('Maple Townhouses', 950000.00, 1200.00),('Elm Condo', 780000.00, 1000.00),('Pine Villa', 2150000.00, 3000.00);";
                    SQLiteCommand command = new SQLiteCommand(strSQLQuery, SQLConnection);
                    command.ExecuteNonQuery();
                    Logging.DebugLog("CreateDataProperty ran");
                }
            }
            catch (Exception VerifyException)
            {
                MessageBox.Show("An error has occured of the following case: " + VerifyException, "An Error Has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logging.DebugLog("Following error occurred: " + VerifyException);
            }
        }
        public static DataTable ReadDataProperty()
        {
            string strFilePath = GetFilePath("GoHomeData.sqlite");
            try
            {
                using (var SQLConnection = new SQLiteConnection($"Data Source={strFilePath};Version=3;"))
                {
                    string strSQLQuery;
                    SQLConnection.Open();
                    strSQLQuery = "SELECT * FROM PropertyTable";
                    SQLiteDataAdapter adpAdapter = new SQLiteDataAdapter(strSQLQuery, SQLConnection);
                    DataTable tabDataTable = new DataTable();
                    adpAdapter.Fill(tabDataTable);
                    Logging.DebugLog("ReadDataProperty ran");
                    return tabDataTable;
                }
            }
            catch (Exception VerifyException)
            {
                MessageBox.Show("An error has occured of the following case: " + VerifyException, "An Error Has Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logging.DebugLog("Following error occurred: " + VerifyException);
                return new DataTable();
            }
        }
    }
}




