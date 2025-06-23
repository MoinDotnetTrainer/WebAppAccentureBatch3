using Microsoft.EntityFrameworkCore;

namespace WebAppCoreRazorPages.Models
{
    public class AppDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial catalog=db_Employees;Integrated Security=true;TrustServerCertificate=true");
        }

        public DbSet<UserValues> uservalues { get; set; }

        public DbSet<Orders> orders { get; set; }

        public DbSet<Products> products { get; set; }

        public DbSet<UsersData> usersData { get; set; }

        public DbSet<Book> books { get; set; }

        public DbSet<Anno> annos { get; set; }  

        public DbSet<AllAnnotationExample> allAnnotationExamples { get; set; }  
    }
}
