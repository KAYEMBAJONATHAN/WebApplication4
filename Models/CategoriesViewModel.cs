using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class CategoriesViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
        public int PackQuantity { get; set; }

        public string BrandName { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; } = 0.0;
        public Category Category { get; set; }

        public List<CategoriesViewModel> productColors { get; set; }
    }

    public class CategoryListViewModel
    {
        public List<CategoriesViewModel> Products { get; set; }
    }
}
