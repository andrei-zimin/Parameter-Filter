using FirmLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Rules.StringRules
{
    public class CustomField5Rule : StrFieldExpr
    {
        public override bool FirmRespond(Firm firm)
        {
            return Exp.Compare((string)firm.GetField("field5"), (string)value);
        }
    }
}