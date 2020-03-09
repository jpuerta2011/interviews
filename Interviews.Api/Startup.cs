using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Interviews.Common;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Interviews.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Interviews.Common.Dependencies.UnitOfWork;
using Interviews.Data;
using Interviews.Data.Repositories;
using Interviews.Services.Domain.Security;
using Interviews.Services;
using Interviews.Api.Middlewares;
using Interviews.Services.Domain;

namespace Interviews.Api
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
            services.AddAutoMapper(typeof(Startup));

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateLifetime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });

            #region Dependency injection
            services.AddDbContext<InterviewDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // Register the UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            // Register the repostories
            RegisterRepositories(services);
            // Register the services
            RegisterServices(services);
            #endregion

            services.AddCors(options =>
            options.AddPolicy("CorsPolicy",
            builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()));
        }

        public void RegisterRepositories(IServiceCollection services)
        {
            #region Repositories
            services.AddScoped<IApplicantsRepository, ApplicantsRepository>();
            services.AddScoped<IInterviewsRepository, InterviewsRepository>();
            services.AddScoped<IInterviewTypesRepository, InterviewTypesRepository>();
            services.AddScoped<IRecruiterProcessesRepository, RecruiterProcessesRepository>();
            services.AddScoped<IRecruiterProcessTechnologiesRepository, RecruiterProcessTechnologiesRepository>();
            services.AddScoped<ITechnologiesRepository, TechnologiesRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            #endregion

            services.AddScoped<IRepositoryFactory, RepositoryFactory>();
        }

        public void RegisterServices(IServiceCollection services)
        {
            #region Domain services
            services.AddScoped<ISecurityService, SecurityService>();
            services.AddScoped<ITechnologiesService, TechnologiesService>();
            services.AddScoped<IRecruiterProcessesService, RecruiterProcessesService>();
            services.AddScoped<IInterviewsService, InterviewsService>();
            #endregion

            services.AddScoped<IServiceFactory, ServiceFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors("CorsPolicy");
            app.UseMiddleware<CustomExceptionMiddleware>();

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
