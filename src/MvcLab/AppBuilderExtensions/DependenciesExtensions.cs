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

            return services;
        }
    }
}
