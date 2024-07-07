using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Amaral.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    ListPrice = table.Column<double>(type: "double precision", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Price50 = table.Column<double>(type: "double precision", nullable: false),
                    Price100 = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Kevin Hall", "Elara, a young warrior, must uncover her past and fight ancient darkness. In a world of myths and magic, she forges alliances to restore balance and save her realm.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Shadows of Eternity" },
                    { 2, "Sarah Davis", "When a reclusive artist becomes the sole witness to a murder, she must navigate a web of secrets and lies. As danger closes in, she discovers her art holds the key to unmasking the killer.", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "The Silent Witness" },
                    { 3, "Sarah Davis", "Haunted by eerie whispers, a troubled woman returns to her childhood home. As she uncovers buried secrets, she must confront her darkest fears to escape a malevolent force from her past.", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Whispers in the Dark" },
                    { 4, "Sarah Davis", "In the aftermath of war, a historian uncovers letters that reveal a forgotten love story. As she delves deeper, she finds parallels to her own life and must reconcile the past with the present.", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Echoes of the Past" },
                    { 5, "Steven Robinson", "Unlock your full potential with Creativity. This inspiring guide explores innovative techniques, exercises, and insights from successful creatives to help you ignite your imagination and transform your ideas into reality.", "JU458558999", 30.0, 27.0, 20.0, 25.0, "Creativity" },
                    { 6, "Nicole Martinez", "Join Liora, a young mage, on an epic quest to balance darkness and light in her war-torn realm. Facing mythical beasts and powerful sorcery, she discovers the true strength of her spirit and the magic within.", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "A Journey Through Shadows and Light" },
                    { 7, "Jennifer Young", "When a renowned journalist returns to her hometown, she uncovers long-buried emotions and a lost love. As she navigates past and present, she must decide if she’s willing to risk everything for a second chance at happiness.", "YOT000000968", 30.0, 27.0, 20.0, 25.0, "Secrets of the Heart" },
                    { 8, "Steven Robinson", "A daring astronaut leads a team on a groundbreaking mission to an uncharted planet. Facing alien landscapes and unknown dangers, they must rely on their wits and each other to survive and uncover the planet's secrets.", "ZA0000003336", 30.0, 27.0, 20.0, 25.0, "Journey to the Unknown" },
                    { 9, "Ashley Clark", "A woman suffering from amnesia pieces together her past after finding a series of cryptic journal entries. As she unravels the mystery, she discovers a shocking truth that could change her life forever.", "KL1111225879", 30.0, 27.0, 20.0, 25.0, "Fragments of Memory" },
                    { 10, "Andrew Garcia", "In a realm torn by war, a young warrior inherits a legacy of valor and betrayal. As she seeks redemption for her fallen kingdom, she must navigate treacherous alliances and unearth ancient secrets to restore peace and honor to her people.", "PO0006792444", 70.0, 65.0, 55.0, 60.0, "Legacy of the Fallen" },
                    { 11, "Laura White", "In a realm where magic is outlawed, a young sorcerer uncovers an ancient prophecy that could change the course of history. Pursued by dark forces, he must unravel the hidden truth to save his world from imminent destruction.", "WW9930000004", 70.0, 65.0, 55.0, 60.0, "The Hidden Truth" },
                    { 12, "Stephanie Walker", "In a dystopian future, humanity faces extinction due to a mysterious plague. A scientist discovers a controversial method to regenerate human tissue, but as the experiments progress, ethical dilemmas and unforeseen consequences threaten to unravel the fabric of society", "EOU330698744", 25.0, 23.0, 20.0, 22.0, "Flesh Start" },
                    { 13, "Brian Lewis", "Harmony Publishers chronicles the remarkable journey of one of the publishing industry's most influential houses. From its humble beginnings in a small office to becoming a powerhouse in literature, Harmony Publishers has consistently championed innovation, quality, and diversity in its catalog.", "AAD555878800", 55.0, 50.0, 35.0, 40.0, "Harmony Publishers" },
                    { 14, "Michael Brown", "In the twilight of the Middle Ages, a noblewoman finds herself betrothed to a mysterious knight tasked with defending the kingdom's last frontier. As they navigate courtly intrigue and battlefield dangers, their initial mistrust turns to reluctant admiration and, eventually, forbidden love amidst the turmoil of war and honor.", "UUT000000997", 25.0, 23.0, 20.0, 22.0, "The Last Frontier" },
                    { 15, "James Anderson", "In a realm where ancient dragons threaten the balance of power, a young guardian must rise to protect her people. With a mystical artifact as her only weapon, she embarks on a quest fraught with peril and betrayal. Alongside unlikely allies, she discovers her true destiny as the savior of her world.", "KAA007778958", 30.0, 27.0, 20.0, 25.0, "The Guardian" },
                    { 16, "James Anderson", "Amidst rising darkness, the guardian faces a new quest to uncover the lost secrets of an ancient prophecy. With allies old and new, she must navigate treacherous landscapes and confront formidable foes to safeguard her realm from impending doom.", "AC0002378377", 30.0, 27.0, 20.0, 25.0, "The Guardian II" },
                    { 17, "S S Monson", "In the competitive world of high-stakes corporate espionage, a brilliant hacker finds herself at the center of a dangerous game. As she uncovers a web of deceit and betrayal reaching the highest echelons of power, she must race against time to expose the truth and evade capture by ruthless adversaries.", "OOU000589600", 30.0, 27.0, 20.0, 25.0, "The Top" },
                    { 18, "Marissa Pullman", "In a bustling city, three young teachers embark on their careers, each facing unique challenges in the modern educational landscape. As they navigate classroom dynamics, bureaucratic hurdles, and personal growth, their passion for teaching and dedication to their students are put to the ultimate test.", "PPI500000014", 30.0, 27.0, 20.0, 25.0, "New Educators" },
                    { 19, "James Murdor", "Creative Business Your Own offers practical insights and strategies for aspiring entrepreneurs looking to launch and grow their own creative ventures. From crafting a unique brand identity to navigating digital marketing and fostering innovation, this guide equips readers with essential tools and inspiration to succeed in the competitive world of creative business", "LWS000069889", 55.0, 50.0, 35.0, 40.0, "Creative Business your Own" },
                    { 20, "Emma Mayers", "In a quaint seaside town, a charming mechanic known as The Bike Guy captures the heart of a free-spirited artist who has sworn off love. As they collaborate on restoring a classic motorcycle, sparks fly, revealing layers of vulnerability and passion beneath their initial friction. Together, they navigate past wounds and unexpected challenges, discovering that true love can be found where you least expect it.", "TTA000366947", 30.0, 27.0, 20.0, 25.0, "The Bike Guy" },
                    { 21, "Patricia Kim", "In a world where appearances are everything, a hapless photographer accidentally captures a series of hilarious celebrity mishaps on film. As the photos go viral, chaos ensues as everyone involved tries to save face and navigate the absurdities of fame, revealing that what looks good on paparazzi photos isn't always what it seems.", "PPP000069000", 55.0, 50.0, 35.0, 40.0, "Looks Good On Papar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
