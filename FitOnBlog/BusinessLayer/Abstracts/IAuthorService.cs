using DataAccessLayer.Contexts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IAuthorService : IGenericService<Author>
    {
        // for Author list in Admin panel and Author panel Profile page
        public IEnumerable<Author> GetAuthenticatedAuthor(string userId);

        // for Meet The Team in About page
        public List<Author> GetRandomAuthor();
    }
}
