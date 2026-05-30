using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace gandon.Models;

public partial class Ispr2524KuzminAoLibraryContext : DbContext
{
    public Ispr2524KuzminAoLibraryContext()
    {
    }

    public Ispr2524KuzminAoLibraryContext(DbContextOptions<Ispr2524KuzminAoLibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Librarian> Librarians { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=cfif31.ru;database=ISPr25-24_KuzminAO_Library;user=ISPr25-24_KuzminAO;password=ISPr25-24_KuzminAO", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Idauthor).HasName("PRIMARY");

            entity.ToTable("author");

            entity.Property(e => e.Idauthor).HasColumnName("idauthor");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(255)
                .HasColumnName("author_name");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Idbook).HasName("PRIMARY");

            entity.ToTable("book");

            entity.HasIndex(e => e.AuthorId, "fk_book_author");

            entity.Property(e => e.Idbook).HasColumnName("idbook");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.Cena)
                .HasPrecision(10, 2)
                .HasColumnName("cena");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_book_author");
        });

        modelBuilder.Entity<Librarian>(entity =>
        {
            entity.HasKey(e => e.Idlibrarian).HasName("PRIMARY");

            entity.ToTable("librarian");

            entity.Property(e => e.Idlibrarian).HasColumnName("idlibrarian");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
