using System;
using System.Linq;
using DailyLog.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SD.LLBLGen.Pro.DQE.PostgreSql;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Npgsql;


namespace DailyLog
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
            conf.LlblGen(Configuration);
            services.Configure<RouteOptions>(opt =>
            {
                opt.LowercaseUrls = true;
                opt.LowercaseQueryStrings = true;
                opt.AppendTrailingSlash = true;
            });

            services.AddTransient<IUserService,UserService>();
            services.AddTransient<IProjectService,ProjectService>();
            services.AddTransient<ILogService,LogService>();
            services.AddStackExchangeRedisCache(options =>
            {
            });
            services.AddRazorPages(options => {
                options.Conventions.AuthorizeFolder("/Project");
                options.Conventions.AuthorizeFolder("/Log");
                options.Conventions.AuthorizePage("/Project");
                options.Conventions.AuthorizePage("/Log");
                options.Conventions.AllowAnonymousToPage("/Company");
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseCookiePolicy(new CookiePolicyOptions()
            {
                MinimumSameSitePolicy = SameSiteMode.Strict
            });
            
            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }

    public static class conf
    {
        public static void LlblGen(IConfiguration config)
        {
            NpgsqlConnection.GlobalTypeMapper.UseNetTopologySuite(geographyAsDefault: true);
            
            RuntimeConfiguration.AddConnectionString("ConnectionString.PostgreSql (Npgsql)", config["connectionStrings"]);
            
            RuntimeConfiguration.ConfigureDQE<PostgreSqlDQEConfiguration>(c =>
            {
                c.AddDbProviderFactory(typeof(NpgsqlFactory));
            });
            NpgsqlConnection.GlobalTypeMapper.UseNetTopologySuite();
        }
    }




}
