using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlClassGenerator.DataObjects;
using SqlClassGenerator.Global;

namespace SqlClassGenerator.Forms
{
    public partial class ColumnSelector : Form
    {
        private CustomEnums.Provider _provider;
        public List<ColumnModel> ColumnList { get; private set; }

        public ColumnSelector(CustomEnums.Provider provider, List<ColumnModel> columnList)
        {
            InitializeComponent();
            ColumnList = columnList;
            _provider = provider;
        }

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

        private void ColumnSelector_Load(object sender, EventArgs e)
        {
            AddEntries();
        }

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

        private void btnMarkAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listView.Items.OfType<ListViewItem>())
            {
                item.Checked = true;
            }
        }

        private void btnMarkNone_Click(object sender, EventArgs e)
        {
            foreach (var item in listView.Items.OfType<ListViewItem>())
            {
                item.Checked = false;
            }
        }
    }
}
