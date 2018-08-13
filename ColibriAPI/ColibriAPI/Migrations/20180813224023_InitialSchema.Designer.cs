﻿// <auto-generated />
using ColibriAPI.DataAccess;
using ColibriAPI.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ColibriAPI.Migrations
{
    [DbContext(typeof(ColibriApiContext))]
    [Migration("20180813224023_InitialSchema")]
    partial class InitialSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("ColibriAPI.Models.Entities.Entry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByUser");

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<DateTimeOffset?>("DateDeleted");

                    b.Property<DateTimeOffset?>("DateUpdated");

                    b.Property<string>("DeletedByUser");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid?>("TeamId");

                    b.Property<Guid?>("TournamentId");

                    b.Property<string>("UpdatedByUser");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("TournamentId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("ColibriAPI.Models.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByUser");

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<DateTimeOffset?>("DateDeleted");

                    b.Property<DateTimeOffset?>("DateUpdated");

                    b.Property<string>("DeletedByUser");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("PlayDate");

                    b.Property<int>("TournamentStage");

                    b.Property<string>("UpdatedByUser");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("ColibriAPI.Models.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByUser");

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<DateTimeOffset?>("DateDeleted");

                    b.Property<DateTimeOffset?>("DateUpdated");

                    b.Property<string>("DeletedByUser");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("PlayerIdentifier");

                    b.Property<string>("PlayerTag");

                    b.Property<Guid?>("RosterId");

                    b.Property<Guid?>("TeamId");

                    b.Property<string>("UpdatedByUser");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RosterId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ColibriAPI.Models.Entities.Roster", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByUser");

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<DateTimeOffset?>("DateDeleted");

                    b.Property<DateTimeOffset?>("DateUpdated");

                    b.Property<string>("DeletedByUser");

                    b.Property<Guid?>("GameId");

                    b.Property<bool>("IsDeleted");

                    b.Property<Guid?>("TeamId");

                    b.Property<Guid?>("TournamentId");

                    b.Property<string>("UpdatedByUser");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("TeamId");

                    b.HasIndex("TournamentId");

                    b.ToTable("Rosters");
                });

            modelBuilder.Entity("ColibriAPI.Models.Entities.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByUser");

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<DateTimeOffset?>("DateDeleted");

                    b.Property<DateTimeOffset?>("DateUpdated");

                    b.Property<string>("DeletedByUser");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<string>("UpdatedByUser");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("ColibriAPI.Models.Entities.Tournament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByUser");

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<DateTimeOffset?>("DateDeleted");

                    b.Property<DateTimeOffset?>("DateUpdated");

                    b.Property<string>("DeletedByUser");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("UpdatedByUser");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("ColibriAPI.Models.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("CreatedByUser");

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<DateTimeOffset?>("DateDeleted");

                    b.Property<DateTimeOffset?>("DateUpdated");

                    b.Property<string>("DeletedByUser");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsOrganizer");

                    b.Property<bool>("IsPlayer");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Password");

                    b.Property<Guid>("PasswordSalt");

                    b.Property<string>("UpdatedByUser");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ColibriAPI.Models.Entities.Entry", b =>
                {
                    b.HasOne("ColibriAPI.Models.Entities.Team", "Team")
                        .WithMany("Entries")
                        .HasForeignKey("TeamId");

                    b.HasOne("ColibriAPI.Models.Entities.Tournament", "Tournament")
                        .WithMany()
                        .HasForeignKey("TournamentId");
                });

            modelBuilder.Entity("ColibriAPI.Models.Entities.Player", b =>
                {
                    b.HasOne("ColibriAPI.Models.Entities.Roster")
                        .WithMany("RosterPlayers")
                        .HasForeignKey("RosterId");

                    b.HasOne("ColibriAPI.Models.Entities.Team")
                        .WithMany("TeamPlayers")
                        .HasForeignKey("TeamId");

                    b.HasOne("ColibriAPI.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ColibriAPI.Models.Entities.Roster", b =>
                {
                    b.HasOne("ColibriAPI.Models.Entities.Game", "Game")
                        .WithMany("Rosters")
                        .HasForeignKey("GameId");

                    b.HasOne("ColibriAPI.Models.Entities.Team", "Team")
                        .WithMany("Rosters")
                        .HasForeignKey("TeamId");

                    b.HasOne("ColibriAPI.Models.Entities.Tournament", "Tournament")
                        .WithMany()
                        .HasForeignKey("TournamentId");
                });
#pragma warning restore 612, 618
        }
    }
}
