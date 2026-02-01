using Microsoft.EntityFrameworkCore;
using src.assignment_1.domain.entity;

namespace src.assignment_1.infrastructure.data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Agents> Agents { get; set; }
}
