using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CRUDApps.DataAccess.EF.Models;

namespace CRUDApps.DataAccess.EF.Context
{
    public partial class SutoGameStudioContext : DbContext
    {
        public SutoGameStudioContext()
        {
        }

        public SutoGameStudioContext(DbContextOptions<SutoGameStudioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fpsblasts> Fpsblasts { get; set; } = null!;
        public virtual DbSet<LoyaltyCharts> LoyaltyCharts { get; set; } = null!;
        public virtual DbSet<Mmoslashers> Mmoslashers { get; set; } = null!;
        public virtual DbSet<RpgstoryMakers> RpgstoryMakers { get; set; } = null!;
        public virtual DbSet<Users> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=SutoGameStudio;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fpsblasts>(entity =>
            {
                entity.HasKey(e => e.OwnFpsblastGame)
                    .HasName("PK__FPSBlast__E4337389C244D6D3");

                entity.ToTable("FPSBlast");

                entity.Property(e => e.OwnFpsblastGame)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OwnFPSBlastGame")
                    .IsFixedLength();

                entity.Property(e => e.Expansion1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FpsblastId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FPSBlastId");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LoyaltyCharts>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__LoyaltyC__E865F5550DD2B2E7");

                entity.ToTable("LoyaltyChart");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsLoyalCustomer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LoyaltyChartId).ValueGeneratedOnAdd();

                entity.Property(e => e.OwnFpsblastGame)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OwnFPSBlastGame")
                    .IsFixedLength();

                entity.Property(e => e.OwnMmoslasherGame)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OwnMMOSlasherGame")
                    .IsFixedLength();

                entity.Property(e => e.OwnRpgstoryMakerGame)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OwnRPGStoryMakerGame")
                    .IsFixedLength();

                entity.HasOne(d => d.OwnFpsblastGameNavigation)
                    .WithMany(p => p.LoyaltyCharts)
                    .HasForeignKey(d => d.OwnFpsblastGame)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoyaltyChart_FPSBlast");

                entity.HasOne(d => d.OwnMmoslasherGameNavigation)
                    .WithMany(p => p.LoyaltyCharts)
                    .HasForeignKey(d => d.OwnMmoslasherGame)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoyaltyChart_MMOSlasher1");

                entity.HasOne(d => d.OwnRpgstoryMakerGameNavigation)
                    .WithMany(p => p.LoyaltyCharts)
                    .HasForeignKey(d => d.OwnRpgstoryMakerGame)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoyaltyChart_RPGStoryMaker1");
            });

            modelBuilder.Entity<Mmoslashers>(entity =>
            {
                entity.HasKey(e => e.OwnMmoslasherGame)
                    .HasName("PK__MMOSlash__89964FB4E17A71CC");

                entity.ToTable("MMOSlasher");

                entity.Property(e => e.OwnMmoslasherGame)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OwnMMOSlasherGame")
                    .IsFixedLength();

                entity.Property(e => e.ActiveLast30Days)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expansion1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MmoslasherId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MMOSlasherId");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RpgstoryMakers>(entity =>
            {
                entity.HasKey(e => e.OwnRpgstoryMakerGame)
                    .HasName("PK__RPGStory__E43373890CDC9A84");

                entity.ToTable("RPGStoryMaker");

                entity.Property(e => e.OwnRpgstoryMakerGame)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OwnRPGStoryMakerGame")
                    .IsFixedLength();

                entity.Property(e => e.GameCompleted)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RpgstoryMakerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RPGStoryMakerId");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerLastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustomerState)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_LoyaltyChart");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
