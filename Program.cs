var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //mvc ozelligi kazandirir.
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

//Controller, action, id?
//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}"
);
app.Run();
