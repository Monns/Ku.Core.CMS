﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Vino.Core.Cache;
using Vino.Core.CMS.Data.Common;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;
using Vino.Core.CMS.Core.Helper;
using Vino.Core.CMS.Web.AutoMapper;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;

namespace Vino.Core.CMS.Web.Application
{
    public class VinoAppStartup
    {
        protected IConfigurationRoot Configuration;
        protected MapperConfiguration _mapperConfiguration { get; set; }

        public VinoAppStartup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            env.ConfigureNLog("nlog.config");

            Configuration = builder.Build();

            //ID生成器初始化
            ID.Initialize(Configuration);
            //缓存初始化
            CacheConfig.Initialize(Configuration);
            //日志初始化
            //VinoLogger.Initialize(env);
        }

        public virtual IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //AutoMapper
            services.AddAutoMapper();

            string connection = Configuration.GetConnectionString("MysqlDatabase");
            services.AddDbContext<VinoDbContext>(options => options.UseMySql(connection, b => b.MigrationsAssembly("Vino.Core.CMS.Web.Admin")));

            //注册非主线DbContext
            var dbOptions = new DbContextOptionsBuilder<SecondaryVinoDbContext>()
                .UseMySql(connection)
                .Options;
            SecondaryVinoDbContext.Options = dbOptions;

            //加入身份认证
            services.AddAuthorization();
            //添加options
            //services.AddOptions();
            //services.Configure<RedisConfig>(Configuration.GetSection("RedisConfig"));

            //使用redis存储session
            services.AddSingleton<IDistributedCache>(
                serviceProvider =>
                    new RedisCache(new RedisCacheOptions
                    {
                        Configuration = CacheConfig.RedisConfig.ConnectionString,
                        InstanceName = CacheConfig.RedisConfig.ApplicationKey
                    }));
            services.AddSession();

            //Autofac依赖注入
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterModule(new AppModule());
            var container = builder.Build();
            return new AutofacServiceProvider(container);
        }

        public virtual void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //Nlog
            loggerFactory.AddNLog();
            app.AddNLogWeb();
        }
    }
}
