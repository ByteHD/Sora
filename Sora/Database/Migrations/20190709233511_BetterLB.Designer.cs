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
    [Migration("20190709233511_BetterLB")]
    partial class BetterLB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Sora.Database.Models.Achievements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("BitId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("IconURI")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("Sora.Database.Models.BeatmapSets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FavouriteCount");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<int>("PassCount");

                    b.Property<int>("PlayCount");

                    b.HasKey("Id");

                    b.ToTable("BeatmapSets");
                });

            modelBuilder.Entity("Sora.Database.Models.Beatmaps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Ar");

                    b.Property<string>("Artist")
                        .IsRequired();

                    b.Property<string>("BeatmapCreator")
                        .IsRequired();

                    b.Property<int>("BeatmapCreatorId");

                    b.Property<int>("BeatmapSetId");

                    b.Property<float>("Bpm");

                    b.Property<float>("Cs");

                    b.Property<double>("Difficulty");

                    b.Property<string>("DifficultyName")
                        .IsRequired();

                    b.Property<string>("FileMd5")
                        .IsRequired();

                    b.Property<int>("HitLength");

                    b.Property<float>("Hp");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<float>("Od");

                    b.Property<int>("PassCount");

                    b.Property<int>("PlayCount");

                    b.Property<byte>("PlayMode");

                    b.Property<DateTime>("RankedDate");

                    b.Property<sbyte>("RankedStatus");

                    b.Property<string>("Tags")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("TotalLength");

                    b.HasKey("Id");

                    b.ToTable("Beatmaps");
                });

            modelBuilder.Entity("Sora.Database.Models.Friends", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FriendId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("Sora.Database.Models.LeaderboardRx", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.ToTable("LeaderboardRx");
                });

            modelBuilder.Entity("Sora.Database.Models.LeaderboardStd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.ToTable("LeaderboardStd");
                });

            modelBuilder.Entity("Sora.Database.Models.Scores", b =>
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

                    b.Property<string>("FileMd5")
                        .IsRequired();

                    b.Property<short>("MaxCombo");

                    b.Property<uint>("Mods");

                    b.Property<double>("PerformancePoints");

                    b.Property<byte>("PlayMode");

                    b.Property<string>("ReplayMd5")
                        .IsRequired();

                    b.Property<string>("ScoreMd5")
                        .IsRequired();

                    b.Property<int>("TotalScore");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Sora.Database.Models.UserStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("CountryId");

                    b.HasKey("Id");

                    b.ToTable("UserStats");
                });

            modelBuilder.Entity("Sora.Database.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("Achievements");

                    b.Property<string>("AcquiredPermissions")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("PasswordVersion");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
