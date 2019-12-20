﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetfirst.Data;

namespace aspnetfirst.Migrations
{
    [DbContext(typeof(BetContext))]
    [Migration("20191220162854_allok")]
    partial class allok
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "105765f0-88cb-42b6-a129-f49b5ca1f555",
                            ConcurrencyStamp = "8d28c1c7-2cfc-4693-900a-c44c652c97a3",
                            Name = "admin"
                        },
                        new
                        {
                            Id = "5be16200-5839-4ebc-8fa6-8e2df864c7d6",
                            ConcurrencyStamp = "7e092982-e457-469d-ab38-e90478f68579",
                            Name = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("aspnetfirst.Models.Coach", b =>
                {
                    b.Property<int>("CoachId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoachName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rate")
                        .HasColumnType("INTEGER");

                    b.HasKey("CoachId");

                    b.ToTable("Coach");

                    b.HasData(
                        new
                        {
                            CoachId = 1,
                            CoachName = "Juze",
                            Rate = 95
                        },
                        new
                        {
                            CoachId = 2,
                            CoachName = "Morris",
                            Rate = 88
                        },
                        new
                        {
                            CoachId = 3,
                            CoachName = "Philippo",
                            Rate = 96
                        });
                });

            modelBuilder.Entity("aspnetfirst.Models.League", b =>
                {
                    b.Property<int>("LeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LeaugueName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LeagueId");

                    b.ToTable("League");

                    b.HasData(
                        new
                        {
                            LeagueId = 1,
                            LeaugueName = "Italy"
                        },
                        new
                        {
                            LeagueId = 2,
                            LeaugueName = "Spain"
                        });
                });

            modelBuilder.Entity("aspnetfirst.Models.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Team_guestId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Team_homeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MatchId");

                    b.HasIndex("Team_guestId");

                    b.HasIndex("Team_homeId");

                    b.ToTable("Match");

                    b.HasData(
                        new
                        {
                            MatchId = 1,
                            Team_guestId = 2,
                            Team_homeId = 1
                        },
                        new
                        {
                            MatchId = 2,
                            Team_guestId = 1,
                            Team_homeId = 3
                        });
                });

            modelBuilder.Entity("aspnetfirst.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Deffence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Offence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayerName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            Deffence = 48,
                            Offence = 95,
                            PlayerName = "Ronaldo",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 2,
                            Deffence = 56,
                            Offence = 85,
                            PlayerName = "Kaka",
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("aspnetfirst.Models.ScoreStatistic", b =>
                {
                    b.Property<int>("ScoreStatisticId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Numberofpenalty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Numberofredcard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberofyellowCard")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Score")
                        .HasColumnType("TEXT");

                    b.HasKey("ScoreStatisticId");

                    b.HasIndex("MatchId")
                        .IsUnique();

                    b.ToTable("ScoreStatistic");

                    b.HasData(
                        new
                        {
                            ScoreStatisticId = 1,
                            MatchId = 1,
                            Numberofpenalty = 13,
                            Numberofredcard = 3,
                            NumberofyellowCard = 5,
                            Score = "2-0"
                        },
                        new
                        {
                            ScoreStatisticId = 2,
                            MatchId = 2,
                            Numberofpenalty = 15,
                            Numberofredcard = 2,
                            NumberofyellowCard = 6,
                            Score = "3-2"
                        });
                });

            modelBuilder.Entity("aspnetfirst.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CoachId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LeagueId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamRate")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeamId");

                    b.HasIndex("LeagueId");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            CoachId = 1,
                            LeagueId = 1,
                            TeamName = "Juventus",
                            TeamRate = 98
                        },
                        new
                        {
                            TeamId = 2,
                            CoachId = 2,
                            LeagueId = 1,
                            TeamName = "Milan",
                            TeamRate = 85
                        },
                        new
                        {
                            TeamId = 3,
                            CoachId = 3,
                            LeagueId = 1,
                            TeamName = "Inter",
                            TeamRate = 78
                        });
                });

            modelBuilder.Entity("aspnetfirst.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("UserPassword")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "61524aa9-2ea5-49d5-923e-8a8daa14acf8",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            Points = 100,
                            SecurityStamp = "b484ec93-36f7-4ec1-b250-193c5a5c95cb",
                            TwoFactorEnabled = false,
                            UserName = "Ali",
                            UserPassword = "AliPass"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "91ccc84d-9e48-497b-a0c7-b5d40dc4eb09",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            Points = 80,
                            SecurityStamp = "5d1c2bc7-4254-441c-98fb-d3e78b3e255f",
                            TwoFactorEnabled = false,
                            UserName = "Dias",
                            UserPassword = "seniorhacka"
                        });
                });

            modelBuilder.Entity("aspnetfirst.Models.UserMatch", b =>
                {
                    b.Property<int>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserMatchId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MatchId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMatch");

                    b.HasData(
                        new
                        {
                            MatchId = 1,
                            UserId = "1",
                            UserMatchId = 1
                        },
                        new
                        {
                            MatchId = 2,
                            UserId = "2",
                            UserMatchId = 2
                        },
                        new
                        {
                            MatchId = 2,
                            UserId = "1",
                            UserMatchId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("aspnetfirst.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("aspnetfirst.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("aspnetfirst.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("aspnetfirst.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aspnetfirst.Models.Coach", b =>
                {
                    b.HasOne("aspnetfirst.Models.Team", "Team")
                        .WithOne("Coach")
                        .HasForeignKey("aspnetfirst.Models.Coach", "CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aspnetfirst.Models.Match", b =>
                {
                    b.HasOne("aspnetfirst.Models.Team", "Team_guest")
                        .WithMany()
                        .HasForeignKey("Team_guestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("aspnetfirst.Models.Team", "Team_home")
                        .WithMany()
                        .HasForeignKey("Team_homeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aspnetfirst.Models.Player", b =>
                {
                    b.HasOne("aspnetfirst.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aspnetfirst.Models.ScoreStatistic", b =>
                {
                    b.HasOne("aspnetfirst.Models.Match", "Match")
                        .WithOne("ScoreStatistic")
                        .HasForeignKey("aspnetfirst.Models.ScoreStatistic", "MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aspnetfirst.Models.Team", b =>
                {
                    b.HasOne("aspnetfirst.Models.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("aspnetfirst.Models.UserMatch", b =>
                {
                    b.HasOne("aspnetfirst.Models.Match", "Match")
                        .WithMany("UserMatches")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("aspnetfirst.Models.User", "User")
                        .WithMany("UserMatches")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
