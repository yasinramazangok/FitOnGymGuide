using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        #region Admin Operations

        public IActionResult Index()
        {
            var values = _authorService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAuthor(Author author)
        {
            _authorService.Insert(author);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAuthor(int id)
        {
            var value = _authorService.GetById(id);
            _authorService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAuthor(int id)
        {
            var value = _authorService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAuthor(Author author)
        {
            if (ModelState.IsValid)
            {
                _authorService.Update(author);
                return RedirectToAction("Index");
            }

            return View();
        }

        #endregion

        #region UI Operations

        [AllowAnonymous]
        public IActionResult AuthorAbout()
        {
            return View();
        }

        #endregion
    }
}
