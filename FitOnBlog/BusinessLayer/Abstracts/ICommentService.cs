using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface ICommentService : IGenericService<Comment>
    {
        // for Blog Comment list in Admin panel and Comment list in Blog details
        public List<Comment> GetCommentsByBlogId(int id);

        // for Comment status
        public void ChangeCommentStatusToFalse(int id);

        // for Comment status
        public void ChangeCommentStatusToTrue(int id);

        // for removed Comment list in Admin and Author panel
        public List<Comment> GetListStatusFalse();
    }
}
