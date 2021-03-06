﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTest.Classi;

namespace Db1
{
    public class TimeAndLapseContext : DbContext
    {
        public TimeAndLapseContext() : base("name=TimeAndLapseContext")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<School, Migrations.Configuration>());
            Database.SetInitializer<TimeAndLapseContext>(null);
        }
        public DbSet<Timing> Timings { get; set; }
        public DbSet<TimingType> TimingTypes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
