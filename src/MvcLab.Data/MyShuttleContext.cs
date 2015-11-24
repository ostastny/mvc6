
namespace MyShuttle.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.Data.Entity;
    using Microsoft.Data.Entity.Metadata;
    using MyShuttle.Model;
    using System;

    public class MyShuttleContext : IdentityDbContext<ApplicationUser>
    {
        public MyShuttleContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
              .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
              .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
            {
                b.Property<string>("Id");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken();

                b.Property<string>("Name")
                    .HasAnnotation("MaxLength", 256);

                b.Property<string>("NormalizedName")
                    .HasAnnotation("MaxLength", 256);

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .HasAnnotation("Relational:Name", "RoleNameIndex");

                b.HasAnnotation("Relational:TableName", "AspNetRoles");
            });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("ClaimType");

                b.Property<string>("ClaimValue");

                b.Property<string>("RoleId")
                    .IsRequired();

                b.HasKey("Id");

                b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
            });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("ClaimType");

                b.Property<string>("ClaimValue");

                b.Property<string>("UserId")
                    .IsRequired();

                b.HasKey("Id");

                b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
            });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("LoginProvider");

                b.Property<string>("ProviderKey");

                b.Property<string>("ProviderDisplayName");

                b.Property<string>("UserId")
                    .IsRequired();

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
            });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId");

                b.Property<string>("RoleId");

                b.HasKey("UserId", "RoleId");

                b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
            });

            modelBuilder.Entity("MyShuttle.Model.ApplicationUser", b =>
            {
                b.Property<string>("Id");

                b.Property<int>("AccessFailedCount");

                b.Property<int>("CarrierId");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken();

                b.Property<string>("Email")
                    .HasAnnotation("MaxLength", 256);

                b.Property<bool>("EmailConfirmed");

                b.Property<bool>("LockoutEnabled");

                b.Property<DateTimeOffset?>("LockoutEnd");

                b.Property<string>("NormalizedEmail")
                    .HasAnnotation("MaxLength", 256);

                b.Property<string>("NormalizedUserName")
                    .HasAnnotation("MaxLength", 256);

                b.Property<string>("PasswordHash");

                b.Property<string>("PhoneNumber");

                b.Property<bool>("PhoneNumberConfirmed");

                b.Property<string>("SecurityStamp");

                b.Property<bool>("TwoFactorEnabled");

                b.Property<string>("UserName")
                    .HasAnnotation("MaxLength", 256);

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasAnnotation("Relational:Name", "EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .HasAnnotation("Relational:Name", "UserNameIndex");

                b.HasAnnotation("Relational:TableName", "AspNetUsers");
            });

            modelBuilder.Entity("MyShuttle.Model.Carrier", b =>
            {
                b.Property<int>("CarrierId")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Address");

                b.Property<string>("City");

                b.Property<string>("CompanyID");

                b.Property<string>("Country");

                b.Property<string>("Description");

                b.Property<string>("Email");

                b.Property<string>("Name");

                b.Property<string>("Phone");

                b.Property<byte[]>("Picture");

                b.Property<double>("RatingAvg");

                b.Property<string>("State");

                b.Property<string>("ZipCode");

                b.HasKey("CarrierId");
            });

            modelBuilder.Entity("MyShuttle.Model.Customer", b =>
            {
                b.Property<int>("CustomerId")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Address");

                b.Property<string>("City");

                b.Property<string>("CompanyID");

                b.Property<string>("Country");

                b.Property<string>("Email");

                b.Property<string>("Name");

                b.Property<string>("Phone");

                b.Property<string>("State");

                b.Property<string>("ZipCode");

                b.HasKey("CustomerId");
            });

            modelBuilder.Entity("MyShuttle.Model.Driver", b =>
            {
                b.Property<int>("DriverId")
                    .ValueGeneratedOnAdd();

                b.Property<int>("CarrierId");

                b.Property<string>("Name");

                b.Property<string>("Phone");

                b.Property<byte[]>("Picture");

                b.Property<double>("RatingAvg");

                b.Property<int>("TotalRides");

                b.Property<int?>("VehicleId");

                b.HasKey("DriverId");
            });

            modelBuilder.Entity("MyShuttle.Model.Employee", b =>
            {
                b.Property<int>("EmployeeId")
                    .ValueGeneratedOnAdd();

                b.Property<DateTimeOffset?>("CreatedAt");

                b.Property<int>("CustomerId");

                b.Property<bool>("Deleted");

                b.Property<string>("Email");

                b.Property<string>("Id");

                b.Property<string>("Name");

                b.Property<byte[]>("Picture");

                b.Property<DateTimeOffset?>("UpdatedAt");

                b.Property<byte[]>("Version");

                b.HasKey("EmployeeId");
            });

            modelBuilder.Entity("MyShuttle.Model.Ride", b =>
            {
                b.Property<int>("RideId")
                    .ValueGeneratedOnAdd();

                b.Property<int>("CarrierId");

                b.Property<string>("Comments");

                b.Property<double>("Cost");

                b.Property<DateTimeOffset?>("CreatedAt");

                b.Property<bool>("Deleted");

                b.Property<double>("Distance");

                b.Property<int?>("DriverId");

                b.Property<int>("Duration");

                b.Property<int>("EmployeeId");

                b.Property<string>("EndAddress");

                b.Property<DateTime>("EndDateTime");

                b.Property<double>("EndLatitude");

                b.Property<double>("EndLongitude");

                b.Property<string>("Id");

                b.Property<double>("Rating");

                b.Property<byte[]>("Signature");

                b.Property<string>("StartAddress");

                b.Property<DateTime>("StartDateTime");

                b.Property<double>("StartLatitude");

                b.Property<double>("StartLongitude");

                b.Property<DateTimeOffset?>("UpdatedAt");

                b.Property<int>("VehicleId");

                b.Property<byte[]>("Version");

                b.HasKey("RideId");
            });

            modelBuilder.Entity("MyShuttle.Model.Vehicle", b =>
            {
                b.Property<int>("VehicleId")
                    .ValueGeneratedOnAdd();

                b.Property<int>("CarrierId");

                b.Property<string>("DeviceId");

                b.Property<double>("DistanceFromGivenPosition");

                b.Property<int>("DriverId");

                b.Property<double>("Latitude");

                b.Property<string>("LicensePlate");

                b.Property<double>("Longitude");

                b.Property<string>("Make");

                b.Property<string>("Model");

                b.Property<byte[]>("Picture");

                b.Property<double>("Rate");

                b.Property<double>("RatingAvg");

                b.Property<int>("Seats");

                b.Property<int>("TotalRides");

                b.Property<int>("Type");

                b.Property<int>("VehicleStatus");

                b.HasKey("VehicleId");
            });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
            {
                b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                    .WithMany()
                    .HasForeignKey("RoleId");
            });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
            {
                b.HasOne("MyShuttle.Model.ApplicationUser")
                    .WithMany()
                    .HasForeignKey("UserId");
            });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
            {
                b.HasOne("MyShuttle.Model.ApplicationUser")
                    .WithMany()
                    .HasForeignKey("UserId");
            });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
            {
                b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                    .WithMany()
                    .HasForeignKey("RoleId");

                b.HasOne("MyShuttle.Model.ApplicationUser")
                    .WithMany()
                    .HasForeignKey("UserId");
            });

            modelBuilder.Entity("MyShuttle.Model.Driver", b =>
            {
                b.HasOne("MyShuttle.Model.Carrier")
                    .WithMany()
                    .HasForeignKey("CarrierId");

                b.HasOne("MyShuttle.Model.Vehicle")
                    .WithOne()
                    .HasForeignKey("MyShuttle.Model.Driver", "VehicleId");
            });

            modelBuilder.Entity("MyShuttle.Model.Employee", b =>
            {
                b.HasOne("MyShuttle.Model.Customer")
                    .WithMany()
                    .HasForeignKey("CustomerId");
            });

            modelBuilder.Entity("MyShuttle.Model.Ride", b =>
            {
                b.HasOne("MyShuttle.Model.Carrier")
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey("CarrierId");

                b.HasOne("MyShuttle.Model.Driver")
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey("DriverId");

                b.HasOne("MyShuttle.Model.Employee")
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey("EmployeeId");

                b.HasOne("MyShuttle.Model.Vehicle")
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey("VehicleId");
            });

            modelBuilder.Entity("MyShuttle.Model.Vehicle", b =>
            {
                b.HasOne("MyShuttle.Model.Carrier")
                    .WithMany()
                    .HasForeignKey("CarrierId");

                b.HasOne("MyShuttle.Model.Driver")
                   .WithMany()
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasForeignKey("DriverId");
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Ride> Rides { get; set; }
    }
}


