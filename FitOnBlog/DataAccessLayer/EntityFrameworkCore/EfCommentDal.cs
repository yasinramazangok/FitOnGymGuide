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
    public class EfCommentDal : GenericRepositoryDal<Comment>, ICommentDal
    {
        public List<Comment> GetCommentsByBlogId(int id)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Comments.
                        Where(b => b.BlogId == id)
                        .Include(b => b.Blog)
                        .ToList();
        }
    }
}
