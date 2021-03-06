// <auto-generated />
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    partial class MessageBoardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Topic")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            Content = "JarJar Binks is a Sith Lord",
                            Topic = "Starwars"
                        },
                        new
                        {
                            MessageId = 2,
                            Content = "Liam Neeson is the greatest Jedi",
                            Topic = "Starwars"
                        },
                        new
                        {
                            MessageId = 3,
                            Content = "Tumblr is the perfect anti capitalist social media site because the user base is basically impossible to advertise to",
                            Topic = "Social Media"
                        },
                        new
                        {
                            MessageId = 4,
                            Content = "Animalitos are CUTE",
                            Topic = "Animals"
                        },
                        new
                        {
                            MessageId = 5,
                            Content = "Animalitos are NOT cute. #cancelled",
                            Topic = "Animals"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
