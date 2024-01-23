using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Data
{
    public class Product : BaseModel
    {
       // [PrimaryKey]
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }
        public int PackQuantity { get; set; }

        public string BrandName { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public Category Category { get; set; }

        public List<ProductColor> productColors { get; set; }
    }
}
