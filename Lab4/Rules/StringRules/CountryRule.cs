using FirmLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Rules
{
    public class CountryRule : StrFieldExpr
    {
        public override bool FirmRespond(Firm firm)
        {
            return Exp.Compare(firm.Country, (string)value);
        }
    }
}
