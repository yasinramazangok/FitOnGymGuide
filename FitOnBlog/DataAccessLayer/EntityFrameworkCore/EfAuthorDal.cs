using DataAccessLayer.Abstracts;
using DataAccessLayer.Concretes;
using DataAccessLayer.Contexts;
using EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameworkCore
{
    public class EfAuthorDal : GenericRepositoryDal<Author>, IAuthorDal
    {
        public IEnumerable<Author> GetAuthenticatedAuthor(string userId)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Authors
                .Where(a => a.UserId == userId)
                .ToList();
        }

        // for Meet The Team in About
        public override List<Author> GetListAll()
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Authors
                .OrderBy(a => Guid.NewGuid())
                .Take(3) 
                .ToList();
        }
    }
}
