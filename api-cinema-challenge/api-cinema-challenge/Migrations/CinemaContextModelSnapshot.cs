﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("id");

                    b.ToTable("customer");

                    b.HasData(
                        new
                        {
                            id = 1,
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            email = "katepresley@bbc.co.uk",
                            name = "Kate Presley",
                            phone = "+46888888888",
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            id = 2,
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            email = "donaldhepburn@something.com",
                            name = "Donald Hepburn",
                            phone = "+46123456789",
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            id = 3,
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            email = "kateobama@nasa.org.us",
                            name = "Kate Obama",
                            phone = "+46987654321",
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            id = 4,
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            email = "katehendrix@theworld.ca",
                            name = "Kate Hendrix",
                            phone = "+46987654321",
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_description");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("creatd_at");

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_rating");

                    b.Property<int>("runtimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("runtime_in_minutes");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("id");

                    b.ToTable("movie");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Description = "Fifteen Purple Buildings",
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            rating = "R",
                            runtimeMins = 15,
                            title = "Two Transparent Planets",
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            id = 2,
                            Description = "A herd of Green Cars",
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            rating = "PG-3",
                            runtimeMins = 30,
                            title = "Fifteen Green Houses",
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            id = 3,
                            Description = "An army of Large Flowers",
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            rating = "NC-17",
                            runtimeMins = 45,
                            title = "Fifteen Large Cars",
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            id = 4,
                            Description = "A bunch of Purple Houses",
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            rating = "PG-13",
                            runtimeMins = 60,
                            title = "A herd of Orange Houses",
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("movieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.Property<int>("screenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_number");

                    b.Property<DateTime>("startsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("id");

                    b.ToTable("screening");

                    b.HasData(
                        new
                        {
                            id = 1,
                            capacity = 40,
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            movieId = 0,
                            screenNumber = 2,
                            startsAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            id = 2,
                            capacity = 40,
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            movieId = 2,
                            screenNumber = 1,
                            startsAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            id = 3,
                            capacity = 40,
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            movieId = 0,
                            screenNumber = 2,
                            startsAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            id = 4,
                            capacity = 40,
                            createdAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            movieId = 2,
                            screenNumber = 1,
                            startsAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            updatedAt = new DateTime(2024, 2, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
