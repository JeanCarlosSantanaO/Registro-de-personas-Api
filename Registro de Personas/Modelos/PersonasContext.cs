using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Registro_de_Personas.Modelos;

public partial class PersonasContext : DbContext
{
    public PersonasContext()
    {
    }

    public PersonasContext(DbContextOptions<PersonasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-TEOJV65H\\MSSQLSERVER01;\nDatabase=Personas;\nUser Id=sa;\nPassword=1701;\nEncrypt=True;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__personas__3214EC07E5E64275");

            entity.ToTable("personas");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Cedula)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cedula");
            entity.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estadoCivil");
            entity.Property(e => e.FechaDeReguistro)
                .HasColumnType("datetime")
                .HasColumnName("fechaDeReguistro");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fechaNacimiento");
            entity.Property(e => e.Foto).HasColumnName("foto");
            entity.Property(e => e.Genero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("genero");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nacionalidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
