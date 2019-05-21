using AutoMapper;
using Contracts;
using Entities;
using KB.Filter;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KB.ServiceConfig
{
    public static class ServiceExtensions
    {
        /// <summary>
        ///  Cross-Origin Resource Sharing Configure
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials());
            });
        }

        /// <summary>
        /// IIS mode config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureIISIntergration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>{});
        }

        /// <summary>
        /// connectstr config
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["sqlconnection:connectionstring"];

            //if you want to register multiple context type here , you should use generic context parameter in your ctor.
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(connectionString));
            services.AddDbContext<KBContext>(options => options.UseSqlServer(connectionString));
        }

        /// <summary>
        ///  logger config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        /// <summary>
        /// repo config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        /// <summary>
        /// action filter config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureActionFilter(this IServiceCollection services)
        {
            services.AddScoped<ActionFilter>();
        }

        /// <summary>
        /// authorization filter config
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureAuthorizationFilter(this IServiceCollection services)
        {
            services.AddScoped<AuthorizationFilter>();
        }

        public static void ConfigureServicesContainer(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfileConfig());
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);

        }

    }
}
