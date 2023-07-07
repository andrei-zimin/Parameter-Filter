using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class CountryField : Field
    {
        public override string GetValue(Firm firm)
        {
            return firm.Country;
        }

        public override BaseRule CreateRule()
        {
            return new CountryRule();
        }

        public override string Name => "Страна";

        public override Type Type => typeof(string);
    }
}
