using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rana.Entity
{
    public sealed class ProductEntity
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Kind { get; set; }
        public string Name { get; set; }

        public ProductEntity(int id, int parentId, int kind, string name)
        {
            Id = id;
            ParentId = parentId;
            Kind = kind;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id={Id}, ParentId={ParentId}, Kind={Kind}, Name={Name}";
        }

    }
}