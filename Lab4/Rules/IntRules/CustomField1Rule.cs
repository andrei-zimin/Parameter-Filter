using FirmLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Rules.IntRules
{
    public class CustomField1Rule : IntFieldExpr
    {
        public override bool FirmRespond(Firm firm)
        {
            return Exp.Compare((int)firm.GetField("field1"), (int)value);
        }
    }
}
