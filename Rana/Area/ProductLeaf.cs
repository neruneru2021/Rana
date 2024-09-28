using Rana.Entity;
using Rana.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rana.Area
{
    internal sealed class ProductLeaf : ProductBase
    {
        private Condition _condition = Condition.Normal;

        public ProductLeaf(ProductEntity entity) : base(entity)
        {

        }

        public override void Add(ProductBase area)
        {
            throw new ArgumentException(
                $"Addはできません this.Id={Id} arg.Id={area.Id}");
        }

        public override void Alarm()
        {
            _condition = Condition.Alarm;
        }

        public override IEnumerable<ProductBase> GetChildren()
        {
            return new List<ProductBase>();
        }

        public override Condition GetCondition()
        {
            return _condition;
        }

        public override void Release()
        {
            _condition = Condition.Normal;
        }
    }
}