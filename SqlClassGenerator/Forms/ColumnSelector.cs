using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SqlClassGenerator.DataObjects;
using SqlClassGenerator.Global;

namespace SqlClassGenerator.Forms
{
    public partial class ColumnSelector : Form
    {
        /// <summary>
        /// Contains the selected provider
        /// </summary>
        private readonly CustomEnums.Provider _provider;
        /// <summary>
        /// Contains the column list
        /// </summary>
        public List<ColumnModel> ColumnList { get; private set; }

        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        /// <param name="provider">The provider</param>
        /// <param name="columnList"></param>
        public ColumnSelector(CustomEnums.Provider provider, List<ColumnModel> columnList)
        {
            InitializeComponent();
            ColumnList = columnList;
            _provider = provider;
        }
        /// <summary>
        /// Adds the entries to the list view
        /// </summary>
        private void AddEntries()
        {
            foreach (var column in ColumnList)
            {
                var item = new ListViewItem(column.Field) {Tag = column};
                item.SubItems.Add(column.Type);
                item.SubItems.Add(Helper.GetType(_provider, column.Type));

                listView.Items.Add(item);
            }
        }
        /// <summary>
        /// Occurs when the form is loading
        /// </summary>
        private void ColumnSelector_Load(object sender, EventArgs e)
        {
            AddEntries();
        }
        /// <summary>
        /// Occurs when the user hits the ok button
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            var result = new List<ColumnModel>();
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Checked)
                {
                    result.Add(item.Tag as ColumnModel);
                }
            }
            ColumnList = result;

            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Occurs when the user hits the mark all button
        /// </summary>
        private void btnMarkAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listView.Items.OfType<ListViewItem>())
            {
                item.Checked = true;
            }
        }
        /// <summary>
        /// Occurs when the user hits the mark none button
        /// </summary>
        private void btnMarkNone_Click(object sender, EventArgs e)
        {
            foreach (var item in listView.Items.OfType<ListViewItem>())
            {
                item.Checked = false;
            }
        }
    }
}
