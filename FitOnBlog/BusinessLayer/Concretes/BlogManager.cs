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
    public class BlogManager(IBlogDal blogDal) : IBlogService
    {
        private readonly IBlogDal _blogDal = blogDal; // Primary Constructor

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public Blog GetFirstBlogByCategory(int id)
        {
            return _blogDal.GetFirstBlogByCategory(id);
        }

        public Blog GetLastBlogByCategory(int id)
        {
            return _blogDal.GetLastBlogByCategory(id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetBlogById(id);
        }

        public List<Blog> GetBlogsByAuthorId(int id)
        {
            return _blogDal.GetBlogsByAuthorId(id);
        }

        public List<Blog> GetListAll()
        {
            return _blogDal.GetListAll();
        }

        public void Insert(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }


    }
}
