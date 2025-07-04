using LearnIdentityFramework.Database;
using Microsoft.EntityFrameworkCore;
using LearnIdentityFramework.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSession();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityDb>(option => 
option.UseSqlServer(builder.Configuration.GetConnectionString("DbIdentityString")));

builder.Services.AddDefaultIdentity<LearnIdentityFrameworkUsers>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<IdentityDb>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.MapRazorPages();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
