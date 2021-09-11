using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MoTechFull.Database;

#nullable disable

namespace MoTechFull.Database
{
    public partial class MoTechContext : DbContext
    {
        public MoTechContext()
        {
        }

        public MoTechContext(DbContextOptions<MoTechContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artikal> Artikals { get; set; }
        public virtual DbSet<ArtikalPonudum> ArtikalPonuda { get; set; }
        public virtual DbSet<ArtikalServi> ArtikalServis { get; set; }
        public virtual DbSet<AutorizacijskiToken> AutorizacijskiTokens { get; set; }
        public virtual DbSet<Dobavljac> Dobavljacs { get; set; }
        public virtual DbSet<DobavljacNarudzba> DobavljacNarudzbas { get; set; }
        public virtual DbSet<DobavljacNarudzbaStavke> DobavljacNarudzbaStavkes { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Kanton> Kantons { get; set; }
        public virtual DbSet<Kategorija> Kategorijas { get; set; }
        public virtual DbSet<KorisnickiNalog> KorisnickiNalogs { get; set; }
        public virtual DbSet<Korpa> Korpas { get; set; }
        public virtual DbSet<KorpaArtikli> KorpaArtiklis { get; set; }
        public virtual DbSet<Kupac> Kupacs { get; set; }
        public virtual DbSet<KupacNarudzbe> KupacNarudzbes { get; set; }
        public virtual DbSet<NarudzbaStavke> NarudzbaStavkes { get; set; }
        public virtual DbSet<Novosti> Novostis { get; set; }
        public virtual DbSet<Ponudum> Ponuda { get; set; }
        public virtual DbSet<Proizvodjac> Proizvodjacs { get; set; }
        public virtual DbSet<Racun> Racuns { get; set; }
        public virtual DbSet<Recenzija> Recenzijas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost, 1434;Initial Catalog=MoTech; user=sa; Password=QWEasd123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Artikal>(entity =>
            {
                entity.ToTable("Artikal");

                entity.HasIndex(e => e.KategorijaId, "IX_Artikal_KategorijaId");

                entity.HasIndex(e => e.ProizvodjacId, "IX_Artikal_ProizvodjacId");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Artikals)
                    .HasForeignKey(d => d.KategorijaId);

                entity.HasOne(d => d.Proizvodjac)
                    .WithMany(p => p.Artikals)
                    .HasForeignKey(d => d.ProizvodjacId);
            });

            modelBuilder.Entity<ArtikalPonudum>(entity =>
            {
                entity.HasKey(e => new { e.ArtikalId, e.PonudaId });

                entity.HasIndex(e => e.PonudaId, "IX_ArtikalPonuda_PonudaId");

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.ArtikalPonuda)
                    .HasForeignKey(d => d.ArtikalId);

                entity.HasOne(d => d.Ponuda)
                    .WithMany(p => p.ArtikalPonuda)
                    .HasForeignKey(d => d.PonudaId);
            });

            modelBuilder.Entity<ArtikalServi>(entity =>
            {
                entity.HasKey(e => e.ArtikalServisId);

                entity.HasIndex(e => e.NarudzbaStavkeId, "IX_ArtikalServis_NarudzbaStavkeId");

                entity.HasOne(d => d.NarudzbaStavke)
                    .WithMany(p => p.ArtikalServis)
                    .HasForeignKey(d => d.NarudzbaStavkeId);
            });

            modelBuilder.Entity<AutorizacijskiToken>(entity =>
            {
                entity.ToTable("AutorizacijskiToken");

                entity.HasIndex(e => e.KorisnickiNalogId, "IX_AutorizacijskiToken_KorisnickiNalogId");

                entity.HasOne(d => d.KorisnickiNalog)
                    .WithMany(p => p.AutorizacijskiTokens)
                    .HasForeignKey(d => d.KorisnickiNalogId);
            });

            modelBuilder.Entity<Dobavljac>(entity =>
            {
                entity.ToTable("Dobavljac");

                entity.HasIndex(e => e.GradId, "IX_Dobavljac_GradId");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Dobavljacs)
                    .HasForeignKey(d => d.GradId);
            });

            modelBuilder.Entity<DobavljacNarudzba>(entity =>
            {
                entity.ToTable("DobavljacNarudzba");

                entity.HasIndex(e => e.DobavljacId, "IX_DobavljacNarudzba_DobavljacId");

                entity.HasOne(d => d.Dobavljac)
                    .WithMany(p => p.DobavljacNarudzbas)
                    .HasForeignKey(d => d.DobavljacId);
            });

