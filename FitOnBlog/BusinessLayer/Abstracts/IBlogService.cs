using DataAccessLayer.Contexts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IBlogService : IGenericService<Blog>
    {
        // for Default Featured Blogs Partial
        public Blog GetLastBlogByCategory(int id);

        // for Default Other Featured Blogs Partial
        public Blog GetFirstBlogByCategory(int id);

        // for Blog details
        public List<Blog> GetBlogById(int id);

        // for Author popular blogs in Blog details
        public List<Blog> GetBlogsByAuthorId(int id);

        // for Blog list in Admin and Author panel
        public IEnumerable<Blog> GetBlogsByAuthorId(string userId);

        // for Blogs by category id in Category page
        public List<Blog> GetBlogsByCategoryId(int id);
    }
}
