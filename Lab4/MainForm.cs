using FirmLibrary;
using Lab4.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        MainController mainController = new MainController();

        public MainForm()
        {
            InitializeComponent();
            
            CreateColumns();
            LoadData();
        }

        private void CreateColumns()
        {
            var fields = mainController.FirmManager.FirmView.Fields;

            foreach (var field in fields)
            {
                listView1.Columns.Add(field.GetType().Name);
            }
        }

        private void LoadData()
        {
            listView1.Items.Clear();

            var fields = mainController.FirmManager.FirmView.Fields;

            foreach (var firm in mainController.FirmManager.Firms)
            {
                string[] values = new string[fields.Count];
                int i = 0;
                foreach (var field in fields)
                {
                    values[i] = field.GetValue(firm);
                    i++;
                }

                ListViewItem lvi = new ListViewItem(values);
                listView1.Items.Add(lvi);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            mainController.OpenFilter();

            LoadData();
        }
    }
}
