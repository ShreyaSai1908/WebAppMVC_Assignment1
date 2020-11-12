using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebAppMVC_Assignment1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); //this is mandatory to add here for MVC projects 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();   //this used so that webserver can recognize index.html file by its default name
            app.UseStaticFiles();   //this is used so that webserver can recognize static files like html, img files, css file javascript files
            app.UseRouting();      //this is used to enable routing of user requests in the web application

            app.UseEndpoints(endpoints =>
            {
                /*endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });*/

                // endpoints.MapDefaultControllerRoute();

                // this is the custom route 
                /*endpoints.MapControllerRoute(
                      name: "myroute",
                      pattern: "Shreya/{id?}",
                      defaults: new { controller = "App", action = "About"});*/

                /* endpoints.MapControllerRoute(
                     name: "fever checkup",
                     pattern: "App/Fevercheckup/{id?}");*/

                // this is the custom route - Assignment 2
                endpoints.MapControllerRoute(
                     name: "FeverCheck",
                     pattern: "FeverCheck",
                     defaults: new { controller = "Temp", action = "FeverCheck" });

                endpoints.MapControllerRoute(
                    name: "about",
                    pattern: "App/About/{id?}");

                endpoints.MapControllerRoute(
                    name: "contact",
                    pattern: "App/Contact/{id?}");

                endpoints.MapControllerRoute(
                    name: "projects",
                    pattern: "App/Projects/{id?}");
                

                endpoints.MapControllerRoute(
                    name: "deafault",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                

            });
        }
    }
}
