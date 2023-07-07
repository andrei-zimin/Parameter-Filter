using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public class MainController
    {
        private FirmManager firmManager = new FirmManager();
        private FirmManager sourceFirmManager;

        public FirmManager FirmManager
        {
            get
            {
                return firmManager;
            }
        }

        public MainController()
        {
            firmManager.CreateFirms();
            sourceFirmManager = firmManager;
        }

        public void OpenFilter()
        {
            FilterController filterController = new FilterController();
            filterController.FirmManager = sourceFirmManager;

            FilterForm form = new FilterForm(filterController);
            if (form.ShowDialog() == DialogResult.OK)
            {
                firmManager = filterController.ApplyFilter();
            }
        }
    }
}
