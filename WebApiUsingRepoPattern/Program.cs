
using Microsoft.EntityFrameworkCore;
using WebApiUsingRepoPattern.Context;
using WebApiUsingRepoPattern.IRepository;
using WebApiUsingRepoPattern.Repository;

namespace WebApiUsingRepoPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // register your service here with a lifetime scope
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            // AddScoped  > there will be one instance for request by one user
            // AddSingleton > there will be one instance for all requests
            // AddTransient > there will be one instance for every request

            builder.Services.AddDbContext<UserDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("TaskConnection")));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}
