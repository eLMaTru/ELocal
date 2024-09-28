// En tu carpeta Data o Models
using Microsoft.EntityFrameworkCore;
namespace ELocal.Data
{

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Event> Events { get; set; }
}
}