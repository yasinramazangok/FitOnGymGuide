﻿using BusinessLayer.Abstracts;
using BusinessLayer.Concretes;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstracts;
using DataAccessLayer.EntityFrameworkCore;
using EntityLayer.Concretes;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogDal>();

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EfAboutDal>();

            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IAddressDal, EfAddressDal>();

            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<IAuthorDal, EfAuthorDal>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogDal>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactDal>();

            services.AddScoped<IEmailSubscriptionService, EmailSubscriptionManager>();
            services.AddScoped<IEmailSubscriptionDal, EfEmailSubscriptionDal>();

            services.AddScoped<IChartService, ChartManager>();

            services.AddScoped<IValidator<Blog>, BlogValidator>();
            services.AddScoped<IValidator<Category>, CategoryValidator>();
            services.AddScoped<IValidator<About>, AboutValidator>();
            services.AddScoped<IValidator<Author>, AuthorValidator>();
            services.AddScoped<IValidator<EmailSubscription>, EmailSubscriptionValidator>();
        }
    }
}
