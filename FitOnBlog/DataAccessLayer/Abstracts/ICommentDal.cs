using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        public List<Comment> GetCommentsByBlogId(int id);

        public void ChangeCommentStatusToFalse(int id);

        public void ChangeCommentStatusToTrue(int id);

        public List<Comment> GetListStatusFalse();

        public void UpdateBlogRating(int blogId);
    }
}
