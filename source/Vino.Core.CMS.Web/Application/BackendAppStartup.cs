﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Vino.Core.CMS.Data.Common;
using Vino.Core.CMS.Web.Middleware;

namespace Vino.Core.CMS.Web.Application
{
    public class BackendAppStartup: VinoAppStartup
    {
        public BackendAppStartup(IHostingEnvironment env) : base(env)
        {

        }

        public override IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //定时任务
            services.AddTimedTask().AddEntityFrameworkTimedTask<VinoDbContext>();

            return base.ConfigureServices(services);
        }

        public override void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            base.Configure(app, env, loggerFactory);

            //定时任务
            app.UseTimedTask();

            app.UsePageErrorHandling();

            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseSession(new SessionOptions() { IdleTimeout = TimeSpan.FromMinutes(30) });

            //身份认证
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationScheme = "Cookie",
                LoginPath = new PathString("/Account/Login"),
                AccessDeniedPath = new PathString("/Account/Forbidden"),
                AutomaticAuthenticate = true,
                AutomaticChallenge = true
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areaRoute",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}