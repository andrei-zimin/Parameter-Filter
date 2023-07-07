using FirmLibrary;
using Lab4.Rules;
using Lab4.Rules.IntRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class CustomField1 : Field
    {
        public override string Name => "Field1";

        public override Type Type => typeof(int);

        public override BaseRule CreateRule()
        {
            return new CustomField1Rule();
        }

        public override string GetValue(Firm firm)
        {
            return firm.GetField("field1").ToString();
        }
    }
}
