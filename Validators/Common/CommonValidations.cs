using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.Entities;

namespace csharp.Validators.Common
{
    public static class CommonValidations
    {
        public static bool IsItemOutOfDate(this Item item)
        {
            return item.SellIn < 0;
        }
        public static bool IsQualityNegative(this Item item)
        {
            return item.Quality < 0;
        }
        public static bool IsQualityBeyondLimits(this Item item)
        {
            return item.Quality > 50;
        }
        public static bool IsSulfuras(this Item item)
        {
            return item.Name.Contains("Sulfuras");
        }

        public static bool IsAgedBrie(this Item item)
        {
            return item.Name == "Aged Brie";
        }

        public static bool IsConjured(this Item item)
        {
            return item.Name.Contains("Conjured");
        }

        public static bool IsStageTicket(this Item item)
        {
            return item.Name.Contains("Backstage");
        }
    }
}
