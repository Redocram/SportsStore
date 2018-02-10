// compile with: /doc:SportStoreDoc.xml 

using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    /// <summary>
    /// This class associate the models with the db</summary>
    public class EFDbContext : DbContext
    {
        /// <summary>
        /// This property is connected to the Products table.</summary>
        /// <value>The type parameter of the DbSet result specifies the model type that the EF should use to represent row in that table</value>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// This property is connected to the Categories table.</summary>
        /// <value>The type parameter of the DbSet result specifies the model type that the EF should use to represent row in that table</value>
        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

    }
}
