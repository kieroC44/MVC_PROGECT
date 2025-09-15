
using System.Reflection;

namespace Demo.DataAccess.Data.Contexts
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("ConnectionString");
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
            //modelBuilder. ApplyConfiguration<Department>(new DepartmentConifgurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext). Assembly);
         }
        public DbSet<Department> Departments { get; set; }
    }
}
