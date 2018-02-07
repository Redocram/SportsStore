// compile with: /doc:SportStoreDoc.xml 

using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Abstract
{
    /// <summary>
    /// This interface uses IEnumerable<T> to allow a caller to obtain a sequence of Product objects, without saying how or where the data is stored or retrieved.
    /// <para>This is the essence of the repository pattern.</para></summary>
    public interface IProductRepository
    {
        /// <summary>
        /// A sequence of Product objects.</summary>
        IEnumerable<Product> Products { get; }
    }
}
