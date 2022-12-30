using AuthJWT.Data;
using AuthJWT.Data.Interfaces;
using DataBase;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SAMMEN.API.Mappers;
using SAMMEN.API.Services.Operativo;
using SAMMEN.API.Services.Operativo.Interfaces;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IHerramientaRepository, HerramientaRepository>();
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
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SAMMENContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Sql"));
});

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
