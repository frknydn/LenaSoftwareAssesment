using LenaSoftware.Business.Extensions;
using LenaSoftware.DataAccess.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.DataAccessServices(builder.Configuration).BusinessServices();
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
{
    opt.LoginPath = "/Login";
    opt.Cookie = new CookieBuilder
    {
        Name = "LenaProject",
        SecurePolicy = CookieSecurePolicy.Always,
        HttpOnly = true, 
    };
    opt.ExpireTimeSpan = TimeSpan.FromSeconds(120);
    opt.SlidingExpiration = true;
    opt.Cookie.MaxAge = opt.ExpireTimeSpan;
});

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
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
