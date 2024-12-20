using EntityLayer.Concretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class FitOnContext : IdentityDbContext<FitOnBlogUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = YASINRAMAZANGOK; database = FitOnBlogDatabase; user id = fitonbloguser; password = Yasinramazan.123!; integrated security = false; trustservercertificate = true;");
        }
      
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EmailSubscription> EmailSubscriptions { get; set; }
    }
}
