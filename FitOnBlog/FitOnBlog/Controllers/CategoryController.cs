using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    [Authorize]
    public class CategoryController(ICategoryService categoryService) : Controller
    {
        private readonly ICategoryService _categoryService = categoryService; // Primary Constructor

        public IActionResult Index()
        {
            var values = _categoryService.GetListAll();
            return View(values);
        }

        public IActionResult CategoryList()
        {
            // This partial view shows the category list in the blog details.
            return View();
        }
    }
}
