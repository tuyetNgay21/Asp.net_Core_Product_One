using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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

        public virtual DbSet<IsLogin> IsLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=WT436;Database=TTS_ASP_Core;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
