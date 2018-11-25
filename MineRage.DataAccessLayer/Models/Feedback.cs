using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineRage.DataAccessLayer.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public static void SetEntityConfiguration(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<Feedback> profileConfig = modelBuilder.Entity<Feedback>();

            // Entity to Table mapping
            profileConfig.ToTable("Feedback");

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

            #endregion

            // Set Primary key
            profileConfig.HasKey(tz => new { tz.Id });
        }
    }
}
