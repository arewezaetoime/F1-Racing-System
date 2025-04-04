
using F1_Racing_System.Data;
using Microsoft.EntityFrameworkCore;
using F1_Racing_System.Mappings;
using F1_Racing_System.Repositories;
using System.Text.Json.Serialization;
using Serilog;
using Microsoft.AspNetCore.Diagnostics;


namespace F1_Racing_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("Logs/f1_api_log.txt", rollingInterval: RollingInterval.Day)
                .MinimumLevel.Information()
                .CreateLogger();

            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog(logger);

            // Add services to the container.

            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddAutoMapper(typeof(AutomapperProfiles));
            builder.Services.AddScoped<ITeamRepository, TeamRepository>();
            builder.Services.AddScoped<IDriverRepository, DriverRepository>();
            builder.Services.AddScoped<IRaceRepository, RaceRepository>();
            builder.Services.AddScoped<IStandingsRepository, StandingsRepository>();
            builder.Services.AddControllers().AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        // OR to ignore cycles
        // options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });


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
            app.UseMiddleware<Middlewares.ExceptionHandlerMiddleware>();    
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
