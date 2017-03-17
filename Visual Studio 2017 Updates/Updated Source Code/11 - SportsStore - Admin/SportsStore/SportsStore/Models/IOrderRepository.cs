using System.Collections.Generic;

namespace SportsStore.Models {

    public interface IOrderRepository {

        IEnumerable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
