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
        public void ChangeCommentStatusToFalse(int id)
        {
            using var fitOnContext = new FitOnContext();

            var comment = fitOnContext.Comments.FirstOrDefault(c => c.CommentId == id);
            if (comment != null)
            {
                comment.Status = false;
                fitOnContext.SaveChanges();
            }
        }

        public void ChangeCommentStatusToTrue(int id)
        {
            using var fitOnContext = new FitOnContext();

            var comment = fitOnContext.Comments.FirstOrDefault(c => c.CommentId == id);
            if (comment != null)
            {
                comment.Status = true;
                fitOnContext.SaveChanges();
            }
        }

        public List<Comment> GetCommentsByBlogId(int id)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Comments.
                        Where(b => b.BlogId == id && b.Status == true)
                        .Include(b => b.Blog)
                        .ToList();
        }

        public override List<Comment> GetListAll()
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Comments
                .Where(c => c.Status == true)
                .Include(blog => blog.Blog)
                .ToList();
        }

        public List<Comment> GetListStatusFalse()
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Comments
                .Where(c => c.Status == false)
                .Include(blog => blog.Blog)
                .ToList();
        }
    }
}
