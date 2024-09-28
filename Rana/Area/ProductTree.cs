using Rana.Entity;
using Rana.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rana.Area
{
    internal sealed class ProductTree : ProductBase
    {
        private List<ProductBase> _products = new List<ProductBase>();

        public ProductTree(ProductEntity entity) : base(entity)
        {

        }

        public override void Add(ProductBase product)
        {
            _products.Add(product);
        }

        public override void Alarm()
        {
            throw new ArgumentException("一括設定は出来ません");
        }

        public override IEnumerable<ProductBase> GetChildren()
        {
            return _products;
        }

        public override Condition GetCondition()
        {
            return
                _products.Where(t => t.GetCondition() == Condition.Alarm).Any() ?
                Condition.Alarm :
                Condition.Normal;
        }

        public override void Release()
        {
            foreach (var product in _products)
                product.Release();
        }
    }
}
