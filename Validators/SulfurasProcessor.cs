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
    public class SulfurasProcessor : IProductValidator
    {
        public void UpdateProductItem(Item item)
        {
            if (item.IsItemOutOfDate()) item.Quality = 0;
            item.Quality = 80;
        }
    }
}
