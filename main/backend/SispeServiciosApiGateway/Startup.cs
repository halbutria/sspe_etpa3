using Microsoft.AspNetCore.Diagnostics;
using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using SispeServicios.Api.Gateway.MessageHandler;
using SispeServicios.Api.Gateway.RemoteInterface;
using SispeServicios.Api.Gateway.RemoteService;
using System.IdentityModel.Tokens.Jwt;

namespace SispeServicios.Api.Gateway
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
            services.AddOcelot()
                .AddCacheManager(x =>
                    {
                        x.WithDictionaryHandle();
                    })
                .AddDelegatingHandler<CiudadanoHandler>()
                .AddDelegatingHandler<CargoInteresHandler>()
                .AddDelegatingHandler<TipoNotificacionHandler>()
                .AddDelegatingHandler<InformacionLaboralHandler>()
                .AddDelegatingHandler<VacanteHandler>();
                //.AddDelegatingHandler<NoEncodingHandler>(true);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.CustomSchemaIds(type => type.ToString());
            });
            services.AddSwaggerForOcelot(Configuration);
            services.AddHttpClient("Parametrico", config => {
                config.BaseAddress = new Uri(Configuration["Services:Parametrico"]);
            });

            services.AddHttpClient("Empresa", config => {
                config.BaseAddress = new Uri(Configuration["Services:Empresa"]);
            });

            services.AddSingleton<IParametricoService, ParametricoService>();
            services.AddSingleton<IEmpresaService, EmpresaService>();

            //para configurar
            //https://arbems.com/api-gateway-en-net-6-con-ocelot/
            //services
            //.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //.AddJwtBearer(options =>
            //{
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidateLifetime = true,
            //        ValidateIssuerSigningKey = true,

            //        ValidIssuer = Configuration["JwtSettings:Issuer"],
            //        ValidAudience = Configuration["JwtSettings:Audience"],
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSettings:Key"]))
            //    };
            //});

        }

        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
                app.UseSwaggerForOcelotUI(opt =>
                {
                    
                    opt.PathToSwaggerGenerator = "/swagger/docs";

                });
            }
            
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            await app.UseOcelot();

            app.UseHttpsRedirection();

        }
    }
}