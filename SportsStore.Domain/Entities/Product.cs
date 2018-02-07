// compile with: /doc:SportStoreDoc.xml 

namespace SportsStore.Domain.Entities
{
    /// <summary>
    /// This class represents the base shop's product</summary>
    public class Product
    {
        /// <summary>
        /// The DB ID for the product.</summary>
        public int ProductID { get; set; }
        /// <summary>
        /// The Name of the product.</summary>
        public string Name { get; set; }
        /// <summary>
        /// The Description of the product.</summary>
        public string Description { get; set; }
        /// <summary>
        /// The Price of the product.</summary>
        public decimal Price { get; set; }
        /// <summary>
        /// The category class of the product</summary>
        public Category Category { get; set; }

    }
}
