using System.Collections.Generic;

namespace SportsStore.Models {

    public class FakeProductRepository : IProductRepository {

        public IEnumerable<Product> Products => new List<Product> {
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Surf board", Price = 179 },
            new Product { Name = "Running shoes", Price = 95 }
        };
    }
}
