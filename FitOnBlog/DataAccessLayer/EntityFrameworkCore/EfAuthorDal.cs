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
        public List<Author> GetRandomAuthor()
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Authors
                .OrderBy(a => Guid.NewGuid())
                .Take(3)
                .ToList();
        }

        public override void Delete(Author author)
        {
            using (var fitOnContext = new FitOnContext())
            {
                using (var transaction = fitOnContext.Database.BeginTransaction())
                {
                    try
                    {
                        var user = fitOnContext.Users
                            .FirstOrDefault(u => u.Id == author.UserId);

                        if (user != null)
                        {
                            fitOnContext.Users.Remove(user);

                            fitOnContext.Authors.Remove(author);

                            fitOnContext.SaveChanges();

                            transaction.Commit();
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
