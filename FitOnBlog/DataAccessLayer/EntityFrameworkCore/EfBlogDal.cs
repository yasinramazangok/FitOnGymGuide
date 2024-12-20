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

            return fitOnContext.Blogs
                .OrderByDescending(d => d.Date)
                .Include(blog => blog.Author)
                .Include(blog => blog.Category)
                .ToList();
        }

        public override Blog GetById(int id)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs
                .Include(blog => blog.Author)
                .Include(blog => blog.Category)
                .FirstOrDefault(blog => blog.BlogId == id);
        }

        public Blog GetLastBlogByCategory(int id)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs
                        .Where(c => c.CategoryId == id)
                        .OrderByDescending(d => d.BlogId)
                        .Select(b => new Blog
                        {
                            BlogId = b.BlogId,
                            Title = b.Title,
                            ImageUrl = b.ImageUrl,
                            Date = b.Date
                        })
                        .FirstOrDefault();
        }

        public Blog GetFirstBlogByCategory(int id)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs
                        .Where(c => c.CategoryId == id)
                        .OrderBy(d => d.BlogId)
                        .Select(b => new Blog
                        {
                            BlogId = b.BlogId,
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
                        .Include(b => b.Author)
                        .Include(b => b.Category)
                        .ToList();
        }

        public List<Blog> GetBlogsByAuthorId(int id)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs.
                                    Where(b => b.AuthorId == id)
                                    .Include(b => b.Author)
                                    .Include(b => b.Category)
                                    .ToList();
        }

        public IEnumerable<Blog> GetBlogsByAuthorId(string userId)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs.
                                    Where(b => b.Author.UserId == userId)
                                    .Include(b => b.Author)
                                    .Include(b => b.Category)
                                    .ToList();
        }

        public List<Blog> GetBlogsByCategoryId(int id)
        {
            using var fitOnContext = new FitOnContext();

            return fitOnContext.Blogs.
                                    Where(b => b.CategoryId == id)
                                    .Include(b => b.Author)
                                    .Include(b => b.Category)
                                    .ToList();
        }

        
    }
}
