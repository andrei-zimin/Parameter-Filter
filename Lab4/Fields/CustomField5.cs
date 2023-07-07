using FirmLibrary;
using Lab4.Rules;
using Lab4.Rules.StringRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class CustomField5 : Field
    {
        public override string Name => "Field5";

        public override Type Type => typeof(string);

        public override BaseRule CreateRule()
        {
            return new CustomField5Rule();
        }

        public override string GetValue(Firm firm)
        {
            return firm.GetField("field5").ToString();
        }
    }
}