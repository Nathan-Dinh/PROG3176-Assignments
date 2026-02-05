using assignment_1.src.infrastructure.data;
using assignment_1.src.infrastructure.unitOfWork;
using Microsoft.EntityFrameworkCore;

namespace assignment_1.src;

public class Program
{
  public static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")),
        ServiceLifetime.Scoped
      );

    builder.Services.AddScoped<UnitOfWork>();

    builder.Services.AddControllers();
    builder.Services.AddAuthorization();
    builder.Services.AddOpenApi();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
      app.MapOpenApi();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
  }
}
