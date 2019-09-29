using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreIntroProject.Models
{
    public class MockItemRepository: IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Item> AllItems =>
            new List<Item>
            {
                new Item {ItemId = 1, Name="Burton Board", ShortDescription="Cool Burton Board", LongDescription="Super Super Cool Burton Board", Price=120, ImageUrl="#", ImageThumbnailUrl="#", IsDealOfTheWeek=false, InStock=true, Category = _categoryRepository.AllCategories.ToList()[0]},
                new Item {ItemId = 2, Name="Burton Goggles", ShortDescription="Cool Burton Goggles", LongDescription="Super Super Cool Burton Goggles", Price=120, ImageUrl="#", ImageThumbnailUrl="#", IsDealOfTheWeek=false, InStock=true, Category = _categoryRepository.AllCategories.ToList()[1]},
                new Item {ItemId = 3, Name="Burton Bindings", ShortDescription="Cool Burton Bindings", LongDescription="Super Super Cool Burton Bindings", Price=120, ImageUrl="#", ImageThumbnailUrl="#", IsDealOfTheWeek=false, InStock=true, Category = _categoryRepository.AllCategories.ToList()[2]}
            };
        public IEnumerable<Item> ItemsOfTheWeek { get; }
        public Item GetItemById(int itemId)
        {
            return AllItems.FirstOrDefault(i => i.ItemId == itemId);
        }
    }
}
