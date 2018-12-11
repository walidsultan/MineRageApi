using MineRage.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineRage.DataAccessLayer
{
    public class MineRageDBContext : DbContext
    {
        public MineRageDBContext() : base("MineRageDBConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("walid");

            MineRage.DataAccessLayer.Models.Feedback.SetEntityConfiguration(modelBuilder);
            MineRage.DataAccessLayer.Models.HighScore.SetEntityConfiguration(modelBuilder);
            MineRage.DataAccessLayer.Models.Log.SetEntityConfiguration(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<HighScore> HighScores { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
