using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Abstract
{
    interface IProductImageRepository
    {
        IEnumerable<ProductImage> ProductImages { get; }
    }
}
