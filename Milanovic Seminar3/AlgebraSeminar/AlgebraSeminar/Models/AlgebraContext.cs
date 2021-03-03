using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AlgebraSeminar.Models
{
    public partial class AlgebraContext : DbContext
    {
        public AlgebraContext()
        {
        }

        public AlgebraContext(DbContextOptions<AlgebraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Predbiljezba> Predbiljezbas { get; set; }
        public virtual DbSet<Seminar> Seminars { get; set; }
        public virtual DbSet<Zaposlenik> Zaposleniks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Algebra;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Croatian_CI_AS");

            modelBuilder.Entity<Predbiljezba>(entity =>
            {
                entity.HasKey(e => e.IdPredbiljezba);

                entity.ToTable("Predbiljezba");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdSeminarNavigation)
                    .WithMany(p => p.Predbiljezbas)
                    .HasForeignKey(d => d.IdSeminar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Predbiljezba_Seminar");
            });

            modelBuilder.Entity<Seminar>(entity =>
            {
                entity.HasKey(e => e.IdSeminar);

                entity.ToTable("Seminar");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Predavac)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Zaposlenik>(entity =>
            {
                entity.HasKey(e => e.IdZaposlenik);

                entity.ToTable("Zaposlenik");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
