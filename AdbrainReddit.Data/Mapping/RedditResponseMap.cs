using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdbrainReddit.Entity;

namespace AdbrainReddit.Data.Mapping
{
    public class RedditResponseMap : EntityTypeConfiguration<RedditResponse>
    {
        public RedditResponseMap()
        {
            // Primary Key
            this.HasKey(t => t.UId);

            
            // Table & Column Mappings
            this.ToTable("RedditResponse");


            // Properties
            this.Property(t => t.UId).HasColumnName("UId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Kind).HasColumnName("Kind");
            
            

            
        }
    }
}
