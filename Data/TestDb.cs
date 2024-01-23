using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Data
{
    public class TestDb:DbContext
    {
        public TestDb(DbContextOptions<TestDb> options) : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<ProductColor> ProductColors { get; set; }
    }
}
