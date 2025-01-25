﻿// <auto-generated />
using CodingLanguages.API.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodingLanguages.API.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodingLanguages.API.Model.Language", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("language");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Category = "CODING LANGUAGE",
                            Description = "A modern, object-oriented programming language widely used for building Windows applications, web services, and game development with Unity.",
                            ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/csharp.png?raw=true",
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2L,
                            Category = "CODING LANGUAGE",
                            Description = "A versatile, high-level programming language known for its readability and wide application in data science, web development, and automation.",
                            ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/python.png?raw=true",
                            Name = "Python"
                        },
                        new
                        {
                            Id = 3L,
                            Category = "CODING LANGUAGE",
                            Description = "A dynamic, object-oriented language popular for web development, especially with the Ruby on Rails framework.",
                            ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/ruby.png?raw=true",
                            Name = "Ruby"
                        },
                        new
                        {
                            Id = 4L,
                            Category = "CODING LANGUAGE",
                            Description = "A server-side scripting language designed for building dynamic web pages and backend services.",
                            ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/php.png?raw=true",
                            Name = "PHP"
                        },
                        new
                        {
                            Id = 5L,
                            Category = "CODING LANGUAGE",
                            Description = "The standard markup language used for structuring and displaying content on the web.",
                            ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/html.png?raw=true",
                            Name = "HTML"
                        },
                        new
                        {
                            Id = 6L,
                            Category = "CODING LANGUAGE",
                            Description = "A style sheet language used to control the appearance and layout of web pages.",
                            ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/css.png?raw=true",
                            Name = "CSS"
                        },
                        new
                        {
                            Id = 7L,
                            Category = "CODING LANGUAGE",
                            Description = " A statically typed, compiled language by Google, built for performance and scalability in modern applications.",
                            ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/go.png?raw=true",
                            Name = "Go"
                        },
                        new
                        {
                            Id = 8L,
                            Category = "CODING LANGUAGE",
                            Description = "A modern, JVM-compatible language designed for Android development and cross-platform applications.",
                            ImageUrl = "https://github.com/RafaelGuerraE/CodingLanguagesProject/blob/master/Languages/kotlin.png?raw=true",
                            Name = "Kotlin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}