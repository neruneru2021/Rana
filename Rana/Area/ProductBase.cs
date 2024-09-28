using Rana.Entity;
using Rana.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rana.Area
{
    internal abstract class ProductBase
    {
        private ProductEntity _entity;

        protected ProductBase(ProductEntity entity)
        {
            _entity = entity;
        }

        public int Id => _entity.Id;
        public int ParentId => _entity.ParentId;
        public int Kind => _entity.Kind;
        public string Name => _entity.Name;

        public abstract void Add(ProductBase area);
        public abstract IEnumerable<ProductBase> GetChildren();
        public abstract void Alarm();
        public abstract Condition GetCondition();
        public abstract void Release();
    }
}
