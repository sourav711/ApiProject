using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project.Models
{
    public partial class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PlayersInfo> PlayersInfo { get; set; }

        // Unable to generate entity type for table 'dbo.Testsql'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Project;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayersInfo>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.Property(e => e.PlayerId).HasColumnName("Player_Id");

                entity.Property(e => e.PlayerAge).HasColumnName("Player_Age");

                entity.Property(e => e.PlayerMatches).HasColumnName("Player_Matches");

                entity.Property(e => e.PlayerName)
                    .IsRequired()
                    .HasColumnName("Player_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerRole)
                    .HasColumnName("Player_Role")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });
        }
    }
}
