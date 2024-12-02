using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        public Blog GetLastBlogByCategory(int id);

        public Blog GetFirstBlogByCategory(int id);

        public List<Blog> GetBlogById(int id);

        public List<Blog> GetBlogsByAuthorId(int id);      
    }
}
