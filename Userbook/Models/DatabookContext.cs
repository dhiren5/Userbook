using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Userbook.Models;

public partial class DatabookContext : DbContext
{
    public DatabookContext()
    {
    }

    public DatabookContext(DbContextOptions<DatabookContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Detail> Details { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PDC2C-L-138LX5W;Database='Databook';Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Detail>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.Birthday)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Fblink)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Gmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gmail");
            entity.Property(e => e.Instaid)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("instaid");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Linkedinlink)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
