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
        public Blog GetLastBlogByCategory(int categoryId)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs
                        .Where(c => c.CategoryId == categoryId)
                        .OrderByDescending(d => d.BlogId)
                        .Select(b => new Blog
                        {
                            Title = b.Title,
                            ImageUrl = b.ImageUrl,
                            Date = b.Date
                        })
                        .FirstOrDefault();
        }

        public Blog GetFirstBlogByCategory(int categoryId)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs
                        .Where(c => c.CategoryId == categoryId)
                        .OrderBy(d => d.BlogId)
                        .Select(b => new Blog
                        {
                            Title = b.Title,
                            ImageUrl = b.ImageUrl,
                            Date = b.Date
                        })
                        .FirstOrDefault();
        }

        public List<Blog> GetBlogById(int id)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs.
                        Where(b => b.BlogId == id)
                        .Include(blog => blog.Author)
                        .Include(blog => blog.Category)
                        .ToList();
        }

        public override List<Blog> GetListAll()
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs
                .Include(blog => blog.Author)
                .Include(blog => blog.Category)
                .ToList();
        }
    }
}
