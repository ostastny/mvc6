
namespace MyShuttle.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.Data.Entity;
    using MyShuttle.Model;


    public class MyShuttleContext : IdentityDbContext<ApplicationUser>
    {
        public MyShuttleContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasKey(c => c.CustomerId);
            builder.Entity<Carrier>().HasKey(c => c.CarrierId);
            builder.Entity<Employee>().HasKey(e => e.EmployeeId);
            builder.Entity<Vehicle>().HasKey(v => v.VehicleId);
            builder.Entity<Driver>().HasKey(d => d.DriverId);
            builder.Entity<Ride>().HasKey(r => r.RideId);

            base.OnModelCreating(builder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Ride> Rides { get; set; }
    }
}


