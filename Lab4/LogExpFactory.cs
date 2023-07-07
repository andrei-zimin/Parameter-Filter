using Lab4.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class LogExpFactory
    {
        public ILogExp<T> Create<T>(LogExpEnum logExpEnum) where T : IComparable
        {
            ILogExp<T> exp = null;

            switch (logExpEnum)
            {
                case LogExpEnum.Contains:
                    exp = new ExpContains<T>();
                    break;
                case LogExpEnum.NoContains:
                    exp = new ExpNoContains<T>();
                    break;
                case LogExpEnum.Equal:
                    exp = new ExpEQ<T>();
                    break;
                case LogExpEnum.NoEqual:
                    exp = new ExpNoEQ<T>();
                    break;
                case LogExpEnum.Less:
                    exp = new ExpLess<T>();
                    break;
                case LogExpEnum.More:
                    exp = new ExpMore<T>();
                    break;
            }
            return exp;
        }
    }
}
