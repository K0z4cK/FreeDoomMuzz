using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deezer.Data.Entities;
using Deezer.Data.Interfaces;
using Deezer.Data.Repositories;
using Deezer.Data.Seed;
using Deezer.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Deezer
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<EFContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<DbUser, DbRole>(options => options
                .Stores.MaxLengthForKeys = 128)
                .AddEntityFrameworkStores<EFContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<ITreck, TreckRepository>();
            services.AddTransient<IPlaylist, PlaylistRepository>();
            services.AddTransient<IPlaylistTreck, PlaylistTreckRepositor>();
            services.AddTransient<IAlbums, AlbumRepository>();
            services.AddTransient<IArtist, ArtistRepository>();
            services.AddTransient<IGenres, GenreRepository>();
            services.AddTransient<IFile, FileRepository>();
            services.AddTransient<IUser, UserRepository>();
            //services.AddTransient<IEmailSender, EmailService>();


            services.AddMemoryCache();
            services.AddSession();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                    options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
                app.UseExceptionHandler("/Home/Error");
            }
            SeederDb.SeedData(app.ApplicationServices, env, this.Configuration);
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "gentefilter",
                    template: "Treks/{action}/{genre?}",
                    defaults: new { action = "ListTreks" });
            });
        }
    }
}
