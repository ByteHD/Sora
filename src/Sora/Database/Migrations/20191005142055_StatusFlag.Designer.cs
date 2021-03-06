﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sora.Database;

namespace Sora.Database.Migrations
{
    [DbContext(typeof(SoraDbContext))]
    [Migration("20191005142055_StatusFlag")]
    partial class StatusFlag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Sora.Database.Models.DBAchievement", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("IconURI")
                        .IsRequired();

                    b.HasKey("Name");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("Sora.Database.Models.DBFriend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FriendId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FriendId");

                    b.HasIndex("UserId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("Sora.Database.Models.DBLeaderboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OwnerId");

                    b.Property<double>("PerformancePointsCtb");

                    b.Property<double>("PerformancePointsMania");

                    b.Property<double>("PerformancePointsOsu");

                    b.Property<double>("PerformancePointsTaiko");

                    b.Property<ulong>("PlayCountCtb");

                    b.Property<ulong>("PlayCountMania");

                    b.Property<ulong>("PlayCountOsu");

                    b.Property<ulong>("PlayCountTaiko");

                    b.Property<ulong>("RankedScoreCtb");

                    b.Property<ulong>("RankedScoreMania");

                    b.Property<ulong>("RankedScoreOsu");

                    b.Property<ulong>("RankedScoreTaiko");

                    b.Property<ulong>("TotalScoreCtb");

                    b.Property<ulong>("TotalScoreMania");

                    b.Property<ulong>("TotalScoreOsu");

                    b.Property<ulong>("TotalScoreTaiko");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Leaderboard");
                });

            modelBuilder.Entity("Sora.Database.Models.DBOAuthClient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Disabled");

                    b.Property<int>("Flags");

                    b.Property<int>("OwnerId");

                    b.Property<string>("Secret");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("OAuthClients");
                });

            modelBuilder.Entity("Sora.Database.Models.DBScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Accuracy");

                    b.Property<int>("Count100");

                    b.Property<int>("Count300");

                    b.Property<int>("Count50");

                    b.Property<int>("CountGeki");

                    b.Property<int>("CountKatu");

                    b.Property<int>("CountMiss");

                    b.Property<DateTime>("Date");

                    b.Property<string>("FileMd5");

                    b.Property<short>("MaxCombo");

                    b.Property<uint>("Mods");

                    b.Property<double>("PerformancePoints");

                    b.Property<byte>("PlayMode");

                    b.Property<string>("ReplayMd5");

                    b.Property<int>("TotalScore");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Sora.Database.Models.DBUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievements");

                    b.Property<string>("EMail")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<int>("PasswordVersion");

                    b.Property<string>("Permissions")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<string>("StatusReason");

                    b.Property<DateTime?>("StatusUntil");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Sora.Database.Models.DBFriend", b =>
                {
                    b.HasOne("Sora.Database.Models.DBUser", "Friend")
                        .WithMany()
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sora.Database.Models.DBUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sora.Database.Models.DBLeaderboard", b =>
                {
                    b.HasOne("Sora.Database.Models.DBUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sora.Database.Models.DBOAuthClient", b =>
                {
                    b.HasOne("Sora.Database.Models.DBUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sora.Database.Models.DBScore", b =>
                {
                    b.HasOne("Sora.Database.Models.DBUser", "ScoreOwner")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
