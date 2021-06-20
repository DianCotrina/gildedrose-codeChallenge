using csharp.Entities;
using csharp.Interfaces;

namespace csharp.Validators
{
    public interface IProductFactory
    {
        IProductValidator GetInstance(Item item);
    }
}