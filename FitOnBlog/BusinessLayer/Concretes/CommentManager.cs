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
    public class CommentManager(ICommentDal commentDal) : ICommentService
    {
        private readonly ICommentDal _commentDal = commentDal; // Primary Constructor

        public void Delete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetListAll()
        {
            return _commentDal.GetListAll();
        }

        public void Insert(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
