using System.Collections.Generic;
using System.Linq;

namespace DRY.ReplaceIFElseStatement
{
    public class ReplaceIFElseStatementBase
    {
        private readonly List<Order> _order = new List<Order>()
        {
            new Order { QTN = 2, ItemPrice = 34, ProductName = "Af" },
            new Order { QTN = 2, ItemPrice = 34, ProductName = "Aer" },
            new Order { QTN = 2, ItemPrice = 34, ProductName = "ghf" },
        };

        public decimal TotalOrder => _order.Sum(a => a.QTN * a.ItemPrice);
    }
}
