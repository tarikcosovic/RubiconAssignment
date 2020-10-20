using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RubiconAssignment.Model;

namespace RubiconAssignment.WebAPI.Configurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(tg => tg.Name);

            //Seed data
            builder.HasData(
                new Tag() { Name = "Android"},
                new Tag() { Name = "iOS" },
                new Tag() { Name = "AR" },
                new Tag() { Name = "VR" },
                new Tag() { Name = "c#" },
                new Tag() { Name = ".Net" },
                new Tag() { Name = "Java" },
                new Tag() { Name = "HTML" },
                new Tag() { Name = "CSS" },
                new Tag() { Name = "JS" },
                new Tag() { Name = "Games" },
                new Tag() { Name = "Music" },
                new Tag() { Name = "Singer" },
                new Tag() { Name = "SQL" },
                new Tag() { Name = "UE" },
                new Tag() { Name = "Unity" },
                new Tag() { Name = "AI" });
        }
    }
}
