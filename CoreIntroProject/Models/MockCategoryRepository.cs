using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreIntroProject.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Snowboards", Description="Snowboards"},
                new Category{CategoryId=2, CategoryName="Goggles", Description="Snowboard goggles"},
                new Category{CategoryId=3, CategoryName="Bindings", Description="Snowboard bindings"}
            };
    }
}
