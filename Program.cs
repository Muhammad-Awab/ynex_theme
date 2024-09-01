using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ynex.Data;
using Soenneker.Blazor.FilePond;
using Soenneker.Blazor.TomSelect;
using Soenneker.Blazor.FilePond.Registrars;
using Soenneker.Blazor.TomSelect.Registrars;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<StateService>();
builder.Services.AddSingleton<AppState>();
builder.Services.AddScoped<IActionService, ActionService>();
builder.Services.AddFilePond();
builder.Services.AddTomSelect();
builder.Services.AddWMBOS();
builder.Services.AddWMBSC(); 
builder.Services.AddSweetAlert2();
builder.Services.AddScoped<InvoiceService>();
builder.Services.AddScoped<TaskListService>();
builder.Services.AddScoped<CrmContactsService>();
builder.Services.AddScoped<CrmCompaniesService>();
builder.Services.AddScoped<CrmLeadsService>();
builder.Services.AddScoped<TransactionService>();
builder.Services.AddScoped<ProductListService>();
builder.Services.AddScoped<CartListService>();
builder.Services.AddScoped<MenuDataService>();
builder.Services.AddScoped<LandingMenuDataService>();
builder.Services.AddScoped<JobslandingmenuDataService>();
builder.Services.AddScoped<NavScrollService>();
builder.Services.AddSession();
builder.Services.AddScoped<SessionService>();

// Add session services
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Adjust timeout as needed
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/accessdenied";
        options.Cookie.Name = "YourAppCookieName";
        options.Cookie.HttpOnly = true;
        options.Cookie.SameSite = SameSiteMode.Strict;
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    });



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseSession();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
    
app.UseAuthentication();
app.UseAuthorization();

app.MapFallbackToPage("/landing", "/_LandingHost");
app.MapFallbackToPage("/landing-jobs", "/_LandingJobsHost");

app.MapFallbackToPage("/_Host");

// app.MapFallbackToPage("{*path:nonfile}", "/_Host");

app.Run();


