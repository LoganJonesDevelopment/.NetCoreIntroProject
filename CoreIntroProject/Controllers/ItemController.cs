using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreIntroProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreIntroProject.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            return View(_itemRepository.AllItems);
        }
    }
}