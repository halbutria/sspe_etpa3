using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.Aplicacion;
using SispeServicios.Api.Parametrico.Persistencia;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;

namespace SispeServicios.Api.Parametrico
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

            services.AddControllers().AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<Lista>());


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            //services.AddSwaggerGen();
            services.AddSwaggerGen(options =>
            {
                options.CustomSchemaIds(type => type.ToString());
                options.CustomSchemaIds(s => s.FullName.Replace("+", "."));
            });


            services.AddMediatR(typeof(Lista.Manejador).Assembly);
            services.AddAutoMapper(typeof(Lista.Manejador).Assembly);
            services.AddFluentValidationAutoValidation();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("*");
                    });
            });
            services.AddDbContext<Contexto>(options => options.UseSqlServer(
                Configuration.GetValue<string>("CbcParametrico")
                //Configuration.GetConnectionString("CbcParametrico")
                ));
            services.AddDbContext<ContextoCiudadano>(options => options.UseSqlServer(
                Configuration.GetValue<string>("CbcCiudadano")
                //Configuration.GetConnectionString("CbcCiudadano")
            ));

            Console.Write(Configuration.GetValue<string>("CbcParametrico"));
            Console.Write(Configuration.GetValue<string>("CbcCiudadano"));
            System.Diagnostics.Debug.WriteLine(Configuration.GetValue<string>("CbcParametrico"));
            System.Diagnostics.Debug.WriteLine(Configuration.GetValue<string>("CbcCiudadano"));

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler(a => a.Run(async context =>
            {
                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                var exception = exceptionHandlerPathFeature.Error;

                await context.Response.WriteAsJsonAsync(new { error = exception.Message });
            }));

            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            var supportedCultures = new[] { new CultureInfo("es-CO") };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("es-CO"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseAuthorization();
            app.UseCors();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
