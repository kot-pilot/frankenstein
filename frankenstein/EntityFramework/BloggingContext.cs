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

        public DbSet<Third> Third { get; set; }

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

    public class Third
    {
        public int Id { get; set; }
    }

}