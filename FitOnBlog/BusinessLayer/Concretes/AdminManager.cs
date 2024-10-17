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
    public class AdminManager(IAdminDal adminDal) : IAdminService
    {
        private readonly IAdminDal _adminDal = adminDal; // Primary Constructor

        public void Delete(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Admin GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Admin entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
