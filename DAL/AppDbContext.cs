using DAL.Entities;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=WIN-10\SQLEXPRESS;Initial Catalog=LabEFCodeFirst32;Integrated Security=True; Encrypt=False;");
            }
        }
    }


}
