using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rana.Entity
{
    public class ObjectLv1<T1, T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }

        public ObjectLv1(T1 value, T2 value2)
        {
            Value1 = value;
            Value2 = value2;
        }
    }
}