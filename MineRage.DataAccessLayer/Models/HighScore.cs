using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineRage.DataAccessLayer.Models
{
    public class HighScore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public double Time{ get; set; }
        public int  Difficulty{ get; set; }
        public bool IsSignedIn { get; set; }

        public static void SetEntityConfiguration(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<HighScore> profileConfig = modelBuilder.Entity<HighScore>();

            // Entity to Table mapping
            profileConfig.ToTable("HighScores");

            // Entity property to column name mapping
            #region - Column Mappings -
            profileConfig
                    .Property(t => t.Id)
                    .HasColumnName("Id")
                    .HasColumnType("int");

            profileConfig
                .Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar");

            profileConfig
                    .Property(t => t.IpAddress)
                    .HasColumnName("IpAddress")
                    .HasColumnType("nvarchar");

            profileConfig
                    .Property(t => t.Time)
                    .HasColumnName("Time")
                    .HasColumnType("float");

            profileConfig
                    .Property(t => t.Difficulty)
                    .HasColumnName("Difficulty")
                    .HasColumnType("int");

            profileConfig
                    .Property(t => t.IsSignedIn)
                    .HasColumnName("IsSignedIn")
                    .HasColumnType("bit");

            #endregion

            // Set Primary key
            profileConfig.HasKey(tz => new { tz.Id });
        }
    }
}
