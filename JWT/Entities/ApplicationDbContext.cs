using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace JWT.Entities
{
    public class ApplicationDBContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"server=localhost;Database=JWTApp;Trusted_Connection=True";            
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}