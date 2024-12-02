using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    public class BlogDetailsCategoryListPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public BlogDetailsCategoryListPartial(ICategoryService categoryService)
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
