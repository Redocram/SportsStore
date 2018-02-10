using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class EFProductImageRepository : IProductImageRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<ProductImage> ProductImages
        {
            get { return context.ProductImages; }

        }
    }
}
