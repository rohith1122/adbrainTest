using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdbrainReddit.Entity;

namespace AdbrainReddit.Data.Mapping
{
    public class MediaEmbedMap : EntityTypeConfiguration<MediaEmbed>
    {
        public MediaEmbedMap()
        {
            // Primary Key
            this.HasKey(t => t.UId);

            // Properties
            // Table & Column Mappings
            this.ToTable("MediaEmbed");
            this.Property(t => t.UId).HasColumnName("UId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Scrolling).HasColumnName("Scrolling");
            this.Property(t => t.Height).HasColumnName("Height");

            //Relations
            //this.HasRequired(t => t.Data).WithOptional(t => t.MediaEmbed);
        }
    }
}
