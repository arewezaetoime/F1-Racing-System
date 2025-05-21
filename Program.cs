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
            
            // Configure Swagger more explicitly
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Make Swagger available regardless of environment
            // This helps with cross-platform development
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "F1 Racing API V1");
                // Keep the default route prefix
                options.RoutePrefix = "swagger";
            });

            // Add a redirect from root to Swagger UI
            app.MapGet("/", () => Results.Redirect("/swagger"));

            app.UseMiddleware<Middlewares.ExceptionHandlerMiddleware>();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            // Output URLs to console for debugging
            var urls = app.Urls.ToList();
            logger.Information("Application starting on URLs: {Urls}", string.Join(", ", urls));
            
            app.Run();
        }
    }
}