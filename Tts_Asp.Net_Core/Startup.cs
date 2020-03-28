using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tts_Asp.Net_Core.Models.InterFace;
using Tts_Asp.Net_Core.Models.Repository;

namespace Tts_Asp.Net_Core
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

            services.AddDistributedMemoryCache();           // Đăng ký dịch vụ lưu cache trong bộ nhớ (Session sẽ sử dụng nó)
            services.AddSession(options =>
            {                                               // Đăng ký dịch vụ Session
                options.IdleTimeout = new TimeSpan(3600);   // Thời gian tồn tại của Session
            });
            services.AddMvc(MvcOptions =>
            {
                MvcOptions.EnableEndpointRouting = false;

            });
            services.AddControllersWithViews();
            services.AddTransient<ILogin, RLogin>();
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
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();
            app.UseMvc(routes =>
            {
                // Tối Ưu Hóa đường dẫn Cho SEO
                var rewrite = new RewriteOptions()
               .AddRewrite(@"Dang-Nhap-Vao-He-Thong", "Login/Index", skipRemainingRules: false)
               .AddRewrite(@"admin", " admin/Home/Index", skipRemainingRules: false)
               .AddRewrite(@"DangKy", "Login/AddAccount", skipRemainingRules: false);
                app.UseRewriter(rewrite);
                //Kết Thúc Tối Ưu Hóa Đường Dẫn cho SEO
                routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                   name: "Admin",
                   template: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");
                
            });            
        }
    }
}
