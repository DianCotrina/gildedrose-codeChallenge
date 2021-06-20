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
    public class StageTicketProcessor : IProductValidator
    {
        public void UpdateProductItem(Item item)
        {
            item.UpdateSellIn();
            if (item.IsItemOutOfDate()) item.Quality = 0;
            else if (item.SellIn <= 10) item.Quality += 2;
            else if (item.SellIn <= 5) item.Quality += 3;
            else item.Quality++;
        }
    }
}
