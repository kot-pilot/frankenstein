using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    

    public class BloggingContext : DbContext
    {

        public BloggingContext()
        {
        }
        public DbSet<First> First { get; set; }

        public DbSet<Second> Second { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost;Database=frankenstein;Trusted_Connection=True;");
    }

   

    public class First
    {
        public int Id { get; set; }
    }

    public class Second
    {
        public int Id { get; set; }
    }

}