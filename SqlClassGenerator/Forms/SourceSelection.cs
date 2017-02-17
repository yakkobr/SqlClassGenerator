using System;
using System.Linq;
using System.Security;
using System.Windows.Forms;
using SqlClassGenerator.Database;
using SqlClassGenerator.DataObjects;
using SqlClassGenerator.Global;

namespace SqlClassGenerator.Forms
{
    public partial class SourceSelection : Form
    {
        /// <summary>
        /// Contains the mysql db manager
        /// </summary>
        private MySqlRepo _mySqlManager;
        /// <summary>
        /// Contains the mssql db manager
        /// </summary>
        private MsSqlRepo _msSqlManager;
        /// <summary>
        /// Gets the my sql connection
        /// </summary>
        public MySqlRepo MySqlConnection => _mySqlManager;
        /// <summary>
        /// Gets the mssql connection
        /// </summary>
        public MsSqlRepo MsSqlConnection => _msSqlManager;

        /// <summary>
        /// Gets the selected provider
        /// </summary>
        public CustomEnums.Provider Provider { get; private set; }
        /// <summary>
        /// Gets the server name
        /// </summary>
        public string Server { get; private set; }
        /// <summary>
        /// Gets the user
        /// </summary>
        public SecureString User { get; private set; }
        /// <summary>
        /// Gets the password
        /// </summary>
        public SecureString Password { get; private set; }
        /// <summary>
        /// Gets the windows authentication value
        /// </summary>
        public bool WindowsAuthentication { get; private set; }
        /// <summary>
        /// Gets the database
        /// </summary>
        public string Database { get; private set; }



        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        public SourceSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inits the form
        /// </summary>
        private void InitForm()
        {
            comboProvider.Items.Clear();
            foreach (CustomEnums.Provider value in Enum.GetValues(typeof(CustomEnums.Provider)))
            {
                if (value != CustomEnums.Provider.None)
                    comboProvider.Items.Add(new ComboBoxItem(Enum.GetName(typeof(CustomEnums.Provider), value), value));
            }
        }
        /// <summary>
        /// Creates a connection to the server
        /// </summary>
        private void ConnectToServer()
        {
            if (string.IsNullOrEmpty(txtServer.Text))
            {
                return;
            }

            if (!checkWindowsAuthentication.Checked)
            {
                if (string.IsNullOrEmpty(txtUser.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    return;
                }
            }

            Server = txtServer.Text;

            if (Provider == CustomEnums.Provider.MsSql)
            {
                if (checkWindowsAuthentication.Checked)
                {
                    _msSqlManager = new MsSqlRepo(txtServer.Text, null, null, checkWindowsAuthentication.Checked);

                    Server = txtServer.Text;
                    WindowsAuthentication = checkWindowsAuthentication.Checked;
                }
                else
                {
                    _msSqlManager = new MsSqlRepo(txtServer.Text, txtUser.Text.ToSecureString(),
                        txtPassword.Text.ToSecureString(), checkWindowsAuthentication.Checked);
                    User = txtUser.Text.ToSecureString();
                    Password = txtPassword.Text.ToSecureString();
                    WindowsAuthentication = checkWindowsAuthentication.Checked;
                }
            }
            else
            {
                _mySqlManager = new MySqlRepo(txtServer.Text, txtUser.Text.ToSecureString(),
                    txtPassword.Text.ToSecureString());
            }

            GetDatabases();
        }
        /// <summary>
        /// Gets the databases
        /// </summary>
        private void GetDatabases()
        {
            var databases = Provider == CustomEnums.Provider.MsSql ? _msSqlManager.GetDatabases() : _mySqlManager.GetDatabases();

            comboDatabase.Items.Clear();
            databases.OrderBy(o => o).ToList().ForEach(entry => comboDatabase.Items.Add(entry));

            comboDatabase.Enabled = databases.Count > 0;
            btnConnectToDatabase.Enabled = databases.Count > 0;
        }
        /// <summary>
        /// Connects to the database
        /// </summary>
        private void ConnectToDatabase()
        {
            if (string.IsNullOrEmpty(comboDatabase.Text))
                return;

            Database = comboDatabase.Text;
            if (Provider == CustomEnums.Provider.MsSql)
                _msSqlManager.SetDatabase(Database);
            else
                _mySqlManager.SetDatabase(Database);

            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Occurs when the user selects a provider
        /// </summary>
        private void comboProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provider = comboProvider.SelectedItem as ComboBoxItem;
            if (provider == null)
                return;

            if ((CustomEnums.Provider) provider.Value == CustomEnums.Provider.None)
                return;

            Provider = (CustomEnums.Provider) provider.Value;
            txtServer.Enabled = true;
            txtUser.Enabled = true;
            txtPassword.Enabled = true;
            btnConnectToServer.Enabled = true;

            checkWindowsAuthentication.Enabled = Provider == CustomEnums.Provider.MsSql;
        }
        /// <summary>
        /// Occurs when the user checks the windows authentication
        /// </summary>
        private void checkWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = !checkWindowsAuthentication.Checked;
            txtPassword.Enabled = !checkWindowsAuthentication.Checked;
        }
        /// <summary>
        /// Occurs when the user hits the connect button
        /// </summary>
        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            ConnectToServer();
        }
        /// <summary>
        /// Occurs when the form is loading
        /// </summary>
        private void SourceSelection_Load(object sender, EventArgs e)
        {
            InitForm();
        }
        /// <summary>
        /// Occurs when the user hits the connect button
        /// </summary>
        private void btnConnectToDatabase_Click(object sender, EventArgs e)
        {
            ConnectToDatabase();
        }
    }
}
