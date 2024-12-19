using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface ICategoryService : IGenericService<Category>
    {
        // for Blog count in Category
        public void IncrementBlogCount(int categoryId);

        // for Blog count in Category
        public void DecrementBlogCount(int categoryId);

    }
}
