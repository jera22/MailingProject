using Data;
using Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new MailMap(modelBuilder.Entity<Mail>());
            
        }
    }
}
