using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class RegionField : Field
    {
        public override string GetValue(Firm firm)
        {
            return firm.Region;
        }

        public override BaseRule CreateRule()
        {
            return new RegionRule();
        }

        public override string Name => "Регион";

        public override Type Type => typeof(string);
    }
}
