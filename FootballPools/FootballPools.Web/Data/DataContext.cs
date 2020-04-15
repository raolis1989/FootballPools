using FootballPools.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballPools.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<GroupDetailEntity> GroupDetails { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<MatchEntity> Matches { get; set; }
        public DbSet<TeamEntity> Teams { get; set; }
        public DbSet<TournamentEntity> Tournaments { get; set; }



    }
}
