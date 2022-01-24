using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RequestManagement.Core.ApplicationServices.WeatherForecasts;
using RequestManagement.Core.Domain.WeatherForecasts.Services;
using RequestManagement.Infra.Data.SqlServer;

namespace RequestManagement.EndPoints.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<RequestManagementDbContext>(c => c.UseSqlServer(Configuration.GetConnectionString("")));
            services.AddControllers();
            services.AddScoped<IRandomForecastsGenerator, RandomForecastsGenerator>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
