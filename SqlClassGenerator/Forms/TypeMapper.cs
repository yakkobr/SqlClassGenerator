using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SqlClassGenerator.DataObjects;
using SqlClassGenerator.Global;

namespace SqlClassGenerator.Forms
{
    public partial class TypeMapper : Form
    {
        /// <summary>
        /// Contains the mapping data
        /// </summary>
        private List<MappingModel> _mappingData;
        /// <summary>
        /// Contains the selected provider
        /// </summary>
        private CustomEnums.Provider _provider;

        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        public TypeMapper()
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
        /// Shows the values for the given provider
        /// </summary>
        /// <param name="provider">The provider</param>
        private void ShowData(CustomEnums.Provider provider)
        {
            _provider = provider;
            _mappingData = ConfigManager.GetData();
         
            SetSource(_mappingData.Where(w => w.Provider == provider).ToList());
        }
        /// <summary>
        /// Sets the source
        /// </summary>
        /// <param name="mappingList">The mapping list</param>
        private void SetSource(List<MappingModel> mappingList)
        {
            sourceMapping.DataSource = null;
            sourceMapping.DataSource = mappingList;

            bindingNavigator.Enabled = true;
            dataGridView.Enabled = true;
            btnSave.Enabled = true;
        }
        /// <summary>
        /// Saves the data
        /// </summary>
        private void Save()
        {
            var result = new List<MappingModel>();

            // Add the current entries
            var list = sourceMapping.DataSource as List<MappingModel>;
            if (list != null)
            {
                result.AddRange(list);
            }

            // Add the other values...
            result.AddRange(_mappingData.Where(w => w.Provider != _provider));

            if (ConfigManager.WriteData(result))
                MessageBox.Show("Data saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data not saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        /// <summary>
        /// Occurs when the form is loading
        /// </summary>
        private void TypeMapper_Load(object sender, EventArgs e)
        {
            InitForm();
        }
        /// <summary>
        /// Occurs when the user hits the select button
        /// </summary>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var entry = comboProvider.SelectedItem as ComboBoxItem;
            if (entry?.Value != null)
            {
                ShowData((CustomEnums.Provider) entry.Value);
            }
        }
        /// <summary>
        /// Occurs when the user hits the save button
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        /// <summary>
        /// Occurs when the user adds a new object
        /// </summary>
        private void sourceMapping_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            e.NewObject = new MappingModel {Provider = _provider};
        }
    }
}
