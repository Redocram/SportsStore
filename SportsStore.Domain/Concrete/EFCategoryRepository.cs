﻿using SportsStore.Domain.Abstract;
using System.Collections.Generic;
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
