using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class DateInField : Field
    {
        public override string GetValue(Firm firm)
        {
            return firm.Dateln.ToString();
        }

        public override BaseRule CreateRule()
        {
            return new DateInRule();
        }

        public override string Name => "Дата ввода";

        public override Type Type => typeof(DateTime);
    }
}
