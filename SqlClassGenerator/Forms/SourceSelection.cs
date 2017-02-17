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
        /// Gets the my sql connection
        /// </summary>
        public MySqlRepo MySqlConnection { get; private set; }

        /// <summary>
        /// Gets the mssql connection
        /// </summary>
        public MsSqlRepo MsSqlConnection { get; private set; }

        /// <summary>
        /// Gets the selected provider
        /// </summary>
        public CustomEnums.Provider Provider { get; private set; }

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

            if (Provider == CustomEnums.Provider.MsSql)
            {
                if (checkWindowsAuthentication.Checked)
                {
                    MsSqlConnection = new MsSqlRepo(txtServer.Text, null, null, checkWindowsAuthentication.Checked);
                }
                else
                {
                    MsSqlConnection = new MsSqlRepo(txtServer.Text, txtUser.Text.ToSecureString(),
                        txtPassword.Text.ToSecureString(), checkWindowsAuthentication.Checked);
                }
            }
            else
            {
                MySqlConnection = new MySqlRepo(txtServer.Text, txtUser.Text.ToSecureString(),
                    txtPassword.Text.ToSecureString());
            }

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
    }
}
