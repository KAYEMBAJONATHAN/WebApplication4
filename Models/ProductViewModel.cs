using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }
        public int PackQuantity { get; set; }

        public string BrandName { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public CategoryViewModel Category { get; set; }

        public List<ProductColorViewModel> productColors { get; set; }
    }
    public class ProductListViewModel
    {
        public List<ProductViewModel> Products { get; set; }
    }

}