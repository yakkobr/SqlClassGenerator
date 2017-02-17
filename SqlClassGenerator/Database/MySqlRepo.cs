using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SqlClassGenerator.DataObjects;

namespace SqlClassGenerator.Database
{
    public class MySqlRepo : ISqlRepo
    {
        /// <summary>
        /// Contains the my sql database manager
        /// </summary>
        private DbManagerMySql _dbManager;

        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        /// <param name="server">The server</param>
        /// <param name="user">The user</param>
        /// <param name="password">The password</param>
        public MySqlRepo(string server, SecureString user, SecureString password)
        {
            _dbManager = new DbManagerMySql(server, user, password);
        }

        /// <summary>
        /// Sets the database
        /// </summary>
        /// <param name="database">The name of the database</param>
        public void SetDatabase(string database)
        {
            _dbManager.SetDatabase(database);
        }
        /// <summary>
        /// Gets the available databases
        /// </summary>
        /// <returns>List of databases</returns>
        public List<string> GetDatabases()
        {
            return _dbManager.Connection.Query<string>("SHOW DATABASES").ToList();
        }
        /// <summary>
        /// Gets the available 
        /// </summary>
        /// <returns></returns>
        public List<string> GetTables()
        {
            return _dbManager.Connection.Query<string>("SHOW TABLES").ToList();
        }
        /// <summary>
        /// Gets the information for a given table
        /// </summary>
        /// <param name="tableName">The name of the table</param>
        /// <returns>List of the table columns</returns>
        public List<ColumnModel> GetTableInformation(string tableName)
        {
            var columns = _dbManager.Connection.Query<ColumnModel>($"SHOW COLUMNS FROM {tableName}").ToList();

            foreach (var column in columns)
            {
                if (column.Type.Contains("("))
                    column.Type = column.Type.Substring(0, column.Type.IndexOf("("));
            }

            return columns;
        }
    }
}
