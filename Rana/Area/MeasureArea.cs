using Rana.Entity;
using Rana.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rana.Area
{
    internal sealed class MeasureArea : ProductBase
    {
        public MeasureArea(ProductEntity name) : base(name)
        {

        }

        public override void Add(ProductBase area)
        {
            throw new ArgumentException("Addは出来ません");
        }

        public override void Alarm()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<ProductBase> GetChildren()
        {
            throw new NotImplementedException();
        }

        public override Condition GetCondition()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }
    }
}
