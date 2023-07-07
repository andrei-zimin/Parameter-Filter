using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class WebField : Field
    {
        public override string GetValue(Firm firm)
        {
            return firm.Web;
        }

        public override BaseRule CreateRule()
        {
            return new WebRule();
        }

        public override string Name => "Web";

        public override Type Type => typeof(string);
    }
}
