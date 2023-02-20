using Mestami;
using Mestami.Extensions;
using Mestami.Infrastructure;
using Mestami.Infrastructure.Repositories;
using Mestami.Infrastructure.Repositories.Infra;
using Mestami.Infrastructure.Repositories.Infra.Interfaces;
using Mestami.Infrastructure.Repositories.Interfaces;
using LinqToDB.AspNet;
using LinqToDB.Configuration;
using LinqToDB.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using NLog;
using NLog.Web;
using Npgsql;
using System.Configuration;

//var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
//logger.Debug("init main");

// TODO: add AutoMapper

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.LoginPath = new PathString("/User/Login");
            options.AccessDeniedPath = new PathString("/User/Login");
        });

    builder.Services.AddControllersWithViews();
    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddCorsDefault();
    builder.Services.AddSwaggerDefault();

    builder.Services.AddScoped<ILoungeBarRepository, LoungeBarRepository>();

    builder.Services.AddSingleton<IDbConnectionFactory<NpgsqlConnection>, NpgsqlConnectionFactory>(provider
        => new NpgsqlConnectionFactory(
            new DbConnectionOptions(builder.Configuration.GetConnectionString("Default"))
            ));

    var app = builder.Build();

    app.UseStaticFiles();
    app.UseRouting();
    app.UseCors();
    
    app.UseSwagger();
    app.UseSwaggerUI();
    
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");

    app.Run();
}
catch (Exception exception)
{
    //logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    LogManager.Shutdown();
}