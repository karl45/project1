using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetfirst.Models;

namespace aspnetfirst.Data
{
    public class BetContext:DbContext
    {
        public BetContext(DbContextOptions options):base(options) => Database.EnsureCreated();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Player>()
                .HasOne(t => t.Team)
                .WithMany(v => v.Players)
                .HasForeignKey(v => v.TeamId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Coach>()
                .HasOne(s => s.Team)
                .WithOne(s => s.Coach)
                .HasForeignKey<Coach>(v => v.CoachId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Team>()
                   .HasOne(t => t.League)
                   .WithMany(t => t.Teams)
                   .HasForeignKey(v => v.LeagueId)
                   .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Match>()
                .HasOne(t => t.ScoreStatistic)
                .WithOne(t => t.Match)
                .HasForeignKey<ScoreStatistic>(v => v.MatchId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserMatch>().HasKey(man => new { man.MatchId, man.UserId });

            modelBuilder.Entity<UserMatch>()
                .HasOne(u => u.User)
                .WithMany(v => v.UserMatches)
                .HasForeignKey(v => v.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserMatch>()
                .HasOne(u => u.Match)
                .WithMany(v => v.UserMatches)
                .HasForeignKey(v => v.MatchId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<League>(b =>
            {
                b.HasData(
                    new League
                {
                    LeagueId = 1,
                    LeaugueName = "Italy",

                });
                b.HasData(new League
                {
                    LeagueId = 2,
                    LeaugueName = "Spain"
                });
            });
            modelBuilder.Entity<Coach>().HasData(
                new Coach() { CoachId = 1,CoachName = "Juze",Rate = 95},
                new Coach() { CoachId = 2,CoachName = "Morris",Rate = 88},
                new Coach() { CoachId = 3,CoachName = "Philippo",Rate = 96}
            );
            modelBuilder.Entity<Team>().HasData(
                new Team() { TeamId = 1,TeamName ="Juventus",CoachId=1,TeamRate = 98,LeagueId = 1},
                new Team() { TeamId = 2,TeamName ="Milan", CoachId = 2, TeamRate = 85, LeagueId = 1 },
                new Team() { TeamId = 3,TeamName = "Inter",CoachId=3,TeamRate = 78,LeagueId = 1}
                );
            modelBuilder.Entity<Player>().HasData(
                new Player() { PlayerId = 1, PlayerName = "Ronaldo", Deffence = 48, Offence = 95, TeamId = 1 },
                new Player() { PlayerId = 2, PlayerName = "Kaka",Deffence = 56,Offence = 85,TeamId = 2}
                );
            modelBuilder.Entity<Match>().HasData(
                 new Match() { MatchId = 1,Team_homeId=1,Team_guestId=2},
                 new Match() { MatchId = 2,Team_homeId =3,Team_guestId = 1 }
                );
            modelBuilder.Entity<ScoreStatistic>().HasData(
                 new ScoreStatistic() { ScoreStatisticId = 1,Numberofpenalty = 13,Numberofredcard=3,NumberofyellowCard=5,Score="2-0",MatchId=1},
                 new ScoreStatistic() { ScoreStatisticId = 2,Numberofpenalty = 15,Numberofredcard=2,NumberofyellowCard =6,Score="3-2",MatchId=2}
                 );
            modelBuilder.Entity<User>().HasData(
                    new User() { UserId = 1, Username = "Ali", UserPassword = "AliPass", Points = 100},
                    new User() { UserId = 2,Username = "Dias",UserPassword="seniorhacka",Points = 80}
                );
            modelBuilder.Entity<UserMatch>().HasData(
                    new UserMatch() { UserMatchId = 1, UserId=1,MatchId=1},
                    new UserMatch() { UserMatchId = 2, UserId=2,MatchId=2},
                    new UserMatch() { UserMatchId = 3, UserId=1,MatchId=2}
            );

        }
        public DbSet<aspnetfirst.Models.League> League { get; set; }
        public DbSet<aspnetfirst.Models.Team> Team { get; set; }
        public DbSet<aspnetfirst.Models.Coach> Coach { get; set; }
        public DbSet<aspnetfirst.Models.Player> Player { get; set; }
        public DbSet<aspnetfirst.Models.Match> Match { get; set; }
        public DbSet<aspnetfirst.Models.ScoreStatistic> ScoreStatistic { get; set; }
        public DbSet<aspnetfirst.Models.User> User { get; set; }
        public DbSet<aspnetfirst.Models.UserMatch> UserMatch { get; set; }
   

   
      

    }
}
