using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Expressions
{
    public class ExpNoContains<T> : ILogExp<T>
    {
        public bool Compare(T value1, T value2)
        {
            return !value1.ToString().Contains(value2.ToString());
        }
    }
}
