using Microsoft.EntityFrameworkCore;
using WebAppCoreWithView.Models;

namespace WebAppCoreWithView.ModelContext
{
   

    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions options) : base(options)
        {
        }
        //public ModelDbContext() : base("name=YarnDistribution")
        //{
        //}

        public DbSet<User>? Users { get; set; }
        //public DbSet<Account>? Accounts { get; set; }
    }
}
