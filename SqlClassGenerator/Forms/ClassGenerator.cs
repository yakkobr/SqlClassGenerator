using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlClassGenerator.Database;
using SqlClassGenerator.DataObjects;
using SqlClassGenerator.Global;

namespace SqlClassGenerator.Forms
{
    public partial class ClassGenerator : Form
    {
        private CustomEnums.Provider _provider;
        private MySqlRepo _mySqlRepo;
        private MsSqlRepo _msSqlRepo;
        private List<ColumnModel> _columnList;

        public ClassGenerator()
        {
            InitializeComponent();
        }

        private void GetTables()
        {
            var tables = _provider == CustomEnums.Provider.MsSql ? _msSqlRepo.GetTables() : _mySqlRepo.GetTables();

            comboTables.Items.Clear();
            tables.OrderBy(o => o).ToList().ForEach(entry => comboTables.Items.Add(entry));
        }

        private void GenerateClass()
        {
            if (string.IsNullOrEmpty(comboTables.Text))
                return;

            _columnList = _provider == CustomEnums.Provider.MsSql
                ? _msSqlRepo.GetTableInformation(comboTables.Text)
                : _mySqlRepo.GetTableInformation(comboTables.Text);

            if (_columnList != null)
                btnCopy.Enabled = btnColumnChooser.Enabled = true;

            richTextBox.Text = Helper.CreateClass(_provider, comboTables.Text, true, _columnList);
        }

        private void ClassGenerator_Shown(object sender, EventArgs e)
        {
            var selector = new SourceSelection();
            if (selector.ShowDialog() == DialogResult.OK)
            {
                _provider = selector.Provider;
                _mySqlRepo = selector.MySqlConnection;
                _msSqlRepo = selector.MsSqlConnection;

                GetTables();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateClass();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settings = new TypeMapper();
            settings.ShowDialog();
        }

        private void btnColumnChooser_Click(object sender, EventArgs e)
        {
            var columnChooser = new ColumnSelector(_provider, _columnList);
            columnChooser.ShowDialog();

            richTextBox.Text = Helper.CreateClass(_provider, comboTables.Text, true, columnChooser.ColumnList);
        }
    }
}
