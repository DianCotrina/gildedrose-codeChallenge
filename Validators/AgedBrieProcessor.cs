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
    public class AgedBrieProcessor : IProductValidator
    {
        public void UpdateProductItem(Item item)
        {
            item.UpdateSellIn();
            if (item.IsItemOutOfDate()) item.Quality += 2;
            item.Quality++;

            item.Quality = item.IsItemOutOfDate() ? item.Quality += 2 : item.Quality++;
        }
    }
}
