using Microsoft.EntityFrameworkCore;
using Project.MVCUI.Models.ContextClasses;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextPool<MyContext>(x =>x.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies());
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache(); 
builder.Services.AddSession(x =>
{
    x.Cookie.HttpOnly = true;
    x.IdleTimeout = TimeSpan.FromMinutes(10);
});
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
