using Microsoft.EntityFrameworkCore;
using WebApiUsingRepoPattern.Models;

namespace WebApiUsingRepoPattern.Context
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            
        }

        public DbSet<User>  Users { get; set; }
    }
}
