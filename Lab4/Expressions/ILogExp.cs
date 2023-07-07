using FirmLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Expressions
{
    public interface ILogExp<T>
    {
        bool Compare(T value1, T value2);
    }
}
