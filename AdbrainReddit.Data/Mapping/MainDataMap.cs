using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdbrainReddit.Entity;

namespace AdbrainReddit.Data.Mapping
{
    public class MainDataMap : EntityTypeConfiguration<MainData>
    {
        public MainDataMap()
        {
            // Primary Key
            this.HasKey(t => t.UId);

            // Properties
            // Table & Column Mappings
            this.ToTable("MainData");
            this.Property(t => t.UId).HasColumnName("UId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Modhash).HasColumnName("Modhash");
            this.Property(t => t.After).HasColumnName("After");
            this.Property(t => t.Before).HasColumnName("Before");

            // Relationships
            this.HasRequired(t => t.RedditResponse).WithOptional(u => u.MainData)
                .WillCascadeOnDelete(true);


        }
    }
}
