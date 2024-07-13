using Amaral.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Amaral.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<OrderHeader> OrderHeaders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Action", Description = "Books full of excitement and adventure." },
               new Category { Id = 2, Name = "SciFi", Description = "Science fiction books exploring futuristic concepts." },
               new Category { Id = 3, Name = "History", Description = "Books delving into historical events and figures." },
               new Category { Id = 4, Name = "Adventure", Description = "Stories involving exciting and risky experiences." },
               new Category { Id = 5, Name = "Fantasy", Description = "Works featuring magical or supernatural elements, often set in imaginary worlds." },
               new Category { Id = 6, Name = "Thriller", Description = "Stories designed to provoke excitement and suspense." },
               new Category { Id = 7, Name = "Horror", Description = "Fiction intended to scare, unsettle, or horrify the reader." },
               new Category { Id = 8, Name = "Romance", Description = "Focuses on romantic relationships between characters." },
               new Category { Id = 9, Name = "Biography", Description = "A detailed description of a person's life." },
               new Category { Id = 10, Name = "Comedy", Description = "Light-hearted stories designed to amuse and entertain." }
               );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Tech Solution",
                    StreetAddress = "123 N Wacker Dr",
                    City = "Chicago",
                    PostalCode = "60606",
                    State = "IL",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Vivid Books",
                    StreetAddress = "10 E 21st St",
                    City = "New York",
                    PostalCode = "10010",
                    State = "NY",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "Readers Club",
                    StreetAddress = "125 3rd St",
                    City = "San Francisco",
                    PostalCode = "94103",
                    State = "CA",
                    PhoneNumber = "1113335555"
                },
                new Company
                {
                    Id = 4,
                    Name = "Creative Minds",
                    StreetAddress = "456 S Main St",
                    City = "Los Angeles",
                    PostalCode = "90013",
                    State = "CA",
                    PhoneNumber = "2225557777"
                },
                new Company
                {
                    Id = 5,
                    Name = "HealthPlus",
                    StreetAddress = "789 Congress Ave",
                    City = "Austin",
                    PostalCode = "78701",
                    State = "TX",
                    PhoneNumber = "3336668888"
                },
                new Company
                {
                    Id = 6,
                    Name = "EduWorld",
                    StreetAddress = "321 E Kennedy Blvd",
                    City = "Tampa",
                    PostalCode = "33602",
                    State = "FL",
                    PhoneNumber = "4447779999"
                },
                new Company
                {
                    Id = 7,
                    Name = "EcoGreen",
                    StreetAddress = "654 Dexter Ave N",
                    City = "Seattle",
                    PostalCode = "98109",
                    State = "WA",
                    PhoneNumber = "5558881111"
                },
                new Company
                {
                    Id = 8,
                    Name = "Tech Innovators",
                    StreetAddress = "987 Walnut St",
                    City = "Boulder",
                    PostalCode = "80302",
                    State = "CO",
                    PhoneNumber = "6669992222"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Shadows of Eternity",
                    Author = "Kevin Hall",
                    Description = "Elara, a young warrior, must uncover her past and fight ancient darkness. In a world of myths and magic, she forges alliances to restore balance and save her realm.",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "The Silent Witness",
                    Author = "Sarah Davis",
                    Description = "When a reclusive artist becomes the sole witness to a murder, she must navigate a web of secrets and lies. As danger closes in, she discovers her art holds the key to unmasking the killer.",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Whispers in the Dark",
                    Author = "Sarah Davis",
                    Description = "Haunted by eerie whispers, a troubled woman returns to her childhood home. As she uncovers buried secrets, she must confront her darkest fears to escape a malevolent force from her past.",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Echoes of the Past",
                    Author = "Sarah Davis",
                    Description = "In the aftermath of war, a historian uncovers letters that reveal a forgotten love story. As she delves deeper, she finds parallels to her own life and must reconcile the past with the present.",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Creativity",
                    Author = "Steven Robinson",
                    Description = "Unlock your full potential with Creativity. This inspiring guide explores innovative techniques, exercises, and insights from successful creatives to help you ignite your imagination and transform your ideas into reality.",
                    ISBN = "JU458558999",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "A Journey Through Shadows and Light",
                    Author = "Nicole Martinez",
                    Description = "Join Liora, a young mage, on an epic quest to balance darkness and light in her war-torn realm. Facing mythical beasts and powerful sorcery, she discovers the true strength of her spirit and the magic within.",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 7,
                    Title = "Secrets of the Heart",
                    Author = "Jennifer Young",
                    Description = "When a renowned journalist returns to her hometown, she uncovers long-buried emotions and a lost love. As she navigates past and present, she must decide if she’s willing to risk everything for a second chance at happiness.",
                    ISBN = "YOT000000968",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 8,
                    Title = "Journey to the Unknown",
                    Author = "Steven Robinson",
                    Description = "A daring astronaut leads a team on a groundbreaking mission to an uncharted planet. Facing alien landscapes and unknown dangers, they must rely on their wits and each other to survive and uncover the planet's secrets.",
                    ISBN = "ZA0000003336",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 9,
                    Title = "Fragments of Memory",
                    Author = "Ashley Clark",
                    Description = "A woman suffering from amnesia pieces together her past after finding a series of cryptic journal entries. As she unravels the mystery, she discovers a shocking truth that could change her life forever.",
                    ISBN = "KL1111225879",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 10,
                    Title = "Legacy of the Fallen",
                    Author = "Andrew Garcia",
                    Description = "In a realm torn by war, a young warrior inherits a legacy of valor and betrayal. As she seeks redemption for her fallen kingdom, she must navigate treacherous alliances and unearth ancient secrets to restore peace and honor to her people.",
                    ISBN = "PO0006792444",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 11,
                    Title = "The Hidden Truth",
                    Author = "Laura White",
                    Description = "In a realm where magic is outlawed, a young sorcerer uncovers an ancient prophecy that could change the course of history. Pursued by dark forces, he must unravel the hidden truth to save his world from imminent destruction.",
                    ISBN = "WW9930000004",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 12,
                    Title = "Fresh Start",
                    Author = "Stephanie Walker",
                    Description = "In a dystopian future, humanity faces extinction due to a mysterious plague. A scientist discovers a controversial method to regenerate human tissue, but as the experiments progress, ethical dilemmas and unforeseen consequences threaten to unravel the fabric of society",
                    ISBN = "EOU330698744",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 13,
                    Title = "Harmony Publishers",
                    Author = "Brian Lewis",
                    Description = "Harmony Publishers chronicles the remarkable journey of one of the publishing industry's most influential houses. From its humble beginnings in a small office to becoming a powerhouse in literature, Harmony Publishers has consistently championed innovation, quality, and diversity in its catalog.",
                    ISBN = "AAD555878800",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 9,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 14,
                    Title = "The Last Frontier",
                    Author = "Michael Brown",
                    Description = "In the twilight of the Middle Ages, a noblewoman finds herself betrothed to a mysterious knight tasked with defending the kingdom's last frontier. As they navigate courtly intrigue and battlefield dangers, their initial mistrust turns to reluctant admiration and, eventually, forbidden love amidst the turmoil of war and honor.",
                    ISBN = "UUT000000997",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 15,
                    Title = "The Guardian",
                    Author = "James Anderson",
                    Description = "In a realm where ancient dragons threaten the balance of power, a young guardian must rise to protect her people. With a mystical artifact as her only weapon, she embarks on a quest fraught with peril and betrayal. Alongside unlikely allies, she discovers her true destiny as the savior of her world.",
                    ISBN = "KAA007778958",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 16,
                    Title = "The Guardian II",
                    Author = "James Anderson",
                    Description = "Amidst rising darkness, the guardian faces a new quest to uncover the lost secrets of an ancient prophecy. With allies old and new, she must navigate treacherous landscapes and confront formidable foes to safeguard her realm from impending doom.",
                    ISBN = "AC0002378377",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 17,
                    Title = "The Top",
                    Author = "S S Monson",
                    Description = "In the competitive world of high-stakes corporate espionage, a brilliant hacker finds herself at the center of a dangerous game. As she uncovers a web of deceit and betrayal reaching the highest echelons of power, she must race against time to expose the truth and evade capture by ruthless adversaries.",
                    ISBN = "OOU000589600",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 18,
                    Title = "New Educators",
                    Author = "Marissa Pullman",
                    Description = "In a bustling city, three young teachers embark on their careers, each facing unique challenges in the modern educational landscape. As they navigate classroom dynamics, bureaucratic hurdles, and personal growth, their passion for teaching and dedication to their students are put to the ultimate test.",
                    ISBN = "PPI500000014",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 19,
                    Title = "Creative Business your Own",
                    Author = "James Murdor",
                    Description = "Creative Business Your Own offers practical insights and strategies for aspiring entrepreneurs looking to launch and grow their own creative ventures. From crafting a unique brand identity to navigating digital marketing and fostering innovation, this guide equips readers with essential tools and inspiration to succeed in the competitive world of creative business",
                    ISBN = "LWS000069889",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 20,
                    Title = "The Bike Guy",
                    Author = "Emma Mayers",
                    Description = "In a quaint seaside town, a charming mechanic known as The Bike Guy captures the heart of a free-spirited artist who has sworn off love. As they collaborate on restoring a classic motorcycle, sparks fly, revealing layers of vulnerability and passion beneath their initial friction. Together, they navigate past wounds and unexpected challenges, discovering that true love can be found where you least expect it.",
                    ISBN = "TTA000366947",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 10,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 21,
                    Title = "Looks Good On Papar",
                    Author = "Patricia Kim",
                    Description = "In a world where appearances are everything, a hapless photographer accidentally captures a series of hilarious celebrity mishaps on film. As the photos go viral, chaos ensues as everyone involved tries to save face and navigate the absurdities of fame, revealing that what looks good on paparazzi photos isn't always what it seems.",
                    ISBN = "PPP000069000",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 10,
                    ImageUrl = ""
                }
                );
        }
    }
}
