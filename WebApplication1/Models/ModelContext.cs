using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class ModelContext : DbContext
{
    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<APPLE> APPLE { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("DEMOUSER")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<APPLE>(entity =>
        {
            entity.HasKey(e => e.GID).HasName("SYS_C008223");

            entity.Property(e => e.GID)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("RAWTOHEX(SYS_GUID())")
                .HasComment("不重複流水號");
            entity.Property(e => e.LOCK_VERSION).HasPrecision(10);
            entity.Property(e => e.NAME)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
