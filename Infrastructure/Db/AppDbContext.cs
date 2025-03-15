using Microsoft.EntityFrameworkCore;
using Core.Entities.User;

namespace Infrastructure.Db.AppDbContext;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<User> User { get; set; }


    
}