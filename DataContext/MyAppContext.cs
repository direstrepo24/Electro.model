
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
             .HasMany(e => e.detalleTipoCable)
            .WithOne(c => c.cable).HasForeignKey(c=>c.cable_id);

             modelBuilder.Entity<Ciudad>()
             .HasMany(e => e.proyecto)
            .WithOne(c => c.ciudad).HasForeignKey(c=>c.ciudad_id);

              modelBuilder.Entity<DetalleTipoCable>()
             .HasMany(e => e.elementoCable)
            .WithOne(c => c.detalleTipoCable).HasForeignKey(c=>c.detalletipocable_id);


            modelBuilder.Entity<DetalleTipoNovedad>()
             .HasMany(e => e.elementoNovedad)
            .WithOne(c => c.detalleTipoNovedad).HasForeignKey(c=>c.detalletiponovedad_id);

              modelBuilder.Entity<Elemento>()
             .HasMany(e => e.novedad)
            .WithOne(c => c.elemento).HasForeignKey(c=>c.element_id);
 
               modelBuilder.Entity<Elemento>()
             .HasMany(e => e.localizacionElemento)
            .WithOne(c => c.elemento).HasForeignKey(c=>c.element_id);

             modelBuilder.Entity<Elemento>()
             .HasMany(e => e.elementoCable)
            .WithOne(c => c.elemento).HasForeignKey(c=>c.element_id);

        
             modelBuilder.Entity<ElementoCable>()
             .HasMany(e => e.localizacionCable)
            .WithOne(c => c.elementoCable).HasForeignKey(c=>c.elementocable_id);


             modelBuilder.Entity<Empresa>()
             .HasMany(e => e.proyectoEmpresa)
            .WithOne(c => c.empresa).HasForeignKey(c=>c.empresa_id);

             modelBuilder.Entity<Estado>()
             .HasMany(e => e.Elementos)
            .WithOne(c => c.Estado).HasForeignKey(c=>c.estado_id);

            modelBuilder.Entity<LongitudElemento>()
             .HasMany(e => e.elemento)
            .WithOne(c => c.longitudelemento).HasForeignKey(c=>c.longitudlemento_id);

            modelBuilder.Entity<Material>()
             .HasMany(e => e.Elementos)
            .WithOne(c => c.material).HasForeignKey(c=>c.material_id);


        modelBuilder.Entity<NivelTensionElemento>()
             .HasMany(e => e.elemento)
            .WithOne(c => c.NivelTensionElemento).HasForeignKey(c=>c.niveltensionelemento_id);

        modelBuilder.Entity<Proyecto>()
             .HasMany(e => e.proyectoUsuario)
            .WithOne(c => c.proyecto).HasForeignKey(c=>c.proyecto_id);

         modelBuilder.Entity<Proyecto>()
             .HasMany(e => e.elemento)
            .WithOne(c => c.proyecto).HasForeignKey(c=>c.proyecto_id);


            modelBuilder.Entity<TipoCable>()
                        .HasMany(e => e.detalleTipoCable)
                        .WithOne(c => c.tipoCable).HasForeignKey(c=>c.tipocable_id);


            modelBuilder.Entity<TipoEquipo>()
                        .HasMany(e => e.equipoElemento)
                        .WithOne(c => c.tipoEquipo).HasForeignKey(c=>c.tipoequipo_id);
//TipoNovedad
            modelBuilder.Entity<TipoNovedad>()
                        .HasMany(e => e.detalleTipoNovedad)
                        .WithOne(c => c.tipoNovedad).HasForeignKey(c=>c.tiponovedad_id);
modelBuilder.Entity<Departamento>()
                        .HasMany(e => e.ciudades)
                        .WithOne(c => c.departmento).HasForeignKey(c=>c.departmentoId);





            
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