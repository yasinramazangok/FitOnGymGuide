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
    public class AuthorManager : IAuthorService
    {
        // See the comments where a method is defined to learn what it does 

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

        public List<Author> GetRandomAuthor()
        {
            return _authorDal.GetRandomAuthor();
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
