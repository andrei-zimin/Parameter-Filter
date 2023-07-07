using FirmLibrary;
using Lab4.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Rules
{
    public abstract class IntFieldExpr : BaseRule
    {
        public ILogExp<int> Exp { get; set; }

        public override void SetExp<T>(ILogExp<T> exp)
        {
            Exp = (ILogExp<int>)exp;
        }
    }
}
