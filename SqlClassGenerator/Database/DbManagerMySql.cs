using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SqlClassGenerator.Global;

namespace SqlClassGenerator.Database
{
    public class DbManagerMySql
    {
        /// <summary>
        /// Contains the server
        /// </summary>
        private readonly string _server;
        /// <summary>
        /// Contains the name of the database
        /// </summary>
        private string _database;
        /// <summary>
        /// Contains the user
        /// </summary>
        private readonly SecureString _user;
        /// <summary>
        /// Contains the password
        /// </summary>
        private readonly SecureString _password;
        /// <summary>
        /// Contains the connection
        /// </summary>
        private MySqlConnection _connection;

        /// <summary>
        /// Gets the sql connection
        /// </summary>
        public MySqlConnection Connection
        {
            get
            {
                if (_connection == null || _connection.State == ConnectionState.Broken ||
                    _connection.State == ConnectionState.Closed)
                    CreateConnection();

                return _connection;
            }
        }

        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        /// <param name="server">The server</param>
        /// <param name="user">The user</param>
        /// <param name="password">The password</param>
        public DbManagerMySql(string server, SecureString user, SecureString password)
        {
            _server = server;
            _user = user;
            _password = password;
        }

        /// <summary>
        /// Creates a new connection
        /// </summary>
        private void CreateConnection()
        {

            _connection = new MySqlConnection(new MySqlConnectionStringBuilder
            {
                Server = _server,
                UserID = _user.ToUnsecureString(),
                Password = _password.ToUnsecureString()
            }.ConnectionString);
            // Open the connection
            _connection?.Open();
        }
        /// <summary>
        /// Sets the database
        /// </summary>
        /// <param name="database">The name of the database</param>
        public void SetDatabase(string database)
        {
            if (string.IsNullOrEmpty(database))
                throw new ArgumentNullException(nameof(database));

            _database = database;
            _connection.ChangeDatabase(database);
        }
    }
}
