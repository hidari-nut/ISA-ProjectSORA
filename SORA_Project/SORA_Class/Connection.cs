using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SORA_Class
{
    internal class Connection
    {
        private MySqlConnection dbConnection;

        public MySqlConnection DbConnection { get => dbConnection; private set => dbConnection = value; }

        public Connection()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = config.SectionGroups["userSettings"];
            var settingSection = userSettings.Sections["Program_UAS.Database"] as ClientSettingsSection;

            string dbServer = settingSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string dbName = settingSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string dbUsername = settingSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string dbPassword = settingSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string connectionString = "Server=" + dbServer + "; Database=" + dbName + "; Uid=" + dbUsername + "; Pwd=" + dbPassword;

            DbConnection = new MySqlConnection();
            DbConnection.ConnectionString = connectionString;
            Connect();
        }

        public Connection(string pServer, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "Server=" + pServer + "; Database=" + pDatabase + "; Uid=" + pUsername + "; Pwd=" + pPassword;
            DbConnection = new MySqlConnection();
            DbConnection.ConnectionString = strCon;
            Connect();
        }

        /// <summary>
        /// Connects the program to the designated database
        /// </summary>
        public void Connect()
        {
            if (DbConnection.State == System.Data.ConnectionState.Open)
            {
                DbConnection.Close();
            }
            DbConnection.Open();
        }

        /// <summary>
        /// Runs a select query in the database to select data based on select command input
        /// </summary>
        /// <param name="sqlString">Select command to be run</param>
        /// <returns>A MySqlDataReader which can then be used to return the data selected</returns>
        public static MySqlDataReader RunQueryCommand(string sqlString)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand(sqlString, connection.DbConnection);
            MySqlDataReader hasil = command.ExecuteReader();

            return hasil;
        }

        /// <summary>
        /// Runs a select query in the database to select data based on select command input
        /// </summary>
        /// <param name="sqlString">Select command to be run</param>
        /// <param name="connection">Connection to the database server</param>
        /// <returns>A MySqlDataReader which can then be used to return the data selected</returns>
        public static MySqlDataReader RunQueryCommand(string sqlString, Connection connection)
        {
            MySqlCommand command = new MySqlCommand(sqlString, connection.DbConnection);
            MySqlDataReader hasil = command.ExecuteReader();

            return hasil;
        }

        /// <summary>
        /// Runs a DML command in the database
        /// </summary>
        /// <param name="sqlString">DML command to be run</param>
        /// <returns>Returns the number of affected rows</returns>
        public static int RunDMLCommand(string sqlString)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand(sqlString, connection.DbConnection);
            int hasil = command.ExecuteNonQuery();
            return hasil;
        }

        /// <summary>
        /// Runs a DML command in the database
        /// </summary>
        /// <param name="sqlString">DML command to be run</param>
        /// <param name="connection">Connection to the database server</param>
        /// <returns>Returns the number of affected rows</returns>
        public static int RunDMLCommand(string sqlString, Connection connection)
        {
            MySqlCommand command = new MySqlCommand(sqlString, connection.DbConnection);
            int hasil = command.ExecuteNonQuery();
            return hasil;
        }
    }
}
