﻿using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitOnBlog.Controllers
{
    [Authorize(Roles = "Admin, Yazar")]
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
            IEnumerable<Author> values;

            if (User.IsInRole("Admin"))
            {
                values = _authorService.GetListAll();
            }

            else if (User.IsInRole("Yazar"))
            {
                string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                values = _authorService.GetAuthenticatedAuthor(userId);
            }

            else
            {
                values = new List<Author>();
            }

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
