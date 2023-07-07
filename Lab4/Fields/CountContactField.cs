using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class CountContactField : Field
    {
        public override string GetValue(Firm firm)
        {
            return firm.SubFirms[0].CountContacts.ToString();
        }

        public override BaseRule CreateRule()
        {
            return new ContactCountRule();
        }

        public override string Name => "Число контактов";

        public override Type Type => typeof(int);
    }
}
