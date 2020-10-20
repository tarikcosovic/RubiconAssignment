using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RubiconAssignment.WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Slug = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false, defaultValue: ""),
                    Description = table.Column<string>(maxLength: 500, nullable: false, defaultValue: ""),
                    Body = table.Column<string>(maxLength: 2500, nullable: false, defaultValue: ""),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 19, 20, 27, 34, 546, DateTimeKind.Utc).AddTicks(2239)),
                    UpdatedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 19, 20, 27, 34, 546, DateTimeKind.Utc).AddTicks(3304))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Slug);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostTags",
                columns: table => new
                {
                    BlogPostId = table.Column<string>(nullable: false),
                    TagId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostTags", x => new { x.BlogPostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_BlogPostTags_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Slug",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Slug", "Body", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { "do-we-live-in-a-simulation", "It is not often that a comedian gives an astrophysicist goose bumps when discussing the laws of physics. But comic Chuck Nice managed to do just that in a recent episode of the podcast StarTalk. The show’s host Neil deGrasse Tyson had just explained the simulation argument—the idea that we could be virtual beings living in a computer simulation. If so, the simulation would most likely create perceptions of reality on demand rather than simulate all of reality all the time—much like a video game optimized to render only the parts of a scene visible to a player.", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(6980), "Gauging whether or not we dwell inside someone else’s computer may come down to advanced AI research—or measurements at the frontiers of cosmology", "Do we live in a simulation?", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Slug", "Body", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { "everything-we-know-cyberpunk-2077", "Cyberpunk 2077 is an open-world RPG developed by CD Projekt RED and set in the futuristic metropolis of Night City, Northern California. The year is 2077, and the game itself will be based on the pen-and-paper tabletop Cyberpunk, created by Mike Pondsmith.Night City will feel alive with new busy crowd technologies the developer has built, but it's not all glamorous as the postcards would have you believe. Nothing is procedural, and the world will be massive, with plenty of vertical areas to explore, namely buildings. There are going to be areas that will require wit and some diplomacy if you don't want to engage foes in combat.", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8260), "Cyberpunk 2077 is an upcoming RPG from CD Projekt RED, the makers of the critically acclaimed Witcher series.", "Everything We Know Cyberpunk 2077", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Slug", "Body", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { "2001-a-space-odyssey-1968", "It was e. e. cummings, the poet, who said he'd rather learn from one bird how to sing than teach 10,000 stars how not to dance. I imagine cummings would not have enjoyed Stanley Kubrick's 2001:A Space in which stars dance but birds do not sing. The fascinating thing about this film is that it fails on the human level but succeeds magnificently on a cosmic scale universe, and the space ships he constructed to explore it, are simply out of scale with human concerns. The ships are perfect, impersonal machines which venture from one planet to another, and if men are tucked away somewhere inside them, then they get there too.", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8284), "Roger Ebert reviews a cult classic, 2001 A Space Odyssey.", "2001 A Space Odyssey 1968 Review", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Slug", "Body", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { "flume-aussie-dj-producer-sex-act-burning-man-festival", "The Australian DJ's real name is Harley Edward Streten.The 27 - year - old is a platinum selling and Grammy Award - winning artist.He opted for the moniker Flume after the Bon Iver song of the same name and since has remixed songs from such artists as Lorde, Sam Smith, Arcade Fire, Hermitude and Disclosure.His second studio album, Skin won the Best Dance / Electronic Album at the 2017 Grammy Awards.", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8288), "WE take a a look at the life career of the controversial DJ Flume.", "Who is Flume? Aussie DJ and producer who performed x-rated sex act on stage at Burning Man festival", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Slug", "Body", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { "alphastar-mastering-the-real-time-strategy-game-starcraft-ii", "Due to these immense challenges, StarCraft has emerged as a “grand challenge” for AI research. Ongoing competitions in both StarCraft and StarCraft II have assessed progress since the launch of the BroodWar API in 2009, including the AIIDE StarCraft AI Competition, CIG StarCraft Competition, Student StarCraft AI Tournament, and the Starcraft II AI Ladder. To help the community explore these problems further, we worked with Blizzard in 2016 and 2017 to release an open-source set of tools known as PySC2, including the largest set of anonymised game replays ever released. We have now built on this work, combining engineering and algorithmic breakthroughs to produce AlphaStar.", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8291), "Games have been used for decades as an important way to test and evaluate the performance of artificial intelligence systems..", "AlphaStar: Mastering the Real-Time Strategy Game StarCraft II", new DateTime(2020, 10, 19, 20, 27, 34, 547, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "UE");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "SQL");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "Singer");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "Music");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "Games");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "JS");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "CSS");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: ".Net");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "Java");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "Unity");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "c#");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "VR");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "AR");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "iOS");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "Android");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "HTML");

            migrationBuilder.InsertData(
                table: "Tags",
                column: "Name",
                value: "AI");

            migrationBuilder.InsertData(
                table: "BlogPostTags",
                columns: new[] { "BlogPostId", "TagId" },
                values: new object[] { "do-we-live-in-a-simulation", "AR" });

            migrationBuilder.InsertData(
                table: "BlogPostTags",
                columns: new[] { "BlogPostId", "TagId" },
                values: new object[] { "do-we-live-in-a-simulation", "VR" });

            migrationBuilder.InsertData(
                table: "BlogPostTags",
                columns: new[] { "BlogPostId", "TagId" },
                values: new object[] { "everything-we-know-cyberpunk-2077", "Games" });

            migrationBuilder.InsertData(
                table: "BlogPostTags",
                columns: new[] { "BlogPostId", "TagId" },
                values: new object[] { "flume-aussie-dj-producer-sex-act-burning-man-festival", "Music" });

            migrationBuilder.InsertData(
                table: "BlogPostTags",
                columns: new[] { "BlogPostId", "TagId" },
                values: new object[] { "flume-aussie-dj-producer-sex-act-burning-man-festival", "Singer" });

            migrationBuilder.InsertData(
                table: "BlogPostTags",
                columns: new[] { "BlogPostId", "TagId" },
                values: new object[] { "do-we-live-in-a-simulation", "AI" });

            migrationBuilder.InsertData(
                table: "BlogPostTags",
                columns: new[] { "BlogPostId", "TagId" },
                values: new object[] { "everything-we-know-cyberpunk-2077", "AI" });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostTags_TagId",
                table: "BlogPostTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostTags");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
