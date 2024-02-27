using Microsoft.EntityFrameworkCore;
using WebApplication1.ModelTest;
using WebApplication1.ModelTest;
using WebApplication1.Repositores;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CustomersDbContext >(op => op.UseSqlServer(builder.Configuration.GetConnectionString("db")));
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
