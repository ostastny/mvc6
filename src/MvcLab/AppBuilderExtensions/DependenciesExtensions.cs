namespace MyShuttle.Web.AppBuilderExtensions
{
    using Data;
    using Microsoft.Extensions.DependencyInjection;
    using Data.Repositories.MyShuttle.Data;

    public static class DependenciesExtensions
    {
        public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICarrierRepository, CarrierRepository>();

            services.AddScoped<IDriverRepository, DriverRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IRidesRepository, RidesRepository>();


            return services;
        }
    }
}
