using AutoServiceApp.Model.Entities;
using System.Data.Entity;

namespace AutoServiceApp.Model.EF
{
    class EfDbContext : DbContext
    {
        public EfDbContext() :base("DefaultConnection")
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sparepart> Spareparts { get; set; }
        public DbSet<TypeOfWork> TypeOfWorks { get; set; }
        public DbSet<OrderTypeOfWork> OrderTypeOfWorks { get; set; }
        public DbSet<OrderSparepart> OrderSpareparts { get; set; }
    }
}
