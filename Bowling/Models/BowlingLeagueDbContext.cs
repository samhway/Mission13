using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling.Models
{
    public class BowlingLeagueDbContext : DbContext
    {
        public BowlingLeagueDbContext(DbContextOptions<BowlingLeagueDbContext> options) : base (options)
        {

        }

        public DbSet<Bowler> Bowlers { get; set; }
    }
}
