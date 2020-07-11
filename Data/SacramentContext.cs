using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;

namespace MeetingPlanner.Data
{
    public class SacramentContext : DbContext
    {
        public SacramentContext (DbContextOptions<SacramentContext> options)
            : base(options)
        {
        }

        public DbSet<MeetingPlanner.Models.Planner> Planners { get; set; }
        public DbSet<MeetingPlanner.Models.Talk> Talks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Talk>().ToTable("Talk");
            modelBuilder.Entity<Planner>().ToTable("Planner");
        }
    }
}
