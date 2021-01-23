using Microsoft.EntityFrameworkCore;
using Yupti.Data.Models;

#nullable disable

namespace Yupti.Data.Contexts
{
    public partial class YuptiContext : DbContext
    {
        public YuptiContext()
        {
        }

        public YuptiContext(DbContextOptions<YuptiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Grouping> Groupings { get; set; }
        public virtual DbSet<WorklogEvent> WorklogEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Board>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.Property(e => e.Title).HasMaxLength(256);

                entity.HasOne(d => d.Grouping)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.GroupingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cards__GroupingI__300424B4");
            });

            modelBuilder.Entity<Grouping>(entity =>
            {
                entity.Property(e => e.Title).HasMaxLength(256);

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.Groupings)
                    .HasForeignKey(d => d.BoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Groupings__Board__2F10007B");
            });

            modelBuilder.Entity<WorklogEvent>(entity =>
            {
                entity.Property(e => e.CreatedOn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WorkEnd).HasColumnType("datetime");

                entity.Property(e => e.WorkStart).HasColumnType("datetime");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.WorklogEvents)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WorklogEv__CardI__2C3393D0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
