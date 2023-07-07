using FirmLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Rules
{
    public class DateInRule : DateFieldExpr
    {
        public override bool FirmRespond(Firm firm)
        {
            return Exp.Compare(firm.Dateln, (DateTime)value);
        }
    }
}
