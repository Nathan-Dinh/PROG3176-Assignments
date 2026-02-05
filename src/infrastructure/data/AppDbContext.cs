using Microsoft.EntityFrameworkCore;
using assignment_1.src.domain.entity;

namespace assignment_1.src.infrastructure.data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
  public DbSet<Agents> Agents { get; set; }
}
