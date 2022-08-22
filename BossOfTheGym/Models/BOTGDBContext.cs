using Microsoft.EntityFrameworkCore;


namespace BossOfTheGym.Models
{
    public class BOTGDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public BOTGDBContext(DbContextOptions<BOTGDBContext> options) : base(options) { }
    }
}
