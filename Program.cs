using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<GeziRehberimContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GeziRehberimBaglantý")));

builder.Services.AddIdentity<UygulamaKullanýcýsý, UygulamaRolü>()
	.AddErrorDescriber<ÜyeKimlikDogrulama>().AddTokenProvider<DataProtectorTokenProvider<UygulamaKullanýcýsý>>(TokenOptions.DefaultProvider)
	.AddEntityFrameworkStores<GeziRehberimContext>()
	.AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews(opt =>
{
	var policy = new AuthorizationPolicyBuilder()
	.RequireAuthenticatedUser()
	.Build();
	opt.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/HataSayfasý/Hata404/", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



    app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
     name: "areas",
     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();
