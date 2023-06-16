using JobApplication.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
  builder.Services.AddDbContext<JobDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

builder.Services.AddAuthentication("Mycookies").AddCookie("Mycookies", (options) => {
    options.Cookie.Name = "Mycookies";
    options.LoginPath = "/JobApplication/Login";
    options.AccessDeniedPath = "/JobApplication/AccessDenieds";

});
builder.Services.AddAuthorization((options) => {
    options.AddPolicy("adminonly", Policy => Policy.RequireClaim("Admin"));
    options.AddPolicy("user_ID", Policy => Policy.RequireClaim("user_ID"));
    options.AddPolicy("Users", Policy => Policy.RequireClaim("Users"));

}); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseAuthentication();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
