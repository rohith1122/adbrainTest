using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdbrainReddit.Entity;

namespace AdbrainReddit.Data.Mapping
{
    public class SecureMediaMap : EntityTypeConfiguration<SecureMedia>
    {
        public SecureMediaMap()
        {
            // Primary Key
            this.HasKey(t => t.UId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SecureMedia");
            this.Property(t => t.UId).HasColumnName("UId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Type).HasColumnName("Type");

            // Relationships
           // this.HasRequired(t => t.Data).WithOptional(t => t.SecureMedia);
            this.HasRequired(t => t.SecureMediaOembed).WithOptional(t => t.SecureMedia);
        }
    }
}
