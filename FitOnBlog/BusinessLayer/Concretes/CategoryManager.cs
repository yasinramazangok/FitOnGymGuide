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
    public class CategoryManager : ICategoryService
    {
        // See the comments where a method is defined to learn what it does 

        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void DecrementBlogCount(int categoryId)
        {
            _categoryDal.DecrementBlogCount(categoryId);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public void IncrementBlogCount(int categoryId)
        {
            _categoryDal.IncrementBlogCount(categoryId);
        }

        public void Insert(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
