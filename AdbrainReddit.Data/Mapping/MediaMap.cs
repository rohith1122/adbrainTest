using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdbrainReddit.Entity;

namespace AdbrainReddit.Data.Mapping
{
    public class MediaMap : EntityTypeConfiguration<Media>
    {
        public MediaMap()
        {
            // Primary Key
            this.HasKey(t => t.UId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Media");
            this.Property(t => t.UId).HasColumnName("UId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Type).HasColumnName("Type");

            // Relationships
            this.HasRequired(t => t.MediaOembed).WithOptional(t => t.Media);

        }
    }
}
