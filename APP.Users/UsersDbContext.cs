using Microsoft.EntityFrameworkCore;
using APP.Users.Domain;


namespace APP.Users
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options)
            : base(options)
        {
        }

        public DbSet<Skill> Skills { get; set; }
    }
}