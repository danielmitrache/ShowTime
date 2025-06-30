using ShowTime.Components;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using ShowTime.Repositories.Interfaces;
using ShowTime.Repositories.Implementations;
using ShowTime.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddBlazorise( options =>
    {
        options.Immediate = true;
    } )
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();


builder.Services.AddScoped<IRepositoryFestival, RepositoryFestival>();
builder.Services.AddScoped<IRepositoryBand, RepositoryBand>();
builder.Services.AddScoped<IRepositoryBooking, RepositoryBooking>();

builder.Services.AddDbContext<ShowTimeConext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DBConnectionString")
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();