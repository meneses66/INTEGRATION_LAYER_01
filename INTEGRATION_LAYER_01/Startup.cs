using INTEGRATION_LAYER_01.Model.Context;
using INTEGRATION_LAYER_01.Business;
using INTEGRATION_LAYER_01.Business.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using INTEGRATION_LAYER_01.Repository.Implementations;
using INTEGRATION_LAYER_01.Repository;
using INTEGRATION_LAYER_01.Repository.Generic;

namespace INTEGRATION_LAYER_01
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            var connection = Configuration["MySQLConnection:MySQLConnectionString"];
            
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

            //Versionamento de API
            services.AddApiVersioning();

            //INCLUS�O DE DEPEND�NCIAS:
            services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
            services.AddScoped<ISDevBusiness, SdevBusinessImplementation>();
            services.AddScoped<IRacaBusiness, RacaBusinessImplementation>();

            services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();
            services.AddScoped<ISDevRepository, SdevRepositoryImplementation>();
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "INTEGRATION_LAYER_01", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "INTEGRATION_LAYER_01 v1"));
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
