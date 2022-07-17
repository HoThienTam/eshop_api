using SharedKernel;
using SharedKernel.Interfaces;

namespace ApplicationCore.ProductTypeAggregate
{
    public class ProductType : BaseEntity, IAggregateRoot
    {
        public string Type { get; private set; }
        public ProductType(string type)
        {
            Type = type;
        }
    }
}
