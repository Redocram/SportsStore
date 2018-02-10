// compile with: /doc:SportStoreDoc.xml 

using System.ComponentModel.DataAnnotations;

namespace SportsStore.Domain.Entities
{
    public class ProductImage
    {
        [Key]
        public int ImageID { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public int ProductID { get; set; }
    }
}
