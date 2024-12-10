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
        public IEnumerable<Author> GetAuthenticatedAuthor(string userId);
    }
}
