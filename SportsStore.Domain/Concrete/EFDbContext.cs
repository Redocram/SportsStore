// compile with: /doc:SportStoreDoc.xml 

using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SportsStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        /// <summary>
        /// This property is connected to the Products table.</summary>
        /// <value>The type parameter of the DbSet result specifies the model type that the EF should use to represent row in that table</value>
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
