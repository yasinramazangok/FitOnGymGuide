using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    //[Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categoryList = _categoryService.GetListAll();
            
            return View(categoryList);
        }

        [AllowAnonymous]
        public IActionResult CategoryListInBlogDetails()
        {
            var categoryList = _categoryService.GetListAll();
            
            return View(categoryList);
        }
    }
}
