using csharp.Entities;
using csharp.Validators;
using csharp.Validators.Common;
using System.Collections.Generic;

namespace csharp.Implementations
{
    public class GildedRose
    {
        private readonly IProductFactory _productFactory;
        private readonly IList<Item> _items;
        public GildedRose(IList<Item> items, IProductFactory productFactory)
        {
            this._items = items;
            this._productFactory = productFactory;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var productValidator = _productFactory.GetInstance(item);

                if (!item.IsQualityNegative() && !item.IsQualityBeyondLimits()) productValidator.UpdateProductItem(item);
            }
        }
    }
}
