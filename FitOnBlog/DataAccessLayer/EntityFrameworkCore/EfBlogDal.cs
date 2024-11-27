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
    public class EfBlogDal : GenericRepositoryDal<Blog>, IBlogDal
    {
        public override List<Blog> GetListAll()
        {
            using var fitOnContext = new FitOnContext();

            // Include ile ilişkili verileri dahil ediyoruz
            return fitOnContext.Blogs
                .Include(blog => blog.Author)   // Author'ı dahil et
                .Include(blog => blog.Category) // Category'yi dahil et
                .ToList();
        }
    }
}
