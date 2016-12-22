using System.Data.Entity;

namespace Ecommerce.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base()
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

    }
}