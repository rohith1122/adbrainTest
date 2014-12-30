using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AdbrainReddit.Data.Mapping
{
    public class DataMap : EntityTypeConfiguration<Entity.Data>
    {
        public DataMap()
        {
            // Primary Key
            this.HasKey(t => t.UId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Data");
            this.Property(t => t.UId).HasColumnName("UId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Domain).HasColumnName("Domain");
            this.Property(t => t.BannedBy).HasColumnName("BannedBy");
            this.Property(t => t.SubReddit).HasColumnName("SubReddit");
            this.Property(t => t.SelfTextHtml).HasColumnName("SelfTextHtml");
            this.Property(t => t.SelfText).HasColumnName("SelfText");
            this.Property(t => t.Likes).HasColumnName("Likes");
            this.Property(t => t.LinkFlairText).HasColumnName("LinkFlairText");
            this.Property(t => t.Gilded).HasColumnName("Gilded");
            this.Property(t => t.Clicked).HasColumnName("Clicked");
            this.Property(t => t.ReportReasons).HasColumnName("ReportReasons");
            this.Property(t => t.Author).HasColumnName("Author");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.ApprovedBy).HasColumnName("ApprovedBy");
            this.Property(t => t.Over18).HasColumnName("Over18");
            this.Property(t => t.Hidden).HasColumnName("Hidden");
            this.Property(t => t.Thumbnail).HasColumnName("Thumbnail");
            this.Property(t => t.SubredditId).HasColumnName("SubredditId");
            this.Property(t => t.Edited).HasColumnName("Edited");
            this.Property(t => t.LinkFlairCssClass).HasColumnName("LinkFlairCssClass");
            this.Property(t => t.AuthorFlairCssClass).HasColumnName("AuthorFlairCssClass");
            this.Property(t => t.Downs).HasColumnName("Downs");
            this.Property(t => t.Saved).HasColumnName("Saved");
            this.Property(t => t.IsSelf).HasColumnName("IsSelf");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PermaLink).HasColumnName("PermaLink");
            this.Property(t => t.Stickied).HasColumnName("Stickied");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.AuthorFlairText).HasColumnName("AuthorFlairText");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.CreatedUtc).HasColumnName("CreatedUtc");
            this.Property(t => t.Ups).HasColumnName("Ups");
            this.Property(t => t.NumComments).HasColumnName("NumComments");
            this.Property(t => t.Visited).HasColumnName("Visited");
            this.Property(t => t.NumReports).HasColumnName("NumReports");
            this.Property(t => t.Distinguished).HasColumnName("Distinguished");


         
         //Relations
            this.HasRequired(t => t.Child).WithOptional(t => t.Data).WillCascadeOnDelete(true);

        }
    }
}
