using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyecSis3.Models
{
    public partial class ProyectoSI3Context : DbContext
    {
        public ProyectoSI3Context()
        {
        }

        public ProyectoSI3Context(DbContextOptions<ProyectoSI3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Articulo> Articulos { get; set; } = null!;
        public virtual DbSet<CatCorreo> CatCorreos { get; set; } = null!;
        public virtual DbSet<CatDireccion> CatDireccions { get; set; } = null!;
        public virtual DbSet<CatTelefono> CatTelefonos { get; set; } = null!;
        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<CuentaxCobrar> CuentaxCobrars { get; set; } = null!;
        public virtual DbSet<CuentaxPagar> CuentaxPagars { get; set; } = null!;
        public virtual DbSet<Facturacion> Facturacions { get; set; } = null!;
        public virtual DbSet<LineaDetalle> LineaDetalles { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;
        public virtual DbSet<Proveedor> Proveedors { get; set; } = null!;
        public virtual DbSet<Rol> Rols { get; set; } = null!;
        public virtual DbSet<TipoPago> TipoPagos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {


//Esto se cambia


#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-GJPKMKE\\SQLEXPRESS;Database=ProyectoSI3;Trusted_Connection=True;");
            }
        }
        /*
         * 
         * 
        Fabio server:DESKTOP-GJPKMKE\\SQLEXPRESS         ProyectoSI3
        Junior server:
        Adrian server:
        Sebastian server:

        Fabio: Se Cambia el server local y nombre del proyecto 




 
 
 
 
 
 
 
 
 
 
 */





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.IdArticulo)
                    .HasName("PK__Articulo__AABB742234A8B992");

                entity.ToTable("Articulo");

                entity.Property(e => e.IdArticulo)
                    .ValueGeneratedNever()
                    .HasColumnName("idArticulo");

                entity.Property(e => e.CategoriaIdCategoria).HasColumnName("Categoria_idCategoria");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorIdProveedor).HasColumnName("Proveedor_idProveedor");

                entity.HasOne(d => d.CategoriaIdCategoriaNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.CategoriaIdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Articulo__Catego__4F7CD00D");

                entity.HasOne(d => d.ProveedorIdProveedorNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.ProveedorIdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Articulo__Provee__5070F446");
            });

            modelBuilder.Entity<CatCorreo>(entity =>
            {
                entity.HasKey(e => e.IdCatCorreo)
                    .HasName("PK__Cat_Corr__F0461E8689A37A6A");

                entity.ToTable("Cat_Correo");

                entity.Property(e => e.IdCatCorreo)
                    .ValueGeneratedNever()
                    .HasColumnName("idCat_Correo");

                entity.Property(e => e.CorreoDetalle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatDireccion>(entity =>
            {
                entity.HasKey(e => e.IdCatDireccion)
                    .HasName("PK__Cat_Dire__D9A514941A9DC513");

                entity.ToTable("Cat_Direccion");

                entity.Property(e => e.IdCatDireccion)
                    .ValueGeneratedNever()
                    .HasColumnName("idCat_Direccion");

                entity.Property(e => e.DireccionDetalle)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatTelefono>(entity =>
            {
                entity.HasKey(e => e.IdCatTelefono)
                    .HasName("PK__Cat_Tele__A57AB82284037637");

                entity.ToTable("Cat_Telefono");

                entity.Property(e => e.IdCatTelefono)
                    .ValueGeneratedNever()
                    .HasColumnName("idCat_Telefono");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__8A3D240CDEA28E4E");

                entity.Property(e => e.IdCategoria)
                    .ValueGeneratedNever()
                    .HasColumnName("idCategoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NomCategoria)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CuentaxCobrar>(entity =>
            {
                entity.HasKey(e => e.IdCuentaxCobrar)
                    .HasName("PK__CuentaxC__00A66EA893D6E921");

                entity.ToTable("CuentaxCobrar");

                entity.Property(e => e.IdCuentaxCobrar)
                    .ValueGeneratedNever()
                    .HasColumnName("idCuentaxCobrar");

                entity.Property(e => e.FechaPago).HasColumnType("datetime");

                entity.Property(e => e.PersonaIdPersona).HasColumnName("Persona_idPersona");

                entity.HasOne(d => d.PersonaIdPersonaNavigation)
                    .WithMany(p => p.CuentaxCobrars)
                    .HasForeignKey(d => d.PersonaIdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CuentaxCo__Perso__5CD6CB2B");
            });

            modelBuilder.Entity<CuentaxPagar>(entity =>
            {
                entity.HasKey(e => e.IdCuentaxPagar)
                    .HasName("PK__CuentaxP__7F5E95754A3B968B");

                entity.ToTable("CuentaxPagar");

                entity.Property(e => e.IdCuentaxPagar)
                    .ValueGeneratedNever()
                    .HasColumnName("idCuentaxPagar");

                entity.Property(e => e.FechaPago).HasColumnType("datetime");

                entity.Property(e => e.ProveedorIdProveedor).HasColumnName("Proveedor_idProveedor");

                entity.HasOne(d => d.ProveedorIdProveedorNavigation)
                    .WithMany(p => p.CuentaxPagars)
                    .HasForeignKey(d => d.ProveedorIdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CuentaxPa__Prove__5FB337D6");
            });

            modelBuilder.Entity<Facturacion>(entity =>
            {
                entity.HasKey(e => e.IdFacturacion)
                    .HasName("PK__Facturac__2627C1839327BAD5");

                entity.ToTable("Facturacion");

                entity.Property(e => e.IdFacturacion)
                    .ValueGeneratedNever()
                    .HasColumnName("idFacturacion");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.LineaDetalleIdLineaDetalle).HasColumnName("LineaDetalle_idLineaDetalle");

                entity.Property(e => e.PersonaIdPersona).HasColumnName("Persona_idPersona");

                entity.Property(e => e.TipoPagoIdTipoPago).HasColumnName("Tipo_Pago_idTipo_Pago");

                entity.HasOne(d => d.LineaDetalleIdLineaDetalleNavigation)
                    .WithMany(p => p.Facturacions)
                    .HasForeignKey(d => d.LineaDetalleIdLineaDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturaci__Linea__59063A47");

                entity.HasOne(d => d.PersonaIdPersonaNavigation)
                    .WithMany(p => p.Facturacions)
                    .HasForeignKey(d => d.PersonaIdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturaci__Perso__59FA5E80");

                entity.HasOne(d => d.TipoPagoIdTipoPagoNavigation)
                    .WithMany(p => p.Facturacions)
                    .HasForeignKey(d => d.TipoPagoIdTipoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturaci__Tipo___5812160E");
            });

            modelBuilder.Entity<LineaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdLineaDetalle)
                    .HasName("PK__LineaDet__A92C7F9CC7C6D89B");

                entity.ToTable("LineaDetalle");

                entity.Property(e => e.IdLineaDetalle)
                    .ValueGeneratedNever()
                    .HasColumnName("idLineaDetalle");

                entity.Property(e => e.ArticuloIdArticulo).HasColumnName("Articulo_idArticulo");

                entity.Property(e => e.CantidadArticulos)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuestoVenta)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.ArticuloIdArticuloNavigation)
                    .WithMany(p => p.LineaDetalles)
                    .HasForeignKey(d => d.ArticuloIdArticulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineaDeta__Artic__5535A963");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Persona__A47881410512D8DB");

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona)
                    .ValueGeneratedNever()
                    .HasColumnName("idPersona");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CatCorreoIdCatCorreo).HasColumnName("Cat_Correo_idCat_Correo");

                entity.Property(e => e.CatDireccionIdCatDireccion).HasColumnName("Cat_Direccion_idCat_Direccion");

                entity.Property(e => e.CatTelefonoIdCatTelefono).HasColumnName("Cat_Telefono_idCat_Telefono");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIdUsuario).HasColumnName("Usuario_idUsuario");

                entity.HasOne(d => d.CatCorreoIdCatCorreoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.CatCorreoIdCatCorreo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__Cat_Cor__4AB81AF0");

                entity.HasOne(d => d.CatDireccionIdCatDireccionNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.CatDireccionIdCatDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__Cat_Dir__4BAC3F29");

                entity.HasOne(d => d.CatTelefonoIdCatTelefonoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.CatTelefonoIdCatTelefono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__Cat_Tel__4CA06362");

                entity.HasOne(d => d.UsuarioIdUsuarioNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.UsuarioIdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Persona__Usuario__49C3F6B7");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK__Proveedo__A3FA8E6B56D81ED6");

                entity.ToTable("Proveedor");

                entity.Property(e => e.IdProveedor)
                    .ValueGeneratedNever()
                    .HasColumnName("idProveedor");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.Idrol)
                    .HasName("PK__rol__24C6BB201F03861A");

                //

                entity.ToTable("rol");

                entity.Property(e => e.Idrol)
                    .ValueGeneratedNever()
                    .HasColumnName("idrol");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.IdTipoPago)
                    .HasName("PK__Tipo_Pag__34E2686D63865FAD");

                entity.ToTable("Tipo_Pago");

                entity.Property(e => e.IdTipoPago)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipo_Pago");

                entity.Property(e => e.TipoPago1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TipoPago");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A6D0076D8A");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("idUsuario");

                entity.Property(e => e.Contrasenna)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RolIdrol).HasColumnName("rol_idrol");

                entity.HasOne(d => d.RolIdrolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.RolIdrol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario__rol_idr__44FF419A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
