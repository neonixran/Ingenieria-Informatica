using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pryCertamen3.Models;

public partial class EvaluacionWeb691Context : DbContext
{
    public EvaluacionWeb691Context()
    {
    }

    public EvaluacionWeb691Context(DbContextOptions<EvaluacionWeb691Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Camion> Camions { get; set; }

    public virtual DbSet<Chofer> Chofers { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<EstadoSalidum> EstadoSalida { get; set; }

    public virtual DbSet<Plantum> Planta { get; set; }

    public virtual DbSet<Salidum> Salida { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EVALUACION_WEB691;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Camion>(entity =>
        {
            entity.HasKey(e => e.CodCamion);

            entity.ToTable("CAMION");

            entity.Property(e => e.CodCamion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COD_CAMION");
            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.IdPlanta).HasColumnName("ID_PLANTA");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Camions)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAMION_ESTADO");

            entity.HasOne(d => d.IdPlantaNavigation).WithMany(p => p.Camions)
                .HasForeignKey(d => d.IdPlanta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAMION_PLANTA");
        });

        modelBuilder.Entity<Chofer>(entity =>
        {
            entity.HasKey(e => e.IdChofer);

            entity.ToTable("CHOFER");

            entity.Property(e => e.IdChofer).HasColumnName("ID_CHOFER");
            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.NomChofer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_CHOFER");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Chofers)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHOFER_ESTADO");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.ToTable("ESTADO");

            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.NomEstado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOM_ESTADO");
        });

        modelBuilder.Entity<EstadoSalidum>(entity =>
        {
            entity.HasKey(e => e.IdEstadoSalida);

            entity.ToTable("ESTADO_SALIDA");

            entity.Property(e => e.IdEstadoSalida).HasColumnName("ID_ESTADO_SALIDA");
            entity.Property(e => e.NomEstadoSalida)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOM_ESTADO_SALIDA");
        });

        modelBuilder.Entity<Plantum>(entity =>
        {
            entity.HasKey(e => e.IdPlanta);

            entity.ToTable("PLANTA");

            entity.Property(e => e.IdPlanta).HasColumnName("ID_PLANTA");
            entity.Property(e => e.NomPlanta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_PLANTA");
        });

        modelBuilder.Entity<Salidum>(entity =>
        {
            entity.HasKey(e => e.IdSalida);

            entity.ToTable("SALIDA");

            entity.Property(e => e.IdSalida).HasColumnName("ID_SALIDA");
            entity.Property(e => e.CodCamion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COD_CAMION");
            entity.Property(e => e.FechaSalida).HasColumnName("FECHA_SALIDA");
            entity.Property(e => e.IdChofer).HasColumnName("ID_CHOFER");
            entity.Property(e => e.IdEstadoSalida).HasColumnName("ID_ESTADO_SALIDA");
            entity.Property(e => e.IdPlanta).HasColumnName("ID_PLANTA");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");

            entity.HasOne(d => d.CodCamionNavigation).WithMany(p => p.Salida)
                .HasForeignKey(d => d.CodCamion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALIDA_CAMION");

            entity.HasOne(d => d.IdChoferNavigation).WithMany(p => p.Salida)
                .HasForeignKey(d => d.IdChofer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALIDA_CHOFER");

            entity.HasOne(d => d.IdEstadoSalidaNavigation).WithMany(p => p.Salida)
                .HasForeignKey(d => d.IdEstadoSalida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALIDA_ESTADO_SALIDA");

            entity.HasOne(d => d.IdPlantaNavigation).WithMany(p => p.Salida)
                .HasForeignKey(d => d.IdPlanta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALIDA_PLANTA");

            entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Salida)
                .HasForeignKey(d => d.Usuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SALIDA_USUARIOS");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Usuario1);

            entity.ToTable("USUARIOS");

            entity.Property(e => e.Usuario1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");
            entity.Property(e => e.NomPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_PERSONA");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIOS_ESTADO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
