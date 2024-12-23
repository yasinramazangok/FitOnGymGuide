﻿using DataAccessLayer.Contexts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IAuthorDal : IGenericDal<Author>
    {
        public IEnumerable<Author> GetAuthenticatedAuthor(string userId);

        // for Meet The Team in About
        public List<Author> GetRandomAuthor();
       
    }
}
