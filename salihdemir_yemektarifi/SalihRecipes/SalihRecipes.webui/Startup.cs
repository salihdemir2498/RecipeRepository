using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using SalihRecipes.business.Abstract;
using SalihRecipes.business.Concrete;
using SalihRecipes.data.Abstract;
using SalihRecipes.data.Concrete.EfCore;
using SalihRecipes.webui.EmailServices;
using SalihRecipes.webui.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui
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
            services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=FoodRecipe"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                //Password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;

                //Lockout
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                options.Lockout.AllowedForNewUsers = true;

                //User
                options.User.RequireUniqueEmail = true;

                //SignIn
                options.SignIn.RequireConfirmedEmail = true;

            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.SlidingExpiration = true; //20 dakika içerisinde her iþlemde yeni bir 20 dk verir.
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,
                    Name = "SalihRecipes.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });

            services.AddScoped<IEmailSender, SmtpEmailSender>(i => new SmtpEmailSender(
                Configuration["EmailSender:Host"],
                Configuration.GetValue<int>("EmailSender:Port"),
                Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                Configuration["EmailSender:UserName"],
                Configuration["EmailSender:Password"]
                ));

            services.AddScoped<IFoodRepository, EfCoreFoodRepository>(); 
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();

            services.AddScoped<IFoodService, FoodManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddControllersWithViews();
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                RequestPath = "/modules"     //bootstrap için
            });
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "adminrolelist",
                   pattern: "admin/role/list",
                   defaults: new { controller = "Admin", action = "RoleList" }
                   );

                endpoints.MapControllerRoute(
                   name: "adminroleedit",
                   pattern: "admin/role/{id}",
                   defaults: new { controller = "Admin", action = "RoleEdit" }
                   );

                endpoints.MapControllerRoute(
                    name: "adminrolecreate",
                    pattern: "admin/role/create",
                    defaults: new { controller = "Admin", action = "RoleCreate" }
                    );

                endpoints.MapControllerRoute(
                   name: "adminfoods",
                   pattern: "admin/foods",
                   defaults: new { controller = "Admin", action = "FoodList" }
                   );

                endpoints.MapControllerRoute(
                   name: "adminfoodcreate",
                   pattern: "admin/foods/create",
                   defaults: new { controller = "Admin", action = "FoodCreate" }
                   );

                endpoints.MapControllerRoute(
                   name: "adminfoodedit",
                   pattern: "admin/foods/{id?}",
                   defaults: new { controller = "Admin", action = "FoodEdit" }
                   );

                endpoints.MapControllerRoute(
                   name: "admincategories",
                   pattern: "admin/categories",
                   defaults: new { controller = "Admin", action = "CategoryList" }
                   );

                endpoints.MapControllerRoute(
                     name: "admincategorycreate",
                     pattern: "admin/categories/create",
                     defaults: new { controller = "Admin", action = "CategoryCreate" }
                     );

                endpoints.MapControllerRoute(
                   name: "admincategoryedit",
                   pattern: "admin/categories/{id?}",
                   defaults: new { controller = "Admin", action = "CategoryEdit" }
                   );

                endpoints.MapControllerRoute(
                    name: "categoyfood",
                    pattern: "category/index/{id?}",
                    defaults: new { controller = "Category", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    name: "foods",
                    pattern: "foods/{category?}",  //category eklemezsek direk products açýlýr category optional
                    defaults: new { controller = "Food", action = "foodlist" }
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
