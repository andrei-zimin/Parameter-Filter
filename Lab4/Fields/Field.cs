using FirmLibrary;
using Lab4.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Fields
{
    public abstract class Field
    {
        public abstract string GetValue(Firm firm);
        public abstract BaseRule CreateRule();

        public abstract string Name { get; }

        public abstract Type Type { get; }
    }
}
