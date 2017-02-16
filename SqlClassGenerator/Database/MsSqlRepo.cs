using System.Collections.Generic;
using System.Linq;
using System.Security;
using Dapper;
using SqlClassGenerator.DataObjects;

namespace SqlClassGenerator.Database
{
    public class MsSqlRepo : ISqlRepo
    {
        /// <summary>
        /// Contains the database manager
        /// </summary>
        private readonly DbManagerMsSql _dbManager;
        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        /// <param name="server">The server</param>
        /// <param name="user">The user</param>
        /// <param name="password">The password</param>
        /// <param name="windowsAuthentication">true if the user wants to use the windows authentication, otherwise false</param>
        public MsSqlRepo(string server, SecureString user, SecureString password, bool windowsAuthentication)
        {
            _dbManager = new DbManagerMsSql(server, user, password, windowsAuthentication);
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
            return _dbManager.Connection.Query<string>("SELECT name FROM master.dbo.sysdatabases").ToList();
        }
        /// <summary>
        /// Gets the available tables
        /// </summary>
        /// <returns>List of tables</returns>
        public List<string> GetTables()
        {
            return _dbManager.Connection.Query<string>("SELECT name FROM sys.tables").ToList();
        }
        /// <summary>
        /// Gets the information for a given table
        /// </summary>
        /// <param name="tableName">The name of the table</param>
        /// <returns>List of the table columns</returns>
        public List<TableModel> GetTableInformation(string tableName)
        {
            return
                _dbManager.Connection.Query<TableModel>(
                    "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName", new {tableName}).ToList();
        }
    }
}
