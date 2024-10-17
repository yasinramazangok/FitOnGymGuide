using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class AuthorManager(IAuthorDal authorDal) : IAuthorService
    {
        private readonly IAuthorDal _authorDal = authorDal; // Primary Constructor  

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
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
