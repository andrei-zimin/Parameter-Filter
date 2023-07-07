using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class FilterController
    {
        public FirmManager FirmManager { get; set; }

        public List<BaseRule> Rules { get; set; }

        public FirmManager ApplyFilter()
        {
            List<Firm> firms = new List<Firm>();

            foreach (var item in FirmManager.Firms)
            {
                bool check = true;

                foreach (var rule in Rules)
                {
                    if (!rule.FirmRespond(item))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    firms.Add(item);
            }

            return new FirmManager(firms);
        }
    }
}