            modelBuilder.Entity<DobavljacNarudzbaStavke>(entity =>
            {
                entity.ToTable("DobavljacNarudzbaStavke");

                entity.HasIndex(e => e.ArtikalId, "IX_DobavljacNarudzbaStavke_ArtikalId");

                entity.HasIndex(e => e.DobavljacNarudzbaId, "IX_DobavljacNarudzbaStavke_DobavljacNarudzbaId");

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.DobavljacNarudzbaStavkes)
                    .HasForeignKey(d => d.ArtikalId);

                entity.HasOne(d => d.DobavljacNarudzba)
                    .WithMany(p => p.DobavljacNarudzbaStavkes)
                    .HasForeignKey(d => d.DobavljacNarudzbaId);
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.HasIndex(e => e.KantonId, "IX_Grad_KantonId");

                entity.HasOne(d => d.Kanton)
                    .WithMany(p => p.Grads)
                    .HasForeignKey(d => d.KantonId);
            });

            modelBuilder.Entity<Kanton>(entity =>
            {
                entity.ToTable("Kanton");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.ToTable("Kategorija");
            });

            modelBuilder.Entity<KorisnickiNalog>(entity =>
            {
                entity.ToTable("KorisnickiNalog");
            });

            modelBuilder.Entity<Korpa>(entity =>
            {
                entity.ToTable("Korpa");

                entity.HasIndex(e => e.KorisnickiNalogId, "IX_Korpa_KupacId");

                entity.HasOne(d => d.KorisnickiNalog)
                    .WithMany(p => p.Korpas)
                    .HasForeignKey(d => d.KorisnickiNalogId);
            });

            modelBuilder.Entity<KorpaArtikli>(entity =>
            {
                entity.ToTable("KorpaArtikli");

                entity.HasIndex(e => e.ArtikalId, "IX_KorpaArtikli_ArtikalId");

                entity.HasIndex(e => e.KorpaId, "IX_KorpaArtikli_KorpaId");

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.KorpaArtiklis)
                    .HasForeignKey(d => d.ArtikalId);

                entity.HasOne(d => d.Korpa)
                    .WithMany(p => p.KorpaArtiklis)
                    .HasForeignKey(d => d.KorpaId);
            });

            modelBuilder.Entity<Kupac>(entity =>
            {
                entity.ToTable("Kupac");

                entity.HasIndex(e => e.GradId, "IX_Kupac_GradId");

                entity.HasIndex(e => e.KorisnickiNalogId, "IX_Kupac_KorisnickiNalogId");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Kupacs)
                    .HasForeignKey(d => d.GradId);

                entity.HasOne(d => d.KorisnickiNalog)
                    .WithMany(p => p.Kupacs)
                    .HasForeignKey(d => d.KorisnickiNalogId);
            });

            modelBuilder.Entity<KupacNarudzbe>(entity =>
            {
                entity.ToTable("KupacNarudzbe");

                entity.HasIndex(e => e.GradId, "IX_KupacNarudzbe_GradId");

                entity.HasIndex(e => e.KorisnickiNalogId, "IX_KupacNarudzbe_KupacId");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.KupacNarudzbes)
                    .HasForeignKey(d => d.GradId);

                entity.HasOne(d => d.KorisnickiNalog)
                    .WithMany(p => p.KupacNarudzbes)
                    .HasForeignKey(d => d.KorisnickiNalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NarudzbaStavke>(entity =>
            {
                entity.ToTable("NarudzbaStavke");

                entity.HasIndex(e => e.ArtikalId, "IX_NarudzbaStavke_ArtikalId");

                entity.HasIndex(e => e.KupacNarudzbeId, "IX_NarudzbaStavke_KupacNarudzbeId");

                entity.HasIndex(e => e.RacunId, "IX_NarudzbaStavke_RacunId");

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.NarudzbaStavkes)
                    .HasForeignKey(d => d.ArtikalId);

                entity.HasOne(d => d.KupacNarudzbe)
                    .WithMany(p => p.NarudzbaStavkes)
                    .HasForeignKey(d => d.KupacNarudzbeId);

                entity.HasOne(d => d.Racun)
                    .WithMany(p => p.NarudzbaStavkes)
                    .HasForeignKey(d => d.RacunId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Novosti>(entity =>
            {
                entity.ToTable("Novosti");

            });

            modelBuilder.Entity<Ponudum>(entity =>
            {
                entity.HasKey(e => e.PonudaId);
            });

            modelBuilder.Entity<Proizvodjac>(entity =>
            {
                entity.ToTable("Proizvodjac");
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.ToTable("Racun");

            });

            modelBuilder.Entity<Recenzija>(entity =>
            {
                entity.ToTable("Recenzija");

                entity.HasIndex(e => e.ArtikalId, "IX_Recenzija_ArtikalId");

                entity.HasIndex(e => e.KupacId, "IX_Recenzija_KupacId");

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.Recenzijas)
                    .HasForeignKey(d => d.ArtikalId);

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Recenzijas)
                    .HasForeignKey(d => d.KupacId);
            });
        

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
