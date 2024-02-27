using CueControl.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CueControl.DAL
{
    public class AppDbContext : DbContext
    {
        //Constructor calling the Base DbContext Class Constructor
        public AppDbContext() : base()
        {
        }
        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configuring the Connection String
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CueControl;User Id=sa;password=StSmYj84;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=false;MultipleActiveResultSets=true;Integrated Security=False;Trusted_Connection=False;");
            //use this to configure the contex
        }
        //OnModelCreating() method is used to configure the model using ModelBuilder Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<MatchSchedule>()
                .HasOne(m => m.HomeTeam)
                .WithMany()
                .HasForeignKey(m => m.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MatchSchedule>()
                .HasOne(m => m.AwayTeam)
                .WithMany()
                .HasForeignKey(m => m.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeamStanding>()
                .HasOne(ts => ts.Team)
                .WithMany()
                .HasForeignKey(ts => ts.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeamStanding>()
                .HasOne(ts => ts.League)
                .WithMany()
                .HasForeignKey(ts => ts.LeagueId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeamStanding>()
                .HasOne(ts => ts.Season)
                .WithMany()
                .HasForeignKey(ts => ts.SeasonId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<League> Leagues { get; set; }
        public DbSet<MatchSchedule> MatchSchedules { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerRanking> PlayerRankings { get; set; }
        public DbSet<PlayerStanding> PlayerStanding { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamPlayer> TeamPlayers { get; set; }
        public DbSet<TeamStanding> TeamStanding { get; set; }
        public DbSet<LeagueSeason> LeagueSeasons { get; set; }
    }
}
