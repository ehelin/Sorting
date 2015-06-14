using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.ComparableIfc
{
    public class Number : IComparable<Number>
    {
        public int Value {get;set;}

        public Number(int value)
        {
            Value = value;
        }

        public int CompareTo(Number comp)
        {
            int ret = -1;
            if (Value < comp.Value)
                ret = -1;
            else if (Value > comp.Value)
                ret = 1;
            else if (Value == comp.Value)
                ret = 0;
            return ret;
        }
    }
}
