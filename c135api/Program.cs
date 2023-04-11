using c135api.BLL.Abstract;
using c135api.BLL.Concrete;
using c135api.BLL.Mappers;
using c135api.Core;
using c135api.DAL;
using c135api.DAL.Abstract;
using c135api.DAL.Concrete;
using c135api.DAL.UnitOfWork.Abstract;
using c135api.DAL.UnitOfWork.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("AppDb"));
});

builder.Services.AddAutoMapper(typeof(AutomapperProfiles));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
