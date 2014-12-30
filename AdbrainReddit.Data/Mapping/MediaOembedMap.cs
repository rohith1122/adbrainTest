using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdbrainReddit.Entity;

namespace AdbrainReddit.Data.Mapping
{
    public class MediaOembedMap : EntityTypeConfiguration<MediaOembed>
    {
        public MediaOembedMap()
        {
            // Primary Key
            this.HasKey(t => t.UId);

            // Properties
            // Table & Column Mappings
            this.ToTable("MediaOembed");
            this.Property(t => t.UId).HasColumnName("UId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.ProviderUrl).HasColumnName("ProviderUrl");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.AuthorName).HasColumnName("AuthorName");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.Html).HasColumnName("Html");
            this.Property(t => t.ThumbnailWidth).HasColumnName("ThumbnailWidth");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.ProviderName).HasColumnName("ProviderName");
            this.Property(t => t.ThumbnailUrl).HasColumnName("ThumbnailUrl");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.ThumbnailHeight).HasColumnName("ThumbnailHeight");
            this.Property(t => t.AuthorUrl).HasColumnName("AuthorUrl");

            //relations
            
        }
    }
}
