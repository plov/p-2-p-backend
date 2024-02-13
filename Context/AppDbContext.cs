using Microsoft.EntityFrameworkCore;
using p_2_p_backend.Models.User;

namespace p_2_p_backend.Context
{
    public class AppDbContext : DbContext   
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        
        DbSet<User> Users { get; set; }
    }
}
