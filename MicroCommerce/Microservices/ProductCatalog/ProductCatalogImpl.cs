using MicroCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MicroCommerce.ProductCatalog
{
    public class ProductCatalogImpl : IProductCatalog
    {
        private Product[] _products = new[]
        {
            new Product{ Id = new Guid("6BF3A1CE-1239-4528-8924-A56FF6527595"), Name = "Queijo Canastra" },
            new Product{ Id = new Guid("6BF3A1CE-1239-4528-8924-A56FF6527596"), Name = "Linguiça de pernil" },
            new Product{ Id = new Guid("6BF3A1CE-1239-4528-8924-A56FF6527597"), Name = "Doce de leite" },
            new Product{ Id = new Guid("6BF3A1CE-1239-4528-8924-A56FF6527598"), Name = "Doce de mamão" },
            new Product{ Id = new Guid("6BF3A1CE-1239-4528-8924-A56FF6527599"), Name = "Queijo de trança" }
        };

        public IEnumerable<Product> Get()
        {
            return _products;
        }

        public Product Get(Guid productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
