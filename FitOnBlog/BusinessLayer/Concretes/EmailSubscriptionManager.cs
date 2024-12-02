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
    public class EmailSubscriptionManager : IEmailSubscriptionService
    {
        private readonly IEmailSubscriptionDal _emailSubscriptionDal;

        public EmailSubscriptionManager(IEmailSubscriptionDal emailSubscriptionDal)
        {
            _emailSubscriptionDal = emailSubscriptionDal;
        }

        public void Delete(EmailSubscription entity)
        {
            throw new NotImplementedException();
        }

        public EmailSubscription GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmailSubscription> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(EmailSubscription entity)
        {
            if (entity?.Email?.Length < 11 || entity?.Email?.Length > 75)
            {
                throw new NotImplementedException();
            }

            _emailSubscriptionDal.Insert(entity);
        }

        public void Update(EmailSubscription entity)
        {
            throw new NotImplementedException();
        }
    }
}
