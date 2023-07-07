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
    public partial class FilterForm : Form
    {
        private FilterController filterController;
        private FilterControl filterControl;

        public FilterForm(FilterController filterController)
        {
            InitializeComponent();

            this.filterController = filterController;

            filterControl = new FilterControl(this, filterController.FirmManager.FirmView.Fields);
            filterControl.Build();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var rules = filterControl.ApplyFilters();
            filterController.Rules = rules;

            DialogResult = DialogResult.OK;
        }
    }
}
