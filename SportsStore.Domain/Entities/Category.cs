// compile with: /doc:SportStoreDoc.xml 

namespace SportsStore.Domain.Entities
{
    /// <summary>
    /// This class rapresents the category.</summary>
    public class Category
    {
        /// <summary>
        /// The DB ID for the category.</summary>
        public int CategoryID { get; set; }
        /// <summary>
        /// The Name of the category.</summary>
        public string Name { get; set; }
        /// <summary>
        /// The Description of the category.</summary>
        public string Description { get; set; }
    }
}