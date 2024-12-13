using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Amaral.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Books full of excitement and adventure.", "Action" },
                    { 2, "Science fiction books exploring futuristic concepts.", "SciFi" },
                    { 3, "Books delving into historical events and figures.", "History" },
                    { 4, "Stories involving exciting and risky experiences.", "Adventure" },
                    { 5, "Works featuring magical or supernatural elements, often set in imaginary worlds.", "Fantasy" },
                    { 6, "Stories designed to provoke excitement and suspense.", "Thriller" },
                    { 7, "Fiction intended to scare, unsettle, or horrify the reader.", "Horror" },
                    { 8, "Focuses on romantic relationships between characters.", "Romance" },
                    { 9, "A detailed description of a person's life.", "Biography" },
                    { 10, "Light-hearted stories designed to amuse and entertain.", "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Chicago", "Tech Solution", "6669990000", "60606", "IL", "123 N Wacker Dr" },
                    { 2, "New York", "Vivid Books", "7779990000", "10010", "NY", "10 E 21st St" },
                    { 3, "San Francisco", "Readers Club", "1113335555", "94103", "CA", "125 3rd St" },
                    { 4, "Los Angeles", "Creative Minds", "2225557777", "90013", "CA", "456 S Main St" },
                    { 5, "Austin", "HealthPlus", "3336668888", "78701", "TX", "789 Congress Ave" },
                    { 6, "Tampa", "EduWorld", "4447779999", "33602", "FL", "321 E Kennedy Blvd" },
                    { 7, "Seattle", "EcoGreen", "5558881111", "98109", "WA", "654 Dexter Ave N" },
                    { 8, "Boulder", "Tech Innovators", "6669992222", "80302", "CO", "987 Walnut St" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Kevin Hall", 5, "Elara, a young warrior, must uncover her past and fight ancient darkness. In a world of myths and magic, she forges alliances to restore balance and save her realm.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Shadows of Eternity" },
                    { 2, "Sarah Davis", 6, "When a reclusive artist becomes the sole witness to a murder, she must navigate a web of secrets and lies. As danger closes in, she discovers her art holds the key to unmasking the killer.", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "The Silent Witness" },
                    { 3, "Sarah Davis", 6, "Haunted by eerie whispers, a troubled woman returns to her childhood home. As she uncovers buried secrets, she must confront her darkest fears to escape a malevolent force from her past.", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Whispers in the Dark" },
                    { 4, "Sarah Davis", 8, "In the aftermath of war, a historian uncovers letters that reveal a forgotten love story. As she delves deeper, she finds parallels to her own life and must reconcile the past with the present.", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Echoes of the Past" },
                    { 5, "Steven Robinson", 3, "Unlock your full potential with Creativity. This inspiring guide explores innovative techniques, exercises, and insights from successful creatives to help you ignite your imagination and transform your ideas into reality.", "JU458558999", 30.0, 27.0, 20.0, 25.0, "Creativity" },
                    { 6, "Nicole Martinez", 4, "Join Liora, a young mage, on an epic quest to balance darkness and light in her war-torn realm. Facing mythical beasts and powerful sorcery, she discovers the true strength of her spirit and the magic within.", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "A Journey Through Shadows and Light" },
                    { 7, "Jennifer Young", 8, "When a renowned journalist returns to her hometown, she uncovers long-buried emotions and a lost love. As she navigates past and present, she must decide if she’s willing to risk everything for a second chance at happiness.", "YOT000000968", 30.0, 27.0, 20.0, 25.0, "Secrets of the Heart" },
                    { 8, "Steven Robinson", 2, "A daring astronaut leads a team on a groundbreaking mission to an uncharted planet. Facing alien landscapes and unknown dangers, they must rely on their wits and each other to survive and uncover the planet's secrets.", "ZA0000003336", 30.0, 27.0, 20.0, 25.0, "Journey to the Unknown" },
                    { 9, "Ashley Clark", 6, "A woman suffering from amnesia pieces together her past after finding a series of cryptic journal entries. As she unravels the mystery, she discovers a shocking truth that could change her life forever.", "KL1111225879", 30.0, 27.0, 20.0, 25.0, "Fragments of Memory" },
                    { 10, "Andrew Garcia", 5, "In a realm torn by war, a young warrior inherits a legacy of valor and betrayal. As she seeks redemption for her fallen kingdom, she must navigate treacherous alliances and unearth ancient secrets to restore peace and honor to her people.", "PO0006792444", 70.0, 65.0, 55.0, 60.0, "Legacy of the Fallen" },
                    { 11, "Laura White", 5, "In a realm where magic is outlawed, a young sorcerer uncovers an ancient prophecy that could change the course of history. Pursued by dark forces, he must unravel the hidden truth to save his world from imminent destruction.", "WW9930000004", 70.0, 65.0, 55.0, 60.0, "The Hidden Truth" },
                    { 12, "Stephanie Walker", 2, "In a dystopian future, humanity faces extinction due to a mysterious plague. A scientist discovers a controversial method to regenerate human tissue, but as the experiments progress, ethical dilemmas and unforeseen consequences threaten to unravel the fabric of society", "EOU330698744", 25.0, 23.0, 20.0, 22.0, "Fresh Start" },
                    { 13, "Brian Lewis", 9, "Harmony Publishers chronicles the remarkable journey of one of the publishing industry's most influential houses. From its humble beginnings in a small office to becoming a powerhouse in literature, Harmony Publishers has consistently championed innovation, quality, and diversity in its catalog.", "AAD555878800", 55.0, 50.0, 35.0, 40.0, "Harmony Publishers" },
                    { 14, "Michael Brown", 8, "In the twilight of the Middle Ages, a noblewoman finds herself betrothed to a mysterious knight tasked with defending the kingdom's last frontier. As they navigate courtly intrigue and battlefield dangers, their initial mistrust turns to reluctant admiration and, eventually, forbidden love amidst the turmoil of war and honor.", "UUT000000997", 25.0, 23.0, 20.0, 22.0, "The Last Frontier" },
                    { 15, "James Anderson", 4, "In a realm where ancient dragons threaten the balance of power, a young guardian must rise to protect her people. With a mystical artifact as her only weapon, she embarks on a quest fraught with peril and betrayal. Alongside unlikely allies, she discovers her true destiny as the savior of her world.", "KAA007778958", 30.0, 27.0, 20.0, 25.0, "The Guardian" },
                    { 16, "James Anderson", 4, "Amidst rising darkness, the guardian faces a new quest to uncover the lost secrets of an ancient prophecy. With allies old and new, she must navigate treacherous landscapes and confront formidable foes to safeguard her realm from impending doom.", "AC0002378377", 30.0, 27.0, 20.0, 25.0, "The Guardian II" },
                    { 17, "S S Monson", 6, "In the competitive world of high-stakes corporate espionage, a brilliant hacker finds herself at the center of a dangerous game. As she uncovers a web of deceit and betrayal reaching the highest echelons of power, she must race against time to expose the truth and evade capture by ruthless adversaries.", "OOU000589600", 30.0, 27.0, 20.0, 25.0, "The Top" },
                    { 18, "Marissa Pullman", 2, "In a bustling city, three young teachers embark on their careers, each facing unique challenges in the modern educational landscape. As they navigate classroom dynamics, bureaucratic hurdles, and personal growth, their passion for teaching and dedication to their students are put to the ultimate test.", "PPI500000014", 30.0, 27.0, 20.0, 25.0, "New Educators" },
                    { 19, "James Murdor", 3, "Creative Business Your Own offers practical insights and strategies for aspiring entrepreneurs looking to launch and grow their own creative ventures. From crafting a unique brand identity to navigating digital marketing and fostering innovation, this guide equips readers with essential tools and inspiration to succeed in the competitive world of creative business", "LWS000069889", 55.0, 50.0, 35.0, 40.0, "Creative Business your Own" },
                    { 20, "Emma Mayers", 10, "In a quaint seaside town, a charming mechanic known as The Bike Guy captures the heart of a free-spirited artist who has sworn off love. As they collaborate on restoring a classic motorcycle, sparks fly, revealing layers of vulnerability and passion beneath their initial friction. Together, they navigate past wounds and unexpected challenges, discovering that true love can be found where you least expect it.", "TTA000366947", 30.0, 27.0, 20.0, 25.0, "The Bike Guy" },
                    { 21, "Patricia Kim", 10, "In a world where appearances are everything, a hapless photographer accidentally captures a series of hilarious celebrity mishaps on film. As the photos go viral, chaos ensues as everyone involved tries to save face and navigate the absurdities of fame, revealing that what looks good on paparazzi photos isn't always what it seems.", "PPP000069000", 55.0, 50.0, 35.0, 40.0, "Looks Good On Papar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
