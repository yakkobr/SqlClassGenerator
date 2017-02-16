using System.Data;
using System.Data.SqlClient;
using System.Security;

namespace SqlClassGenerator.Database
{
    public class DbManagerMsSql
    {
        /// <summary>
        /// Contains the server
        /// </summary>
        private string _server;
        /// <summary>
        /// Contains the name of the database
        /// </summary>
        private string _database;
        /// <summary>
        /// Contains the user
        /// </summary>
        private SecureString _user;
        /// <summary>
        /// Contains the password
        /// </summary>
        private SecureString _password;
        /// <summary>
        /// Contains the connection
        /// </summary>
        private SqlConnection _connection;
        /// <summary>
        /// Gets the sql connection
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                if (_connection == null || _connection.State == ConnectionState.Broken ||
                    _connection.State == ConnectionState.Closed)
                    CreateConnection();

                return _connection;
            }
        }

        private void CreateConnection()
        {
            
        }
    }
}
