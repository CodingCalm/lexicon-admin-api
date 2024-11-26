using lexicon_admin.api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace lexicon_admin.api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}
