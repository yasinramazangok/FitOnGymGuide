﻿using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }

        public IEnumerable<Author> GetAuthenticatedAuthor(string userId)
        {
            return _authorDal.GetAuthenticatedAuthor(userId);
        }

        public Author GetById(int id)
        {
            return _authorDal.GetById(id);
        }

        public List<Author> GetListAll()
        {
            return _authorDal.GetListAll();
        }

        public void Insert(Author author)
        {
            _authorDal.Insert(author);
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
