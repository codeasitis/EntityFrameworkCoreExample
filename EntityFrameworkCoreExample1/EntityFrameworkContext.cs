using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreExample1
{
    public class EntityFrameworkContext :DbContext
    {
        public EntityFrameworkContext():base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DatabaseConnection.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(t => t.EmpId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employee { get; set; }


    }
}
