using System.Collections.Generic;

namespace SportsStore.Models {

    public interface IProductRepository {
        IEnumerable<Product> Products { get; }
    }
}
