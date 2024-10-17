using DataAccessLayer.Abstracts;
using DataAccessLayer.Concretes;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameworkCore
{
    public class EfContactDal : GenericRepositoryDal<Contact>, IContactDal
    {
    }
}
