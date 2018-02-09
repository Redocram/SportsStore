using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Category> Categories
        {
            get { return context.Categories; }
        }
    }
}
