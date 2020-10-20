﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RubiconAssignment.WebAPI;

namespace RubiconAssignment.WebAPI.Migrations
{
    [DbContext(typeof(SQLiteDBContext))]
    partial class SQLiteDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("RubiconAssignment.Model.BlogPost", b =>
                {
                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<string>("Body")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasMaxLength(2500)
                        .HasDefaultValue("");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2020, 10, 19, 20, 27, 34, 546, DateTimeKind.Utc).AddTicks(2239));

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500)
                        .HasDefaultValue("");

                    b.Property<string>("Title")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100)
                        .HasDefaultValue("");

                    b.Property<DateTime>("UpdatedAt")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2020, 10, 19, 20, 27, 34, 546, DateTimeKind.Utc).AddTicks(3304));

                    b.HasKey("Slug");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Slug = "do-we-live-in-a-simulation",
                            Body = "It is not often that a comedian gives an astrophysicist goose bumps when discussing the laws of physics. But comic Chuck Nice managed to do just that in a recent episode of the podcast StarTalk. The show’s host Neil deGrasse Tyson had just explained the simulation argument—the idea that we could be virtual beings living in a computer simulation. If so, the simulation would most likely create perceptions of reality on demand rather than simulate all of reality all the time—much like a video game optimized to render only the parts of a scene visible to a player.",
                            CreatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(6980),
                            Description = "Gauging whether or not we dwell inside someone else’s computer may come down to advanced AI research—or measurements at the frontiers of cosmology",
                            Title = "Do we live in a simulation?",
                            UpdatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(7624)
                        },
                        new
                        {
                            Slug = "everything-we-know-cyberpunk-2077",
                            Body = "Cyberpunk 2077 is an open-world RPG developed by CD Projekt RED and set in the futuristic metropolis of Night City, Northern California. The year is 2077, and the game itself will be based on the pen-and-paper tabletop Cyberpunk, created by Mike Pondsmith.Night City will feel alive with new busy crowd technologies the developer has built, but it's not all glamorous as the postcards would have you believe. Nothing is procedural, and the world will be massive, with plenty of vertical areas to explore, namely buildings. There are going to be areas that will require wit and some diplomacy if you don't want to engage foes in combat.",
                            CreatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8260),
                            Description = "Cyberpunk 2077 is an upcoming RPG from CD Projekt RED, the makers of the critically acclaimed Witcher series.",
                            Title = "Everything We Know Cyberpunk 2077",
                            UpdatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8273)
                        },
                        new
                        {
                            Slug = "2001-a-space-odyssey-1968",
                            Body = "It was e. e. cummings, the poet, who said he'd rather learn from one bird how to sing than teach 10,000 stars how not to dance. I imagine cummings would not have enjoyed Stanley Kubrick's 2001:A Space in which stars dance but birds do not sing. The fascinating thing about this film is that it fails on the human level but succeeds magnificently on a cosmic scale universe, and the space ships he constructed to explore it, are simply out of scale with human concerns. The ships are perfect, impersonal machines which venture from one planet to another, and if men are tucked away somewhere inside them, then they get there too.",
                            CreatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8284),
                            Description = "Roger Ebert reviews a cult classic, 2001 A Space Odyssey.",
                            Title = "2001 A Space Odyssey 1968 Review",
                            UpdatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8286)
                        },
                        new
                        {
                            Slug = "flume-aussie-dj-producer-sex-act-burning-man-festival",
                            Body = "The Australian DJ's real name is Harley Edward Streten.The 27 - year - old is a platinum selling and Grammy Award - winning artist.He opted for the moniker Flume after the Bon Iver song of the same name and since has remixed songs from such artists as Lorde, Sam Smith, Arcade Fire, Hermitude and Disclosure.His second studio album, Skin won the Best Dance / Electronic Album at the 2017 Grammy Awards.",
                            CreatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8288),
                            Description = "WE take a a look at the life career of the controversial DJ Flume.",
                            Title = "Who is Flume? Aussie DJ and producer who performed x-rated sex act on stage at Burning Man festival",
                            UpdatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8289)
                        },
                        new
                        {
                            Slug = "alphastar-mastering-the-real-time-strategy-game-starcraft-ii",
                            Body = "Due to these immense challenges, StarCraft has emerged as a “grand challenge” for AI research. Ongoing competitions in both StarCraft and StarCraft II have assessed progress since the launch of the BroodWar API in 2009, including the AIIDE StarCraft AI Competition, CIG StarCraft Competition, Student StarCraft AI Tournament, and the Starcraft II AI Ladder. To help the community explore these problems further, we worked with Blizzard in 2016 and 2017 to release an open-source set of tools known as PySC2, including the largest set of anonymised game replays ever released. We have now built on this work, combining engineering and algorithmic breakthroughs to produce AlphaStar.",
                            CreatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8291),
                            Description = "Games have been used for decades as an important way to test and evaluate the performance of artificial intelligence systems..",
                            Title = "AlphaStar: Mastering the Real-Time Strategy Game StarCraft II",
                            UpdatedAt = new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8292)
                        });
                });

            modelBuilder.Entity("RubiconAssignment.Model.BlogPostTag", b =>
                {
                    b.Property<string>("BlogPostId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TagId")
                        .HasColumnType("TEXT");

                    b.HasKey("BlogPostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("BlogPostTags");

                    b.HasData(
                        new
                        {
                            BlogPostId = "do-we-live-in-a-simulation",
                            TagId = "AI"
                        },
                        new
                        {
                            BlogPostId = "do-we-live-in-a-simulation",
                            TagId = "AR"
                        },
                        new
                        {
                            BlogPostId = "do-we-live-in-a-simulation",
                            TagId = "VR"
                        },
                        new
                        {
                            BlogPostId = "everything-we-know-cyberpunk-2077",
                            TagId = "Games"
                        },
                        new
                        {
                            BlogPostId = "everything-we-know-cyberpunk-2077",
                            TagId = "AI"
                        },
                        new
                        {
                            BlogPostId = "flume-aussie-dj-producer-sex-act-burning-man-festival",
                            TagId = "Music"
                        },
                        new
                        {
                            BlogPostId = "flume-aussie-dj-producer-sex-act-burning-man-festival",
                            TagId = "Singer"
                        });
                });

            modelBuilder.Entity("RubiconAssignment.Model.Tag", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Name = "Android"
                        },
                        new
                        {
                            Name = "iOS"
                        },
                        new
                        {
                            Name = "AR"
                        },
                        new
                        {
                            Name = "VR"
                        },
                        new
                        {
                            Name = "c#"
                        },
                        new
                        {
                            Name = ".Net"
                        },
                        new
                        {
                            Name = "Java"
                        },
                        new
                        {
                            Name = "HTML"
                        },
                        new
                        {
                            Name = "CSS"
                        },
                        new
                        {
                            Name = "JS"
                        },
                        new
                        {
                            Name = "Games"
                        },
                        new
                        {
                            Name = "Music"
                        },
                        new
                        {
                            Name = "Singer"
                        },
                        new
                        {
                            Name = "SQL"
                        },
                        new
                        {
                            Name = "UE"
                        },
                        new
                        {
                            Name = "Unity"
                        },
                        new
                        {
                            Name = "AI"
                        });
                });

            modelBuilder.Entity("RubiconAssignment.Model.BlogPostTag", b =>
                {
                    b.HasOne("RubiconAssignment.Model.BlogPost", "BlogPost")
                        .WithMany("Tags")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RubiconAssignment.Model.Tag", "Tag")
                        .WithMany("BlogPosts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
