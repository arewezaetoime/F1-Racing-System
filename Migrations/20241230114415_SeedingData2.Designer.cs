﻿// <auto-generated />
using System;
using F1_Racing_System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace F1RacingSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241230114415_SeedingData2")]
    partial class SeedingData2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("F1_Racing_System.Models.Domain.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Lewis",
                            LastName = "Hamilton",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Max",
                            LastName = "Verstappen",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Charles",
                            LastName = "Leclerc",
                            TeamId = 3
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Fernando",
                            LastName = "Alonso",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Lando",
                            LastName = "Norris",
                            TeamId = 4
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Sebastian",
                            LastName = "Vettel",
                            TeamId = 5
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Esteban",
                            LastName = "Ocon",
                            TeamId = 6
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Valtteri",
                            LastName = "Bottas",
                            TeamId = 7
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Mick",
                            LastName = "Schumacher",
                            TeamId = 8
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "George",
                            LastName = "Russell",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Nicholas",
                            LastName = "Latifi",
                            TeamId = 9
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "Pierre",
                            LastName = "Gasly",
                            TeamId = 6
                        });
                });

            modelBuilder.Entity("F1_Racing_System.Models.Domain.DriverRace", b =>
                {
                    b.Property<int>("DriverId")
                        .HasColumnType("integer");

                    b.Property<int>("RaceId")
                        .HasColumnType("integer");

                    b.Property<TimeSpan?>("FinishedFor")
                        .HasColumnType("interval");

                    b.Property<byte>("Points")
                        .HasColumnType("smallint");

                    b.HasKey("DriverId", "RaceId");

                    b.HasIndex("RaceId");

                    b.ToTable("DriverRaces");

                    b.HasData(
                        new
                        {
                            DriverId = 1,
                            RaceId = 1,
                            FinishedFor = new TimeSpan(0, 1, 18, 0, 0),
                            Points = (byte)25
                        },
                        new
                        {
                            DriverId = 2,
                            RaceId = 1,
                            FinishedFor = new TimeSpan(0, 1, 19, 0, 0),
                            Points = (byte)18
                        },
                        new
                        {
                            DriverId = 3,
                            RaceId = 1,
                            FinishedFor = new TimeSpan(0, 1, 20, 0, 0),
                            Points = (byte)15
                        },
                        new
                        {
                            DriverId = 4,
                            RaceId = 1,
                            FinishedFor = new TimeSpan(0, 1, 21, 0, 0),
                            Points = (byte)12
                        },
                        new
                        {
                            DriverId = 5,
                            RaceId = 1,
                            FinishedFor = new TimeSpan(0, 1, 22, 0, 0),
                            Points = (byte)10
                        },
                        new
                        {
                            DriverId = 6,
                            RaceId = 2,
                            FinishedFor = new TimeSpan(0, 1, 30, 0, 0),
                            Points = (byte)18
                        },
                        new
                        {
                            DriverId = 7,
                            RaceId = 2,
                            FinishedFor = new TimeSpan(0, 1, 32, 0, 0),
                            Points = (byte)15
                        },
                        new
                        {
                            DriverId = 8,
                            RaceId = 2,
                            FinishedFor = new TimeSpan(0, 1, 33, 0, 0),
                            Points = (byte)10
                        },
                        new
                        {
                            DriverId = 9,
                            RaceId = 2,
                            FinishedFor = new TimeSpan(0, 1, 34, 0, 0),
                            Points = (byte)8
                        },
                        new
                        {
                            DriverId = 10,
                            RaceId = 2,
                            FinishedFor = new TimeSpan(0, 1, 35, 0, 0),
                            Points = (byte)6
                        },
                        new
                        {
                            DriverId = 1,
                            RaceId = 3,
                            FinishedFor = new TimeSpan(0, 1, 40, 0, 0),
                            Points = (byte)25
                        },
                        new
                        {
                            DriverId = 2,
                            RaceId = 3,
                            FinishedFor = new TimeSpan(0, 1, 42, 0, 0),
                            Points = (byte)18
                        },
                        new
                        {
                            DriverId = 3,
                            RaceId = 3,
                            FinishedFor = new TimeSpan(0, 1, 44, 0, 0),
                            Points = (byte)15
                        },
                        new
                        {
                            DriverId = 4,
                            RaceId = 3,
                            FinishedFor = new TimeSpan(0, 1, 46, 0, 0),
                            Points = (byte)12
                        });
                });

            modelBuilder.Entity("F1_Racing_System.Models.Domain.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("Races");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Monaco Grand Prix"
                        },
                        new
                        {
                            Id = 2,
                            Name = "British Grand Prix"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Italian Grand Prix"
                        },
                        new
                        {
                            Id = 4,
                            Name = "German Grand Prix"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Spanish Grand Prix"
                        });
                });

            modelBuilder.Entity("F1_Racing_System.Models.Domain.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mercedes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Red Bull"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ferrari"
                        },
                        new
                        {
                            Id = 4,
                            Name = "McLaren"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Aston Martin"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Alpine"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Alfa Romeo"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Haas"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Williams"
                        });
                });

            modelBuilder.Entity("F1_Racing_System.Models.Domain.Driver", b =>
                {
                    b.HasOne("F1_Racing_System.Models.Domain.Team", "Team")
                        .WithMany("Drivers")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("F1_Racing_System.Models.Domain.DriverRace", b =>
                {
                    b.HasOne("F1_Racing_System.Models.Domain.Driver", "Driver")
                        .WithMany("DriverRaces")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("F1_Racing_System.Models.Domain.Race", "Race")
                        .WithMany("DriverRaces")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("F1_Racing_System.Models.Domain.Driver", b =>
                {
                    b.Navigation("DriverRaces");
                });

            modelBuilder.Entity("F1_Racing_System.Models.Domain.Race", b =>
                {
                    b.Navigation("DriverRaces");
                });

            modelBuilder.Entity("F1_Racing_System.Models.Domain.Team", b =>
                {
                    b.Navigation("Drivers");
                });
#pragma warning restore 612, 618
        }
    }
}
