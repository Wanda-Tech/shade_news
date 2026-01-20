using NewsWebsite.Data; // Your DbContext namespace
using Microsoft.EntityFrameworkCore; // For Entity Framework Core

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews(); // For MVC pattern

// ✅ Register DbContext with SQL Server
// This tells the application how to connect to the database
builder.Services.AddDbContext<NewsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // HTTP Strict Transport Security
}

app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
app.UseStaticFiles(); // Enable serving static files (CSS, JS, images)

app.UseRouting(); // Enable routing

app.UseAuthorization(); // Enable authorization

// Configure default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();