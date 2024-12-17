using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    public class AboutMeetTheTeamPartial : ViewComponent
    {
        private readonly IAuthorService _authorService;

        public AboutMeetTheTeamPartial(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _authorService.GetRandomAuthor();
            return View(values);
        }
    }
}
