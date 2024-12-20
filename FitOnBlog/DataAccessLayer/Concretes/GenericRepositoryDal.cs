using DataAccessLayer.Abstracts;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concretes
{
    public class GenericRepositoryDal<T> : IGenericDal<T> where T : class, new()
    {
        public virtual void Delete(T entity)
        {
            using var fitOnContext = new FitOnContext();
            fitOnContext.Remove(entity);
            fitOnContext.SaveChanges();
        }

        public virtual T GetById(int id)
        {
            using var fitOnContext = new FitOnContext();
            return fitOnContext.Set<T>().Find(id);
        }

        public virtual List<T> GetListAll()
        {
            using var fitOnContext = new FitOnContext();
            return fitOnContext.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using var fitOnContext = new FitOnContext();
            fitOnContext.Add(entity);
            fitOnContext.SaveChanges();
        }

        public void Update(T entity)
        {
            using var fitOnContext = new FitOnContext();
            fitOnContext.Update(entity);
            fitOnContext.SaveChanges();
        }
    }
}
