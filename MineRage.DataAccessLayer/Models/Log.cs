using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineRage.DataAccessLayer.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate{ get; set; }
        public string IpAddress { get; set; }

        public static void SetEntityConfiguration(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<Log> profileConfig = modelBuilder.Entity<Log>();

            // Entity to Table mapping
            profileConfig.ToTable("Logs");

            // Entity property to column name mapping
            #region - Column Mappings -
            profileConfig
                    .Property(t => t.Id)
                    .HasColumnName("Id")
                    .HasColumnType("int");

            profileConfig
                .Property(t => t.Text)
                .HasColumnName("Text")
                .HasColumnType("ntext");

            profileConfig
                    .Property(t => t.IpAddress)
                    .HasColumnName("IpAddress")
                    .HasColumnType("nvarchar");

            profileConfig
                    .Property(t => t.CreatedDate)
                    .HasColumnName("CreatedDate")
                    .HasColumnType("datetime");

            #endregion

            // Set Primary key
            profileConfig.HasKey(tz => new { tz.Id });
        }
    }
}
