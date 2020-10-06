using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace travelTrip.Models
{
    public class TravelContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AddressBlog> AddressBlogs { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<AboutPage> AboutPages { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}