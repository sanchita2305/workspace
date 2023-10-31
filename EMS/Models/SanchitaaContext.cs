using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EMS.Models;

public partial class SanchitaaContext : DbContext
{
    public SanchitaaContext()
    {
    }

    public SanchitaaContext(DbContextOptions<SanchitaaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=False;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3213E83FA435E4A4");

            entity.ToTable("Product");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Stock).HasColumnName("stock");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student");

            entity.Property(e => e.English).HasColumnName("english");
            entity.Property(e => e.Hindi).HasColumnName("hindi");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Math).HasColumnName("math");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
