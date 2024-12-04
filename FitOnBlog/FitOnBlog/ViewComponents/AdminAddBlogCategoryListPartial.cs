using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    public class AdminAddBlogCategoryListPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public AdminAddBlogCategoryListPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categoryList = _categoryService.GetListAll();

            return View(categoryList);
        }
    }
}
