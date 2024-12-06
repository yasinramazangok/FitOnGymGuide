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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void ChangeCommentStatusToFalse(int id)
        {
            _commentDal.ChangeCommentStatusToFalse(id);
        }

        public void ChangeCommentStatusToTrue(int id)
        {
            _commentDal.ChangeCommentStatusToTrue(id);
        }

        public void Delete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetCommentsByBlogId(int blogId)
        {
            return _commentDal.GetCommentsByBlogId(blogId);
        }

        public List<Comment> GetListAll()
        {
            return _commentDal.GetListAll();
        }

        public List<Comment> GetListStatusFalse()
        {
            return _commentDal.GetListStatusFalse();
        }

        public void Insert(Comment comment)
        {
            if (string.IsNullOrWhiteSpace(comment?.Name) || comment.Name.Length > 50 || comment.Name.Length < 2 || string.IsNullOrWhiteSpace(comment?.Email) || comment.Email.Length > 50 || comment.Email.Length < 11 || string.IsNullOrWhiteSpace(comment?.CommentText) || comment.CommentText.Length > 300 || comment.CommentText.Length < 1)
            {
                throw new NotImplementedException();
            }
            _commentDal.Insert(comment);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
