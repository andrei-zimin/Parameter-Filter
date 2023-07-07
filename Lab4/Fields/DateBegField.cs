using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class DateBegField : Field
    {
        public override string GetValue(Firm firm)
        {
            return firm.SubFirms[0].Contacts[0].BeginDt.ToString();
        }

        public override BaseRule CreateRule()
        {
            return new DateBegRule();
        }

        public override string Name => "Дата начала";

        public override Type Type => typeof(DateTime);
    }
}
