using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using testMVC.Models;
using testMVC.Repository;

namespace testMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //to add the repository to the services
            //to make register 
            //1. Framework services : already declared , already registered
            //ex: IConfiguration,ILogger
            //2.Built-in services : already declared , need to register
            //ex:Session,HttpContext

            // Add services to the container.//Day8
            //builder.Services.AddControllersWithViews(option =>
            //{
            //    option.Filters.Add(new HandelErrorAttribute());
            //});
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            builder.Services.AddDbContext<ITIContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            });
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(option =>
            {
                option.Password.RequireDigit = false;
                option.Password.RequireLowercase = true;
                option.Password.RequireUppercase = false;
                option.Password.RequiredLength = 4;
                option.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<ITIContext>();
            //3.Custom services : need to declare and register
            //ex:DepartmentRepository,EmployeeRepository
            //Register the repository
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            var app = builder.Build();

            #region custom Middleware"Inline Middleware"
            //app.Use(async (httpContext, Next) => {
            //    await  httpContext.Response.WriteAsync("1)Middleware 1\n");
            //    await Next.Invoke();
            //});

            //app.Use(async (httpContext, Next) => {
            //    await httpContext.Response.WriteAsync("2)Middleware 2\n");
            //    await Next.Invoke();
            //});
            //app.Run(async (httpContext) =>
            //{
            //    await httpContext.Response.WriteAsync("3)Terminate \n");
            //});
            #endregion
            #region Built in Middleware
            //Configure the HTTP request pipeline.//Day4 (Middleware)
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();//css , JS files

            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            //Declare & Execute
            //naming convension Route (Define rout with name , pattern , default )
            //constraint
            //optional segment -> last segment
            //app.MapControllerRoute("Route1", "R1/{name}/{age:int}/{color?}",
            //    new { controller = "Route", Action = "Method1" }
            //    );
            //app.MapControllerRoute("Route2", "R2",
            //    new { controller = "Route", Action = "Method2" }
            //    );
            //app.MapControllerRoute("Route1", "{controller=Route}/{action=Method1}"
            //    );
            


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            #endregion

            app.Run();
        }
    }
}
