using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.Entities;
using csharp.Interfaces;
using csharp.Validators.Common;

namespace csharp.Validators
{
    public class ProductFactory : IProductFactory
    {
        public IProductValidator GetInstance(Item item)
        {
            if(GetItemType(item) == ItemType.Sulfuras)
                return new SulfurasProcessor();
            if(GetItemType(item) == ItemType.AgedBrie)
                return new AgedBrieProcessor();
            if(GetItemType(item) == ItemType.Conjured)
                return new ConjuredProductProcessor();
            if(GetItemType(item) == ItemType.StageTicket)
                return new StageTicketProcessor();
            return new ProductValidator();
        }

        public static ItemType GetItemType(Item item)
        {
            if (item.IsSulfuras()) return ItemType.Sulfuras;
            if (item.IsAgedBrie()) return ItemType.AgedBrie;
            if (item.IsConjured()) return ItemType.Conjured;
            return item.IsStageTicket() ? ItemType.StageTicket : ItemType.Normal;
        }
    }
}
