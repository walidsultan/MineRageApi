using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineRage.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public static void SetEntityConfiguration(DbModelBuilder modelBuilder)
        {
            EntityTypeConfiguration<TemplateDto> profileConfig = modelBuilder.Entity<TemplateDto>();

            // Entity to Table mapping
            profileConfig.ToTable("COMP_PROFILE_TEMPLATE");

            // Entity property to column name mapping
            #region - Column Mappings -
            profileConfig
                    .Property(t => t.TemplateId)
                    .HasColumnName("TEMPLATE_ID")
                    .HasColumnOrder(1)
                    .HasColumnType("NUMBER");

            profileConfig
                .Property(t => t.TemplateName)
                .HasColumnName("TEMPLATE_NAME")
                .IsRequired()
                .HasColumnOrder(2)
                .HasColumnType("VARCHAR2");

            profileConfig
                .Property(t => t.TemplateDesc)
                .HasColumnName("TEMPLATE_DESC")
                .HasMaxLength(10)
                .IsRequired()
                .HasColumnType("VARCHAR2");

            profileConfig
                .Property(t => t.CompanyCode)
                .HasColumnName("CO_CD")
                .IsRequired()
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("VARCHAR2");

            profileConfig
                .Property(t => t.RuleSetVersion)
                .HasColumnName("TEMPLATE_FILE_NAME")
                .HasMaxLength(250)
                .HasColumnType("VARCHAR2");

            profileConfig
                .Property(t => t.CreatedBy)
                .HasColumnName("CREATED_BY")
                .IsRequired()
                .HasMaxLength(30)
                .IsRequired()
                .HasColumnType("VARCHAR2");

            profileConfig
                .Property(t => t.CreatedDt)
                .HasColumnName("CREATED_DT")
                .HasColumnType("DATE");

            profileConfig
                .Property(t => t.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .IsRequired()
                .HasColumnType("VARCHAR2");

            profileConfig
                .Property(t => t.UpdatedDt)
                .HasColumnName("UPDATED_DT")
                .IsRequired()
                .HasColumnType("DATE");

            profileConfig
                .Property(t => t.ProfileTemplate)
                .HasColumnName("PROFILE_TEMPLATE")
                .HasMaxLength(100)
                .HasColumnType("CLOB");

            profileConfig
               .Property(t => t.Status)
               .HasColumnName("STATUS")
               .HasMaxLength(15)
               .HasColumnType("VARCHAR2");

            profileConfig
              .Property(t => t.TemplateGuid)
              .HasColumnName("TEMPLATE_GUID")
              .IsRequired()
              .HasColumnType("RAW");

            profileConfig
            .Property(t => t.TemplateVersion)
            .HasColumnName("TEMPLATE_VERSION")
            .HasColumnType("NUMBER");

            #endregion

            // Set Primary key
            profileConfig.HasKey(tz => new { tz.TemplateId });
        }
    }
}
