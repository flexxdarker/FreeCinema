using BusinessLogic;
using BusinessLogic.Interfaces;
using DataAccess;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using DataAccess.Repostories;
using FreeCinema.Helpers;

namespace FreeCinema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connStr = builder.Configuration.GetConnectionString("LocalDb")!;

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            // TODO: configure swagger with JWT 
            builder.Services.AddSwaggerGen();
            //builder.Services.AddJWT(builder.Configuration);
            //builder.Services.AddRequirements();

            builder.Services.AddDbContext(connStr);
            builder.Services.AddIdentity();
            builder.Services.AddRepositories();

            builder.Services.AddAutoMapper();
            builder.Services.AddFluentValidators();

            builder.Services.AddCustomServices();
            //builder.Services.AddScoped<ICartService, CartService>();
            //builder.Services.AddScoped<IViewRender, ViewRender>();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                scope.ServiceProvider.SeedRoles().Wait();
                scope.ServiceProvider.SeedAdmin().Wait();
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseMiddleware<GlobalErrorHandler>();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
