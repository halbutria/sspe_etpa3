using Azure.Storage.Blobs;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteService;
using SispeServiciosApiCiudadano.Aplicacion.Utils;
using SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta;
using SispeServiciosApiCiudadano.RemoteInterface;
using SispeServiciosApiCiudadano.RemoteService;
using SispeServiciosEventos;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using Xphera.Library.Common.Entities;

namespace SispeServicios.Api.Ciudadano
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddFluentValidation(cfg =>
                {
                    cfg.RegisterValidatorsFromAssemblyContaining<Nuevo>();

                });

            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IParametricoService, ParametricoService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ConvertirCiudadanoAPersona>();
            services.AddCommonEntitiesServices(null);
            string ConnectionStringAzureBlod = Configuration.GetSection("AzureBlobStorage:ConnectionString").Value;
            services.AddSingleton(x => new BlobServiceClient(ConnectionStringAzureBlod));
            services.AddXpSispeCiudadanoEventsServices(QueueOptions => Configuration.Bind("QueueOptions", QueueOptions));
            services.AddSingleton<IAzureBlobService, AzureBlobService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.CustomSchemaIds(type => type.ToString());
                options.CustomSchemaIds(s => s.FullName.Replace("+", "."));
            });

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddHttpClient("Usuarios", config =>
            {
                config.BaseAddress = new Uri(Configuration.GetValue<string>("serviceUsuarios"));
            });
            services.AddHttpClient("Parametricos", config =>
            {
                config.BaseAddress = new Uri(Configuration.GetValue<string>("Parametricos"));
            });
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("*").AllowAnyHeader()
                                                  .AllowAnyMethod();
                    });
            });
            services.AddDbContext<Contexto>(options => options.UseSqlServer(
                //Configuration.GetConnectionString("CbcCiudadano")
                Configuration.GetValue<string>("CbcCiudadano")
                //options => options.EnableRetryOnFailure()
                ));
            services.AddDbContext<ContextoParametrico>(options => options.UseSqlServer(
                //Configuration.GetConnectionString("CbcParametricos")
                Configuration.GetValue<string>("CbcParametricos")
                //options => options.EnableRetryOnFailure()
                ));




        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler(a => a.Run(async context =>
            {
                var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                var exception = exceptionHandlerPathFeature.Error;

                await context.Response.WriteAsJsonAsync(new { error = exception.Message, type = "https://tools.ietf.org/html/rfc7231#section-6.5.1" });
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