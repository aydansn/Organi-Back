using Microsoft.EntityFrameworkCore;
using Ogani.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogani.Domain.Models.DataContext
{
    public class OganiDbContext : DbContext
    {
        public OganiDbContext(DbContextOptions option)
             : base(option)
        {
           
        }

        public DbSet <Category> Categories  { get; set; }

        public DbSet<BlogPost> BlogPosts { get; set; }


    }
}
