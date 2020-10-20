using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RubiconAssignment.Model;

namespace RubiconAssignment.WebAPI.Configurations
{
    public class BlogPostTagConfiguration : IEntityTypeConfiguration<BlogPostTag>
    {
        public void Configure(EntityTypeBuilder<BlogPostTag> builder)
        {
            builder.HasKey(c => new { c.BlogPostId, c.TagId });

            builder.HasOne(bpt => bpt.BlogPost)
                .WithMany(bp => bp.Tags)
                .HasForeignKey(bpt => bpt.BlogPostId);

            builder.HasOne(bpt => bpt.Tag)
                .WithMany(tg => tg.BlogPosts)
                .HasForeignKey(bpt => bpt.TagId);

            //Seed data
            builder.HasData(
                new BlogPostTag() { BlogPostId = "do-we-live-in-a-simulation", TagId = "AI" },
                new BlogPostTag() { BlogPostId = "do-we-live-in-a-simulation", TagId = "AR" },
                new BlogPostTag() { BlogPostId = "do-we-live-in-a-simulation", TagId = "VR" },
                new BlogPostTag() { BlogPostId = "everything-we-know-cyberpunk-2077", TagId = "Games" },
                new BlogPostTag() { BlogPostId = "everything-we-know-cyberpunk-2077", TagId = "AI" },
                new BlogPostTag() { BlogPostId = "flume-aussie-dj-producer-sex-act-burning-man-festival", TagId = "Music" },
                new BlogPostTag() { BlogPostId = "flume-aussie-dj-producer-sex-act-burning-man-festival", TagId = "Singer" }
                );
        }
    }
}
