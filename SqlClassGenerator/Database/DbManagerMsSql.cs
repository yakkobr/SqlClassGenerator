using System;
using System.Data;
using System.Data.SqlClient;
using System.Security;
using SqlClassGenerator.Global;

namespace SqlClassGenerator.Database
{
    public class DbManagerMsSql
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
        /// true if the user wants to use the windows authentication, otherwise false
        /// </summary>
        private readonly bool _windowsAuthentication;
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

        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        /// <param name="server">The server</param>
        /// <param name="user">The user</param>
        /// <param name="password">The password</param>
        /// <param name="windowsAuthentication">true if the user wants to use the windows authentication, otherwise false</param>
        public DbManagerMsSql(string server, SecureString user, SecureString password, bool windowsAuthentication)
        {
            _server = server;
            _user = user;
            _password = password;
            _windowsAuthentication = windowsAuthentication;
        }

        /// <summary>
        /// Creates a new connection
        /// </summary>
        private void CreateConnection()
        {
            if (_windowsAuthentication)
            {
                _connection = new SqlConnection(new SqlConnectionStringBuilder
                {
                    DataSource = _server,
                    IntegratedSecurity = true
                }.ConnectionString);
            }
            else
            {
                _connection = new SqlConnection(new SqlConnectionStringBuilder
                {
                    DataSource = _server,
                    UserID = _user.ToUnsecureString(),
                    Password = _password.ToUnsecureString()
                }.ConnectionString);
            }
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
