namespace testMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.//Day8
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            #endregion

            app.Run();
        }
    }
}
