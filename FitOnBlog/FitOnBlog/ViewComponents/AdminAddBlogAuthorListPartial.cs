using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    public class AdminAddBlogAuthorListPartial : ViewComponent
    {
        private readonly IAuthorService _authorService;

        public AdminAddBlogAuthorListPartial(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IViewComponentResult Invoke()
        {
            var authorList = _authorService.GetListAll();

            return View(authorList);
        }
    }
}
