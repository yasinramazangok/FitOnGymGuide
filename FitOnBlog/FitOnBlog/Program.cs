using BusinessLayer.Containers;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("FitOnBlogConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FitOnContext>(); // for database

builder.Services.AddIdentity<FitOnBlogUser, IdentityRole>
    (
        options =>
        {
            options.Password.RequiredUniqueChars = 0;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireLowercase = false;
        }
    )
    .AddEntityFrameworkStores<FitOnContext>()
    .AddDefaultTokenProviders();

builder.Services.ContainerDependencies();

builder.Services.AddMvc();


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
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
