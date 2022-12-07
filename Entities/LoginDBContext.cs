using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace CovidWebAPI.Entities
{
    public class LoginDBContext : DbContext 
    {
        public LoginDBContext()
        {

        }
       public virtual DbSet<User>Users { get; set; }
       public virtual DbSet<CovidDetails> Covid { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DotNetFSD\\SQLEXPRESS;Initial Catalog=Assingnment;Persist Security Info=True;User ID=sa;Password=pass@123");
        }
    }
}
