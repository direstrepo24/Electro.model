
using datamakerslib.DataContext;
using Electro.model.datatakemodel;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Electro.model.DataContext
{
    public class MyAppContext: EntityContextBase<MyAppContext>
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        { }
        ///colocar las clases
        //public DbSet<Lectura> Lecturas { get; set; }
        //public DbSet<Medidor> medidor {get;set;}
        //public DbSet<User> user{get;set;}
        public DbSet<Cable> Cable{get;set;}
        public DbSet<Ciudad> Ciudad{get;set;}
        public DbSet<Departamento> Departamento{get;set;}
        public DbSet<DetalleTipoCable> DetalleTipoCable{get;set;}
        public DbSet<DetalleTipoNovedad> DetalleTipoNovedad{get;set;}
        public DbSet<Elemento> Elemento{get;set;}
        public DbSet<ElementoCable> ElementoCable{get;set;}
        public DbSet<Empresa> Empresa{get;set;}
        public DbSet<EquipoElemento> EquipoElemento{get;set;}
        public DbSet<Estado> Estado{get;set;}
        public DbSet<Foto> Foto{get;set;}
        public DbSet<LocalizacionCable> LocalizacionCable{get;set;}
        public DbSet<LocalizacionElemento> LocalizacionElemento{get;set;}
        public DbSet<LongitudElemento> LongitudElemento{get;set;}
        public DbSet<Material> Material{get;set;}
        public DbSet<NivelTensionElemento> NivelTensionElemento{get;set;}
        public DbSet<Novedad> Novedad{get;set;}
        public DbSet<Proyecto_Empresa> Proyecto_Empresa{get;set;}
       public DbSet<Proyecto> Proyecto{get;set;}
       public DbSet<ProyectoUsuario> ProyectoUsuario{get;set;}
       public DbSet<Tipo_Usuario> Tipo_Usuario{get;set;}
       public DbSet<TipoCable> TipoCable{get;set;}
       public DbSet<TipoEquipo> TipoEquipo{get;set;}
       public DbSet<TipoNovedad> TipoNovedad{get;set;}
       public DbSet<Usuario> Usuario{get;set;}
       public DbSet<Dispositivo> Dispositivo{get;set;}
       public DbSet<Perdida> Perdida{get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*  builder.Entity<User>()
        .HasMany(e=>e.Vehicles)
        .WithOne(c=>c.user).HasForeignKey(c=>c.User_Id);

        builder.Entity<Notification_Type>()
        .HasMany(e=>e.Notifications)
        .WithOne(c=>c.Notification_Type).HasForeignKey(c=>c.Notification_Type_Id);
 */
              

            modelBuilder.Entity<Cable>()
             .HasMany(e => e.DetalleTipoCables)
            .WithOne(c => c.Cable).HasForeignKey(c=>c.Cable_Id);

             modelBuilder.Entity<Ciudad>()
             .HasMany(e => e.proyecto)
            .WithOne(c => c.Ciudad).HasForeignKey(c=>c.Ciudad_Id);

              modelBuilder.Entity<DetalleTipoCable>()
             .HasMany(e => e.ElementoCable)
            .WithOne(c => c.DetalleTipoCable).HasForeignKey(c=>c.DetalleTipocable_Id);


            modelBuilder.Entity<DetalleTipoNovedad>()
             .HasMany(e => e.Novedades)
            .WithOne(c => c.DetalleTipoNovedad).HasForeignKey(c=>c.Detalle_Tipo_Novedad_Id);

              modelBuilder.Entity<Elemento>()
             .HasMany(e => e.Novedades)
            .WithOne(c => c.Elemento).HasForeignKey(c=>c.Elemento_Id);
 
               modelBuilder.Entity<Elemento>()
             .HasMany(e => e.LocalizacionElementos)
            .WithOne(c => c.Elemento).HasForeignKey(c=>c.Element_Id);

             modelBuilder.Entity<Elemento>()
             .HasMany(e => e.Cables)
            .WithOne(c => c.Elemento).HasForeignKey(c=>c.Elemento_Id);

        
             modelBuilder.Entity<ElementoCable>()
             .HasMany(e => e.LocalizacionCables)
            .WithOne(c => c.ElementoCable).HasForeignKey(c=>c.ElementoCable_Id);


             modelBuilder.Entity<Empresa>()
             .HasMany(e => e.ProyectoEmpresas)
            .WithOne(c => c.Empresa).HasForeignKey(c=>c.Empresa_Id);

             modelBuilder.Entity<Estado>()
             .HasMany(e => e.Elementos)
            .WithOne(c => c.Estado).HasForeignKey(c=>c.Estado_id);

            modelBuilder.Entity<LongitudElemento>()
             .HasMany(e => e.Elementos)
            .WithOne(c => c.LongitudElemento).HasForeignKey(c=>c.Longitud_Elemento_Id);

            modelBuilder.Entity<Material>()
             .HasMany(e => e.Elementos)
            .WithOne(c => c.Material).HasForeignKey(c=>c.Material_Id);


        modelBuilder.Entity<NivelTensionElemento>()
             .HasMany(e => e.Elemento)
            .WithOne(c => c.NivelTensionElemento).HasForeignKey(c=>c.Nivel_Tension_Id);

        modelBuilder.Entity<Proyecto>()
             .HasMany(e => e.ProyectoUsuarios)
            .WithOne(c => c.proyecto).HasForeignKey(c=>c.Proyecto_Id);

         modelBuilder.Entity<Proyecto>()
             .HasMany(e => e.Elementos)
            .WithOne(c => c.Proyecto).HasForeignKey(c=>c.Proyecto_Id);


            modelBuilder.Entity<TipoCable>()
                        .HasMany(e => e.DetalleTipoCables)
                        .WithOne(c => c.TipoCable).HasForeignKey(c=>c.Tipocable_Id);


            modelBuilder.Entity<TipoEquipo>()
                        .HasMany(e => e.EquipoElemento)
                        .WithOne(c => c.TipoEquipo).HasForeignKey(c=>c.TipoEquipo_Id);
//TipoNovedad
            modelBuilder.Entity<TipoNovedad>()
                        .HasMany(e => e.DetalleTipoNovedades)
                        .WithOne(c => c.TipoNovedad).HasForeignKey(c=>c.Tipo_Novedad_id);
            modelBuilder.Entity<Departamento>()
                        .HasMany(e => e.ciudades)
                        .WithOne(c => c.departmento).HasForeignKey(c=>c.departmentoId);


            modelBuilder.Entity<Proyecto>()
                        .HasMany(e => e.Proyecto_Empresas)
                        .WithOne(c => c.Proyecto).HasForeignKey(c=>c.Proyecto_Id);

            modelBuilder.Entity<Empresa>()
                        .HasMany(e => e.ProyectoEmpresas)
                        .WithOne(c => c.Empresa).HasForeignKey(c=>c.Empresa_Id);

            modelBuilder.Entity<Usuario>()
                        .HasMany(e => e.ProyectoUsuarios)
                        .WithOne(c => c.Usuario).HasForeignKey(c=>c.Proyecto_Id);





            
             modelBuilder.Entity<Cable>().HasKey(m=>m.Id);
             modelBuilder.Entity<Ciudad>().HasKey(m=>m.Id);
             modelBuilder.Entity<Departamento>().HasKey(m=>m.Id);
             modelBuilder.Entity<DetalleTipoCable>().HasKey(m=>m.Id);
             modelBuilder.Entity<DetalleTipoNovedad>().HasKey(m=>m.Id);
            modelBuilder.Entity<Elemento>().HasKey(m=>m.Id);
           modelBuilder.Entity<ElementoCable>().HasKey(m=>m.Id);
           modelBuilder.Entity<Empresa>().HasKey(m=>m.Id);
           modelBuilder.Entity<EquipoElemento>().HasKey(m=>m.Id);
           modelBuilder.Entity<Estado>().HasKey(m=>m.Id);
           modelBuilder.Entity<Foto>().HasKey(m=>m.Id);
           modelBuilder.Entity<LongitudElemento>().HasKey(m=>m.Id);
           modelBuilder.Entity<Material>().HasKey(m=>m.Id);
           modelBuilder.Entity<NivelTensionElemento>().HasKey(m=>m.Id);
            modelBuilder.Entity<Novedad>().HasKey(m=>m.Id);
            modelBuilder.Entity<Proyecto_Empresa>().HasKey(m=>m.Id);
            modelBuilder.Entity<Proyecto>().HasKey(m=>m.Id);
            modelBuilder.Entity<ProyectoUsuario>().HasKey(m=>m.Id);
            modelBuilder.Entity<Tipo_Usuario>().HasKey(m=>m.Id);
            modelBuilder.Entity<TipoCable>().HasKey(m=>m.Id);
            modelBuilder.Entity<TipoEquipo>().HasKey(m=>m.Id);
            modelBuilder.Entity<TipoNovedad>().HasKey(m=>m.Id);
            modelBuilder.Entity<Usuario>().HasKey(m=>m.Id);
            modelBuilder.Entity<Perdida>().HasKey(m=>m.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}