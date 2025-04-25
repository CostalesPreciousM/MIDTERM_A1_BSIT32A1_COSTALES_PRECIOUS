using Microsoft.EntityFrameworkCore;
using MIDTERM_A1_SLOT_MACHINE_BACKEND.Models;

namespace MIDTERM_A1_SLOT_MACHINE_BACKEND.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Player> Players { get; set; }
        public DbSet<GameResult> GameResults { get; set; }
    }
}
