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

        public virtual DbSet<Infomation> Infomation { get; set; }
        public virtual DbSet<IsAdmin> IsAdmin { get; set; }
        public virtual DbSet<IsIntroduce> IsIntroduce { get; set; }
        public virtual DbSet<IsLogin> IsLogin { get; set; }
        public virtual DbSet<IsNavbar> IsNavbar { get; set; }
        public virtual DbSet<IsPost> IsPost { get; set; }
        public virtual DbSet<IsSpecies> IsSpecies { get; set; }
        public virtual DbSet<IsTheme> IsTheme { get; set; }
        public virtual DbSet<IsVideo> IsVideo { get; set; }
        public virtual DbSet<MenuFooter> MenuFooter { get; set; }
        public virtual DbSet<MenuTop1> MenuTop1 { get; set; }
        public virtual DbSet<MenuTop2> MenuTop2 { get; set; }

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
                    .HasMaxLength(50)
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
                    .HasConstraintName("FK__Infomatio__Infom__1AD3FDA4");
            });

            modelBuilder.Entity<IsAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__IsAdmin__719FE488C2AF7F8A");

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasColumnName("logo")
                    .HasMaxLength(100);

                entity.HasOne(d => d.MenuFooterid1Navigation)
                    .WithMany(p => p.IsAdminMenuFooterid1Navigation)
                    .HasForeignKey(d => d.MenuFooterid1)
                    .HasConstraintName("FK__IsAdmin__MenuFoo__46B27FE2");

                entity.HasOne(d => d.MenuFooterid2Navigation)
                    .WithMany(p => p.IsAdminMenuFooterid2Navigation)
                    .HasForeignKey(d => d.MenuFooterid2)
                    .HasConstraintName("FK__IsAdmin__MenuFoo__47A6A41B");

                entity.HasOne(d => d.MenuFooterid3Navigation)
                    .WithMany(p => p.IsAdminMenuFooterid3Navigation)
                    .HasForeignKey(d => d.MenuFooterid3)
                    .HasConstraintName("FK__IsAdmin__MenuFoo__489AC854");

                entity.HasOne(d => d.MenuTopId1Navigation)
                    .WithMany(p => p.IsAdmin)
                    .HasForeignKey(d => d.MenuTopId1)
                    .HasConstraintName("FK__IsAdmin__MenuTop__4A8310C6");

                entity.HasOne(d => d.MenuTopId2Navigation)
                    .WithMany(p => p.IsAdmin)
                    .HasForeignKey(d => d.MenuTopId2)
                    .HasConstraintName("FK__IsAdmin__MenuTop__498EEC8D");
            });

            modelBuilder.Entity<IsIntroduce>(entity =>
            {
                entity.HasKey(e => e.IntroduceId)
                    .HasName("PK__IsIntrod__C8D13E203D2DEC55");

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

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ViewPost).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<IsLogin>(entity =>
            {
                entity.HasKey(e => e.Account)
                    .HasName("PK__IsLogin__EA162E1099A8CA98");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(50)
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

            modelBuilder.Entity<IsNavbar>(entity =>
            {
                entity.HasKey(e => e.NavbarId)
                    .HasName("PK__IsNavbar__CF537171AEA56399");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("dateUpdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Image1)
                    .IsRequired()
                    .HasColumnName("image1")
                    .HasMaxLength(100);

                entity.Property(e => e.Image10)
                    .HasColumnName("image10")
                    .HasMaxLength(100);

                entity.Property(e => e.Image2)
                    .HasColumnName("image2")
                    .HasMaxLength(100);

                entity.Property(e => e.Image3)
                    .HasColumnName("image3")
                    .HasMaxLength(100);

                entity.Property(e => e.Image4)
                    .HasColumnName("image4")
                    .HasMaxLength(100);

                entity.Property(e => e.Image5)
                    .HasColumnName("image5")
                    .HasMaxLength(100);

                entity.Property(e => e.Image6)
                    .HasColumnName("image6")
                    .HasMaxLength(100);

                entity.Property(e => e.Image7)
                    .HasColumnName("image7")
                    .HasMaxLength(100);

                entity.Property(e => e.Image8)
                    .HasColumnName("image8")
                    .HasMaxLength(100);

                entity.Property(e => e.Image9)
                    .HasColumnName("image9")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage1)
                    .IsRequired()
                    .HasColumnName("linkImage1")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage10)
                    .HasColumnName("linkImage10")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage2)
                    .HasColumnName("linkImage2")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage3)
                    .HasColumnName("linkImage3")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage4)
                    .HasColumnName("linkImage4")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage5)
                    .HasColumnName("linkImage5")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage6)
                    .HasColumnName("linkImage6")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage7)
                    .HasColumnName("linkImage7")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage8)
                    .HasColumnName("linkImage8")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage9)
                    .HasColumnName("linkImage9")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<IsPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__IsPost__AA126018FCCB95C1");

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

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ViewPost).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.IsPost)
                    .HasForeignKey(d => d.SpeciesId)
                    .HasConstraintName("FK__IsPost__SpeciesI__2A164134");
            });

            modelBuilder.Entity<IsSpecies>(entity =>
            {
                entity.HasKey(e => e.SpeciesId)
                    .HasName("PK__IsSpecie__A938045F4A571BB0");

                entity.Property(e => e.AvatarSpecies)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IsTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Isname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.IsSpecies)
                    .HasForeignKey(d => d.ThemeId)
                    .HasConstraintName("FK__IsSpecies__Theme__245D67DE");
            });

            modelBuilder.Entity<IsTheme>(entity =>
            {
                entity.HasKey(e => e.ThemeId)
                    .HasName("PK__IsTheme__FBB3E4D9E0AF36F6");

                entity.Property(e => e.AvatarTheme)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IsTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Isname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IsVideo>(entity =>
            {
                entity.HasKey(e => e.VideoId)
                    .HasName("PK__IsVideo__BAE5126A43A9E6C1");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.DayInPost)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VideoIndex)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ViewPost).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.IsVideo)
                    .HasForeignKey(d => d.SpeciesId)
                    .HasConstraintName("FK__IsVideo__Species__2FCF1A8A");
            });

            modelBuilder.Entity<MenuFooter>(entity =>
            {
                entity.Property(e => e.DateUpdate)
                    .HasColumnName("dateUpdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.LinkMenu1)
                    .IsRequired()
                    .HasColumnName("linkMenu1")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu2)
                    .IsRequired()
                    .HasColumnName("linkMenu2")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu3)
                    .IsRequired()
                    .HasColumnName("linkMenu3")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu4)
                    .IsRequired()
                    .HasColumnName("linkMenu4")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu5)
                    .IsRequired()
                    .HasColumnName("linkMenu5")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu6)
                    .IsRequired()
                    .HasColumnName("linkMenu6")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu7)
                    .IsRequired()
                    .HasColumnName("linkMenu7")
                    .HasMaxLength(100);

                entity.Property(e => e.Section1)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section2)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section3)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section4)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section5)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section6)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section7)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TitleSection)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MenuTop1>(entity =>
            {
                entity.HasKey(e => e.MenuTopId1)
                    .HasName("PK__MenuTop1__28D987A43C647046");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("dateUpdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.LinkMenu1)
                    .IsRequired()
                    .HasColumnName("linkMenu1")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu2)
                    .IsRequired()
                    .HasColumnName("linkMenu2")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu3)
                    .IsRequired()
                    .HasColumnName("linkMenu3")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu4)
                    .IsRequired()
                    .HasColumnName("linkMenu4")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu5)
                    .IsRequired()
                    .HasColumnName("linkMenu5")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu6)
                    .IsRequired()
                    .HasColumnName("linkMenu6")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu7)
                    .IsRequired()
                    .HasColumnName("linkMenu7")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu8)
                    .IsRequired()
                    .HasColumnName("linkMenu8")
                    .HasMaxLength(100);

                entity.Property(e => e.Menu1)
                    .IsRequired()
                    .HasColumnName("menu1")
                    .HasMaxLength(10);

                entity.Property(e => e.Menu2)
                    .IsRequired()
                    .HasColumnName("menu2")
                    .HasMaxLength(10);

                entity.Property(e => e.Menu3)
                    .IsRequired()
                    .HasColumnName("menu3")
                    .HasMaxLength(10);

                entity.Property(e => e.Menu4)
                    .IsRequired()
                    .HasColumnName("menu4")
                    .HasMaxLength(10);

                entity.Property(e => e.Menu5)
                    .IsRequired()
                    .HasColumnName("menu5")
                    .HasMaxLength(10);

                entity.Property(e => e.Menu6)
                    .IsRequired()
                    .HasColumnName("menu6")
                    .HasMaxLength(10);

                entity.Property(e => e.Menu7)
                    .IsRequired()
                    .HasColumnName("menu7")
                    .HasMaxLength(10);

                entity.Property(e => e.Menu8)
                    .IsRequired()
                    .HasColumnName("menu8")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<MenuTop2>(entity =>
            {
                entity.HasKey(e => e.MenuTopId2)
                    .HasName("PK__MenuTop2__28D987A5382D34B4");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("dateUpdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.LinkMenu1)
                    .IsRequired()
                    .HasColumnName("linkMenu1")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu2)
                    .IsRequired()
                    .HasColumnName("linkMenu2")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu3)
                    .IsRequired()
                    .HasColumnName("linkMenu3")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu4)
                    .IsRequired()
                    .HasColumnName("linkMenu4")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu5)
                    .IsRequired()
                    .HasColumnName("linkMenu5")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu6)
                    .IsRequired()
                    .HasColumnName("linkMenu6")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkMenu7)
                    .IsRequired()
                    .HasColumnName("linkMenu7")
                    .HasMaxLength(100);

                entity.Property(e => e.Section1)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section2)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section3)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section4)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section5)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section6)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section7)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
