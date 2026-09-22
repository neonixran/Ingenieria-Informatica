using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EjercicioBD.Models;

public partial class EjercicioContext : DbContext
{
    public EjercicioContext()
    {
    }

    public EjercicioContext(DbContextOptions<EjercicioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EJERCICIO;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => new { e.Rut, e.Dv });

            entity.ToTable("PERSONA");

            entity.Property(e => e.Rut).HasColumnName("RUT");
            entity.Property(e => e.Dv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DV");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDOS");
            entity.Property(e => e.NomUsuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARIO");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRES");

            entity.HasOne(d => d.NomUsuarioNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.NomUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERSONA_USUARIO");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.NomUsuario);

            entity.ToTable("USUARIO");

            entity.Property(e => e.NomUsuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARIO");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
