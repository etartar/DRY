using System;
using System.Collections.Generic;
using System.Linq;

namespace DRY.ReplaceIFElseStatement
{
    public class ReplaceIFElseStatementGood : ReplaceIFElseStatementBase
    {
        private IList<(Predicate<decimal> predicate, Func<decimal, decimal> action)> SetCommondsMap()
        {
            var commonds = new List<(Predicate<decimal> predicate, Func<decimal, decimal> action)>();

            commonds.Add((
                (total) => total >= 50 && total < 100,
                (total) => total - (total * 2) / 100
                ));
            commonds.Add((
                (total) => total >= 100 && total < 500,
                (total) => total - (total * 5) / 100
                ));
            commonds.Add((
                (total) => total >= 500,
                (total) => total - (total * 10) / 100
                ));
            commonds.Add((
                (total) => true,
                (total) => total
                ));

            return commonds;
        } 

        public decimal CalculateTotalAfterDiscount()
        {
            return SetCommondsMap().First(a => a.predicate(TotalOrder)).action(TotalOrder);
        }
    }
}
