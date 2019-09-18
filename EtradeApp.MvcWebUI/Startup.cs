using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EtradeApp.Business;
using EtradeApp.Business.Abstract;
using EtradeApp.Business.Concrete;
using EtradeApp.DataAccess.Abstract;
using EtradeApp.DataAccess.Concrete.EntitiyFramework;
using EtradeApp.Entities.Concrete;
using EtradeApp.MvcWebUI.Entities;
using EtradeApp.MvcWebUI.Models;
using EtradeApp.MvcWebUI.Services;
using EtradeApp.MvcWebUI.Validation;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EtradeApp.MvcWebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

       
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CustomIdentityContext>(m => m.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>().AddEntityFrameworkStores<CustomIdentityContext>().AddDefaultTokenProviders();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<IPhotoDal, EfPhotoDal>();
            services.AddScoped<IPhotoService, PhotoManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<ICartDal, EFCartDal>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDal, EfOrderDal>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddSession();
            services.AddAutoMapper();
            services.AddDistributedMemoryCache();
            services.AddMvc().AddFluentValidation();
            services.AddTransient<IValidator<Product>, ProductValidator>();
            services.AddTransient<IValidator<Category>, CategoryValidator>();
            services.AddTransient<IValidator<ShippingDetail>, ShippingDetailsValidator>();
            services.AddTransient<IValidator<RegisterViewModel>, RegisterUserValidator>();
            services.AddTransient<IValidator<LoginViewModel>, LoginUserValidator>();

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/Account/LoginUser";
                options.Cookie.Name = "Cookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(720);
                options.LoginPath = "/Account/LoginUser";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {

                //app.UseDeveloperExceptionPage();
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
            }
            else
            {
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
            }

            app.UseStaticFiles();
            app.UseSession();
            app.UseIdentity();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "siparisdetay",
                     template: "siparisdetay/{orderId}",
                  defaults: new { controller = "Account", action = "MyOrderDetail" });

                routes.MapRoute(
                   name: "siparislerim",
                   template: "siparislerim",
                   defaults: new { controller = "Account", action = "MyOrders" });

                routes.MapRoute(
                  name: "faturaadresim",
                  template: "faturaadresim",
                  defaults: new { controller = "Account", action = "ShippingAdress" });

                routes.MapRoute(
                  name: "hesapayarlari",
                  template: "hesapayarlari",
                  defaults: new { controller = "Account", action = "AccountSettings" });


                routes.MapRoute(
                    name: "urunler",
                    template: "urunler/{categoryId?}",
                    defaults: new { controller = "Home", action = "Products" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
