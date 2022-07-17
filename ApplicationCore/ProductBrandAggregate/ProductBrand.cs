using SharedKernel;
using SharedKernel.Interfaces;

namespace ApplicationCore.ProductBrandAggregate
{
    public class ProductBrand : BaseEntity, IAggregateRoot
    {
        public string Brand { get; private set; }

        public ProductBrand(string brand)
        {
            Brand = brand;
        }
    }
}
