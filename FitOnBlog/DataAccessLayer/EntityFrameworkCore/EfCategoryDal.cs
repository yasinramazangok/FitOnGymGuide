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
    public class EfCategoryDal : GenericRepositoryDal<Category>, ICategoryDal
    {
        public void DecrementBlogCount(int categoryId)
        {
            using var fitOnContext = new FitOnContext();

            fitOnContext.Database.ExecuteSqlRaw("EXEC DecrementBlogCount @CategoryId = {0}", categoryId);
        }

        public void IncrementBlogCount(int categoryId)
        {
            using var fitOnContext = new FitOnContext();

            fitOnContext.Database.ExecuteSqlRaw("EXEC IncrementBlogCount @CategoryId = {0}", categoryId);
        }    
    }
}
