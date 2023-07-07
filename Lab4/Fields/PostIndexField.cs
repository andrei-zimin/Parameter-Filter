using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public class PostIndexField : Field
    {
        public override string GetValue(Firm firm)
        {
            return firm.PostInx.ToString();
        }

        public override BaseRule CreateRule()
        {
            return new PostIndexRule();
        }

        public override string Name => "Индекс";

        public override Type Type => typeof(string);
    }
}
