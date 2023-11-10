using Microsoft.EntityFrameworkCore;
using MVC_AuthorBook.Models;
using System;

namespace MVC_AuthorBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContextPool<BookContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BookDBConnection")));
            builder.Services.AddScoped<IBookRepos, SQLServices>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Book}/{action=Index}/{id?}");

            app.Run();
        }
    }
}