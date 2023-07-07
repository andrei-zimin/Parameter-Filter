using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class TownField : Field
    {
        public override string GetValue(Firm firm)
        {
            return firm.Town;
        }

        public override BaseRule CreateRule()
        {
            return new TownRule();
        }

        public override string Name => "Город";

        public override Type Type => typeof(string);
    }
}
