using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tts_Asp.Net_Core.Models.ConnectDataBase
{
    public partial class TTS_ASP_CoreContext : DbContext
    {
        public TTS_ASP_CoreContext()
        {
        }

        public TTS_ASP_CoreContext(DbContextOptions<TTS_ASP_CoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Infomation> Infomation { get; set; }
        public virtual DbSet<IsIntroduce> IsIntroduce { get; set; }
        public virtual DbSet<IsLogin> IsLogin { get; set; }
        public virtual DbSet<IsPost> IsPost { get; set; }
        public virtual DbSet<IsSpecies> IsSpecies { get; set; }
        public virtual DbSet<IsTheme> IsTheme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=WT436;Database=TTS_ASP_Core;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Infomation>(entity =>
            {
                entity.Property(e => e.InfomationId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IsAddress)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.IsAge).HasDefaultValueSql("((8))");

                entity.Property(e => e.IsName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsPhone).HasColumnType("numeric(15, 0)");

                entity.HasOne(d => d.InfomationNavigation)
                    .WithOne(p => p.Infomation)
                    .HasForeignKey<Infomation>(d => d.InfomationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Infomatio__Infom__29221CFB");
            });

            modelBuilder.Entity<IsIntroduce>(entity =>
            {
                entity.HasKey(e => e.IntroduceId)
                    .HasName("PK__IsIntrod__C8D13E2037E48DA5");

                entity.Property(e => e.AvataIndex)
                    .IsRequired()
                    .HasColumnName("avataIndex")
                    .HasMaxLength(200);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.DayInPost)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ViewPost).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<IsLogin>(entity =>
            {
                entity.HasKey(e => e.Account)
                    .HasName("PK__IsLogin__EA162E101E20CDE6");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Decentralization).HasColumnName("decentralization");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaskPassword)
                    .IsRequired()
                    .HasColumnName("haskPassword")
                    .HasMaxLength(10);

                entity.Property(e => e.Passwork)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IsPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__IsPost__AA1260188BA420D6");

                entity.Property(e => e.AvataIndex)
                    .IsRequired()
                    .HasColumnName("avataIndex")
                    .HasMaxLength(200);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.DayInPost)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ViewPost).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.IsPost)
                    .HasForeignKey(d => d.SpeciesId)
                    .HasConstraintName("FK__IsPost__SpeciesI__40058253");
            });

            modelBuilder.Entity<IsSpecies>(entity =>
            {
                entity.HasKey(e => e.SpeciesId)
                    .HasName("PK__IsSpecie__A938045F78C5EB5F");

                entity.Property(e => e.AvatarSpecies)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.IsTitle)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Isname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.IsSpecies)
                    .HasForeignKey(d => d.ThemeId)
                    .HasConstraintName("FK__IsSpecies__Theme__3B40CD36");
            });

            modelBuilder.Entity<IsTheme>(entity =>
            {
                entity.HasKey(e => e.ThemeId)
                    .HasName("PK__IsTheme__FBB3E4D928B5FBAA");

                entity.Property(e => e.AvatarTheme)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.IsTitle)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Isname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
