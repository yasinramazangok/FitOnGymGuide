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
        public Blog GetLastBlogByCategory(int id);

        public Blog GetFirstBlogByCategory(int id);

        public List<Blog> GetBlogById(int id);

        public List<Blog> GetBlogsByAuthorId(int id);

        public List<Blog> GetBlogsByCategoryId(int id);
    }
}
