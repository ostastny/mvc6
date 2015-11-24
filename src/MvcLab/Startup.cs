using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using MyShuttle.Web.AppBuilderExtensions;
using MyShuttle.Data;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.Extensions.DependencyInjection;

namespace MyShuttle.Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            var builder = new ConfigurationBuilder()    //appEnv.ApplicationBasePath
                .AddJsonFile("config.json")
                .AddJsonFile($"config.{env.EnvironmentName}.json", optional: true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public IConfiguration Configuration { get; private set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDataContext(Configuration);
            services.ConfigureDependencies();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.ConfigureRoutes();
            MyShuttleDataInitializer.InitializeDatabaseAsync(app.ApplicationServices).Wait();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }

}
