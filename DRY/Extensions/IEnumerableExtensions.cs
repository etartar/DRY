﻿using System.Collections.Generic;
using System.Linq;

namespace DRY.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<(T item, int index)> LoopIndex<T>(this IEnumerable<T> self) => 
            self.Select((item, index) => (item, index));
    }
}
