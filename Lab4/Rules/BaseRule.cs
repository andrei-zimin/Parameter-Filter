using FirmLibrary;
using Lab4.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Rules
{
    public abstract class BaseRule
    {
        protected object value;

        public void SetValue(object v) { value = v; }

        public abstract void SetExp<T>(ILogExp<T> exp);

        public abstract bool FirmRespond(Firm firm);
    }
}
