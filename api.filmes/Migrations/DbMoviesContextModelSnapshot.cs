﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api.filmes.DataContext;

namespace api.filmes.Migrations
{
    [DbContext(typeof(DbMoviesContext))]
    partial class DbMoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("api.filmes.Models.Genres", b =>
                {
                    b.Property<int>("genreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("genreName")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("genreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("api.filmes.Models.Movies", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ano_lancamento")
                        .HasColumnType("integer")
                        .HasMaxLength(255);

                    b.Property<string>("classificacao")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<int>("genresId")
                        .HasColumnType("integer");

                    b.Property<string>("imagem")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("nome")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("slogan")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("visaoGeral")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("movieId");

                    b.HasIndex("genresId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("api.filmes.Models.Users", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("email")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("api.filmes.Models.Movies", b =>
                {
                    b.HasOne("api.filmes.Models.Genres", "genres")
                        .WithMany()
                        .HasForeignKey("genresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
