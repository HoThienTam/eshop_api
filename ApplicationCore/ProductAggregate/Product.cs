using ApplicationCore.ProductBrandAggregate;
using ApplicationCore.ProductTypeAggregate;
using SharedKernel;
using SharedKernel.GuardClauses;
using SharedKernel.Interfaces;

namespace ApplicationCore.ProductAggregate
{
    public class Product : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string PictureUri { get; private set; }
        public int ProductTypeId { get; private set; }
        public ProductType? ProductType { get; private set; }
        public int ProductBrandId { get; private set; }
        public ProductBrand? ProductBrand { get; private set; }

        public Product(
            string name,
            string description,
            decimal price,
            string pictureUri,
            int productTypeId,
            int productBrandId)
        {
            Name = name;
            Description = description;
            Price = price;
            PictureUri = pictureUri;
            ProductTypeId = productTypeId;
            ProductBrandId = productBrandId;
        }

        public void UpdateDetails(string name, string description, decimal price)
        {
            Assert.NotNullOrEmpty(name, nameof(name));
            Assert.NotNullOrEmpty(description, nameof(description));
            Assert.NotNegativeOrZero(price, nameof(price));

            Name = name;
            Description = description;
            Price = price;
        }
        public void UpdatePictureUri(string pictureName)
        {
            if (string.IsNullOrEmpty(pictureName))
            {
                PictureUri = string.Empty;
                return;
            }
            PictureUri = $"images\\products\\{pictureName}?{new DateTime().Ticks}";
        }

        public void UpdateBrand(int productBrandId)
        {
            Assert.NotNegativeOrZero(productBrandId, nameof(productBrandId));
            ProductBrandId = productBrandId;
        }

        public void UpdateType(int productTypeId)
        {
            Assert.NotNegativeOrZero(productTypeId, nameof(productTypeId));
            ProductTypeId = productTypeId;
        }
    }
}
