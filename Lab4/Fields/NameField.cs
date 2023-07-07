using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class NameField : Field
    {
        public override string Name => "Название";

        public override string GetValue(Firm firm)
        {
            return firm.Name;
        }

        public override BaseRule CreateRule()
        {
            return new NameRule();
        }

        public override Type Type => typeof(string);
    }
}
