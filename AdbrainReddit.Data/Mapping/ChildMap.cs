using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdbrainReddit.Entity;

namespace AdbrainReddit.Data.Mapping
{
    public class ChildMap : EntityTypeConfiguration<Child>
    {
        public ChildMap()
        {
            // Primary Key
            this.HasKey(t => t.UId);


        
            // Table & Column Mappings
            this.ToTable("Children");
            this.Property(t => t.UId).HasColumnName("UId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Kind).HasColumnName("Kind");
            this.Property(t => t.MainDataId).HasColumnName("MainDataId");


            // Relationships
            this.HasRequired(t => t.MainData)
                .WithMany(t => t.Children)
                .HasForeignKey(d => d.MainDataId).WillCascadeOnDelete(true);

            

          

        }
    }
}
