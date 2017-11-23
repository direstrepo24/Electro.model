//using Electrocore.Models;

using datamakerslib.Repository;
using Electro.model.datatakemodel;



namespace Electro.model.Repository
{
   
        
    
     public interface ITipoCableRepository:IEntityBaseRepository<TipoCable, long>{}
     public interface  IDetalleTipoCableRepository:IEntityBaseRepository<DetalleTipoCable, long>{}
      public interface ITipoNovedadRepository:IEntityBaseRepository<TipoNovedad, long>{}
      public interface ITipoEquipoRepository:IEntityBaseRepository<TipoEquipo, long>{}
      public interface IDetalleTipoNovedadRepository:IEntityBaseRepository<DetalleTipoNovedad, long>{}
      public interface IEmpresaRepository:IEntityBaseRepository<Empresa, long>{}
      public interface IDispositivoRepository:IEntityBaseRepository<Dispositivo, long>{}  

      public interface ICiudadRepository :IEntityBaseRepository<Ciudad, long>{}  
      public interface IDepartamentoRepository :IEntityBaseRepository<Departamento, long>{} 
      public interface IMaterialRepository :IEntityBaseRepository<Material, long>{} 
      public interface IEstadoRepository :IEntityBaseRepository<Estado, long>{} 

      public interface ITipoUsuarioRepository :IEntityBaseRepository<Tipo_Usuario, int>{}

      public interface IUsuarioRepository :IEntityBaseRepository<Usuario, long>{}   

      public interface IProyectoUsuarioRepository :IEntityBaseRepository<ProyectoUsuario, long>{}

      public interface IProyectoRepository :IEntityBaseRepository<Proyecto, long>{}   

      public interface IProyectoEmpresaRepository :IEntityBaseRepository<Proyecto_Empresa, long>{}   

}