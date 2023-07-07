using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Expressions
{
    public class ExpLess<T> : ILogExp<T> where T : IComparable
    {
        public bool Compare(T value1, T value2)
        {
            return value1.CompareTo(value2) < 0;
        }
    }
}
