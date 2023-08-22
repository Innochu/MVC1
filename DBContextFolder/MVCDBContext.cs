using Microsoft.EntityFrameworkCore;
using MVC1.Models.Domain;

namespace MVC1.DBContextFolder
{
    public class MVCDBContext : DbContext
    {
        public MVCDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
