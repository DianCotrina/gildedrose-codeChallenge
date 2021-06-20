using csharp.Entities;
using csharp.Interfaces;
using csharp.Validators.Common;

namespace csharp.Validators
{
    public class ProductValidator : IProductValidator
    {
        public void UpdateProductItem(Item item)
        {
            item.UpdateQuality();
            item.UpdateSellIn();
        }
    }
}
