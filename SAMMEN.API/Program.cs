using AuthJWT.Data;
using AuthJWT.Data.Interfaces;
using DataBase;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NLog;
using NLog.Web;
using SAMMEN.API.Mappers;
using SAMMEN.API.Services.Operativo;
using SAMMEN.API.Services.Operativo.Interfaces;
using System;
using System.Text;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");
try
{

    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllers();
    builder.Services.AddScoped<IAuthRepository, AuthRepository>();
    builder.Services.AddTransient<IHerramientaRepository, HerramientaRepository>();
    builder.Services.AddScoped<IAuxRepository, AuxRepository>();
    builder.Services.AddScoped<IMedidaHerramientaRepository, MedidaHerramientaRepository>();
    builder.Services.AddScoped<IHistorialHerramienta, HistorialHerramientaRepository>();
    builder.Services.AddScoped<IOperador, OperadorRepository>();
    builder.Services.AddScoped<ITokenService, TokenService>();
    builder.Services.AddCors(options => {
        options.AddPolicy(name: "cors",
                          policy =>
                          {
                              policy.WithOrigins("*")
                              .AllowAnyMethod()
                              .AllowAnyHeader();
                          });
    });

    builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
    builder.Services.AddAutoMapper(typeof(AutoMapperOperativo).Assembly);
    builder.Services.AddAutoMapper(typeof(AutoMapperJson).Assembly);

    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token"])),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });
    
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddDbContext<SAMMENContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("Sql"));
    });

    builder.Logging.ClearProviders();
    //builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
    builder.Host.UseNLog();

    var app = builder.Build();

    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<SAMMENContext>();
        context.Database.Migrate();
    }

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseCors("cors");

    app.UseAuthentication();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
catch (Exception ex)
{
    logger.Error(ex, "Stopped program because of exception");
    throw;
}
finally
{
    LogManager.Shutdown();
}
