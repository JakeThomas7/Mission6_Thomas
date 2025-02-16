using Microsoft.EntityFrameworkCore;
using Mission6_Thomas.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. This is where we register dependencies for our app.
builder.Services.AddControllersWithViews(); // Registers MVC controller and view services for routing and rendering.

builder.Services.AddDbContext<MovieContext>(options =>
{
    // Configures the database connection using SQLite. The connection string is pulled from the app's configuration.
    options.UseSqlite(builder.Configuration.GetConnectionString("MoviesConnection"));
});

var app = builder.Build(); // Builds the app with the services configured.

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Ensures HTTPS redirection is enabled, forcing all requests to use HTTPS.
app.UseHttpsRedirection();
// Serves static files (e.g., images, CSS, JS) from the web root directory.
app.UseStaticFiles();
// Enables routing, which matches incoming requests to appropriate controllers and actions.
app.UseRouting();
// Enables authorization middleware, ensuring that authorized users can access specific resources.
app.UseAuthorization();
// Configures the default route pattern for the app's controllers. If no controller or action is provided, it defaults to Home/Index.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); // Runs the application, starting the web server and processing requests.