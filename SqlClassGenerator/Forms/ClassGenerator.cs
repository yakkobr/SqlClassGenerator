using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SqlClassGenerator.Database;
using SqlClassGenerator.DataObjects;
using SqlClassGenerator.Global;

namespace SqlClassGenerator.Forms
{
    public partial class ClassGenerator : Form
    {
        /// <summary>
        /// Contains the current provider
        /// </summary>
        private CustomEnums.Provider _provider;
        /// <summary>
        /// Contains the my sql repo
        /// </summary>
        private MySqlRepo _mySqlRepo;
        /// <summary>
        /// Contains the mssql repo
        /// </summary>
        private MsSqlRepo _msSqlRepo;
        /// <summary>
        /// Contains the column list
        /// </summary>
        private List<ColumnModel> _columnList;

        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        public ClassGenerator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Shows the databases
        /// </summary>
        private void ShowDatabases()
        {
            comboDatabase.Items.Clear();
            var database = _provider == CustomEnums.Provider.MsSql
                ? _msSqlRepo.GetDatabases()
                : _mySqlRepo.GetDatabases();

            database.OrderBy(o => o).ToList().ForEach(entry => comboDatabase.Items.Add(entry));
        }
        /// <summary>
        /// Connects to the given database
        /// </summary>
        private void ConnectToDatabase()
        {
            if (string.IsNullOrEmpty(comboDatabase.Text))
                return;

            if (_provider == CustomEnums.Provider.MsSql)
                _msSqlRepo.SetDatabase(comboDatabase.Text);
            else
                _mySqlRepo.SetDatabase(comboDatabase.Text);

            comboTables.Enabled = true;
            txtClassName.Enabled = true;
            checkAutoProperty.Enabled = true;
            btnGenerate.Enabled = true;

            ShowTables();
        }
        /// <summary>
        /// Shows the tables in the combo box
        /// </summary>
        private void ShowTables()
        {
            var tables = _provider == CustomEnums.Provider.MsSql ? _msSqlRepo.GetTables() : _mySqlRepo.GetTables();

            comboTables.Items.Clear();
            tables.OrderBy(o => o).ToList().ForEach(entry => comboTables.Items.Add(entry));
        }
        /// <summary>
        /// Generates the class
        /// </summary>
        private void GenerateClass()
        {
            if (string.IsNullOrEmpty(comboTables.Text))
                return;

            if (string.IsNullOrEmpty(txtClassName.Text))
                return;

            _columnList = _provider == CustomEnums.Provider.MsSql
                ? _msSqlRepo.GetTableInformation(comboTables.Text)
                : _mySqlRepo.GetTableInformation(comboTables.Text);

            if (_columnList != null)
                btnCopy.Enabled = btnColumnChooser.Enabled = true;

            richTextBox.Text = Helper.CreateClass(_provider, txtClassName.Text, checkAutoProperty.Checked, _columnList);
        }
        /// <summary>
        /// Occurs when the form was shown
        /// </summary>
        private void ClassGenerator_Shown(object sender, EventArgs e)
        {
            var selector = new SourceSelection();
            if (selector.ShowDialog() == DialogResult.OK)
            {
                _provider = selector.Provider;
                _mySqlRepo = selector.MySqlConnection;
                _msSqlRepo = selector.MsSqlConnection;

                ShowDatabases();
            }
        }
        /// <summary>
        /// Occurs when the user hits the generate button
        /// </summary>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateClass();
        }
        /// <summary>
        /// Occurs when the user hits the settings button
        /// </summary>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settings = new TypeMapper();
            settings.ShowDialog();
        }
        /// <summary>
        /// Occurs when the user hits the column chooser button
        /// </summary>
        private void btnColumnChooser_Click(object sender, EventArgs e)
        {
            var columnChooser = new ColumnSelector(_provider, _columnList);
            columnChooser.ShowDialog();

            richTextBox.Text = Helper.CreateClass(_provider, txtClassName.Text, checkAutoProperty.Checked, columnChooser.ColumnList);
        }
        /// <summary>
        /// Occurs when the user hits the copy button
        /// </summary>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox.Text);
        }
        /// <summary>
        /// Occurs when the user hits the connect button
        /// </summary>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectToDatabase();
        }
    }
}
