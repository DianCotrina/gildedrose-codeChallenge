using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.Entities;

namespace csharp.Validators.Common
{
    public static class ItemCommonProcessor
    {
        public static void UpdateQuality(this Item item)
        {
            if (item.IsItemOutOfDate()) item.Quality -= item.Quality;
            item.Quality--;
        }
        public static void UpdateSellIn(this Item item)
        {
            if (item.IsSulfuras()) return;
            item.SellIn--;
        }
    }
}
