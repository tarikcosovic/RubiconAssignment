using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RubiconAssignment.Model;
using System;

namespace RubiconAssignment.WebAPI.Configurations
{
    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasKey(bp => bp.Slug);

            builder.Property(bp => bp.Title)
                .IsRequired()
                .HasMaxLength(100)
                .HasDefaultValue(string.Empty);

            builder.Property(bp => bp.Description)
                .IsRequired()
                .HasMaxLength(500)
                .HasDefaultValue(string.Empty);

            builder.Property(bp => bp.Body)
                .IsRequired()
                .HasMaxLength(2500)
                .HasDefaultValue(string.Empty);

            builder.Property(bp => bp.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow);

            builder.Property(bp => bp.UpdatedAt)
                .HasDefaultValue(DateTime.UtcNow)
                .IsConcurrencyToken();

            //Seed data
            builder.HasData(
                new BlogPost
                {
                    Slug = "do-we-live-in-a-simulation",
                    Title = "Do we live in a simulation?",
                    Description = "Gauging whether or not we dwell inside someone else’s computer may come down to advanced AI research—or measurements at the frontiers of cosmology",
                    Body = "It is not often that a comedian gives an astrophysicist goose bumps when discussing the laws of physics. But comic Chuck Nice managed to do just that in a recent episode of the podcast StarTalk. The show’s host Neil deGrasse Tyson had just explained the simulation argument—the idea that we could be virtual beings living in a computer simulation. If so, the simulation would most likely create perceptions of reality on demand rather than simulate all of reality all the time—much like a video game optimized to render only the parts of a scene visible to a player.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new BlogPost
                {
                    Slug = "everything-we-know-cyberpunk-2077",
                    Title = "Everything We Know Cyberpunk 2077",
                    Description = "Cyberpunk 2077 is an upcoming RPG from CD Projekt RED, the makers of the critically acclaimed Witcher series.",
                    Body = "Cyberpunk 2077 is an open-world RPG developed by CD Projekt RED and set in the futuristic metropolis of Night City, Northern California. The year is 2077, and the game itself will be based on the pen-and-paper tabletop Cyberpunk, created by Mike Pondsmith.Night City will feel alive with new busy crowd technologies the developer has built, but it's not all glamorous as the postcards would have you believe. Nothing is procedural, and the world will be massive, with plenty of vertical areas to explore, namely buildings. There are going to be areas that will require wit and some diplomacy if you don't want to engage foes in combat.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new BlogPost
                {
                    Slug = "2001-a-space-odyssey-1968",
                    Title = "2001 A Space Odyssey 1968 Review",
                    Description = "Roger Ebert reviews a cult classic, 2001 A Space Odyssey.",
                    Body = "It was e. e. cummings, the poet, who said he'd rather learn from one bird how to sing than teach 10,000 stars how not to dance. I imagine cummings would not have enjoyed Stanley Kubrick's 2001:A Space in which stars dance but birds do not sing. The fascinating thing about this film is that it fails on the human level but succeeds magnificently on a cosmic scale universe, and the space ships he constructed to explore it, are simply out of scale with human concerns. The ships are perfect, impersonal machines which venture from one planet to another, and if men are tucked away somewhere inside them, then they get there too.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new BlogPost
                {
                    Slug = "flume-aussie-dj-producer-sex-act-burning-man-festival",
                    Title = "Who is Flume? Aussie DJ and producer who performed x-rated sex act on stage at Burning Man festival",
                    Description = "WE take a a look at the life career of the controversial DJ Flume.",
                    Body = "The Australian DJ's real name is Harley Edward Streten.The 27 - year - old is a platinum selling and Grammy Award - winning artist.He opted for the moniker Flume after the Bon Iver song of the same name and since has remixed songs from such artists as Lorde, Sam Smith, Arcade Fire, Hermitude and Disclosure.His second studio album, Skin won the Best Dance / Electronic Album at the 2017 Grammy Awards.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new BlogPost
                {
                    Slug = "alphastar-mastering-the-real-time-strategy-game-starcraft-ii",
                    Title = "AlphaStar: Mastering the Real-Time Strategy Game StarCraft II",
                    Description = "Games have been used for decades as an important way to test and evaluate the performance of artificial intelligence systems..",
                    Body = "Due to these immense challenges, StarCraft has emerged as a “grand challenge” for AI research. Ongoing competitions in both StarCraft and StarCraft II have assessed progress since the launch of the BroodWar API in 2009, including the AIIDE StarCraft AI Competition, CIG StarCraft Competition, Student StarCraft AI Tournament, and the Starcraft II AI Ladder. To help the community explore these problems further, we worked with Blizzard in 2016 and 2017 to release an open-source set of tools known as PySC2, including the largest set of anonymised game replays ever released. We have now built on this work, combining engineering and algorithmic breakthroughs to produce AlphaStar.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
        }
    }
}
