//using Electrocore.Models;

using datamakerslib.Repository;
using Electro.model.datatakemodel;
using Electro.model.Models.datatakemodel;

namespace Electro.model.Repository
{
   
      
      public interface ITipoEquipoRepository:IEntityBaseRepository<TipoEquipo, long>{}
      public interface IEmpresaRepository:IEntityBaseRepository<Empresa, long>{}
      public interface IDispositivoRepository:IEntityBaseRepository<Dispositivo, long>{}  

      //Usuarios y Empresas
      public interface ITipoUsuarioRepository :IEntityBaseRepository<Tipo_Usuario, int>{}

      public interface IUsuarioRepository :IEntityBaseRepository<Usuario, long>{}   

      public interface IProyectoUsuarioRepository :IEntityBaseRepository<ProyectoUsuario, long>{}

      public interface IProyectoRepository :IEntityBaseRepository<Proyecto, long>{}   

      public interface IProyectoEmpresaRepository :IEntityBaseRepository<Proyecto_Empresa, long>{}
         
      //Sync Data
      public interface ICiudadRepository :IEntityBaseRepository<Ciudad, long>{}  
      public interface IDepartamentoRepository :IEntityBaseRepository<Departamento, long>{} 
      public interface IMaterialRepository :IEntityBaseRepository<Material, long>{} 
      public interface IEstadoRepository :IEntityBaseRepository<Estado, long>{}  
      
      //Perdida
      public interface ITipo_PerdidaRepository :IEntityBaseRepository<Tipo_Perdida, long>{} 
      //Novedades
      public interface ITipoNovedadRepository:IEntityBaseRepository<TipoNovedad, long>{}
      public interface IDetalleTipoNovedadRepository:IEntityBaseRepository<DetalleTipoNovedad, long>{}

      //Nivel de Tension
      public interface INivelTensionElementoRepository :IEntityBaseRepository<NivelTensionElemento, long>{}
      //longitud Elemento
      public interface ILongitudElementoRepository :IEntityBaseRepository<LongitudElemento, long>{}

      //Cables
      public interface ICableRepository :IEntityBaseRepository<Cable, long>{}
      //Tipo Cable
      public interface ITipoCableRepository:IEntityBaseRepository<TipoCable, long>{}
      //Detalle Tipo Cable
      public interface  IDetalleTipoCableRepository:IEntityBaseRepository<DetalleTipoCable, long>{}


      //ASync Post
      public interface  IElementoRepository:IEntityBaseRepository<Elemento, long>{}
      public interface  IElementoCableRepository:IEntityBaseRepository<ElementoCable, long>{}
      public interface  IEquipoElementoRepository:IEntityBaseRepository<EquipoElemento, long>{}
      public interface  INovedadRepository:IEntityBaseRepository<Novedad, long>{}
      public interface  IPerdidaRepository:IEntityBaseRepository<Perdida, long>{}
      public interface  ILocalizacionElementoRepository:IEntityBaseRepository<LocalizacionElemento, long>{}
      public interface  IFotoRepository:IEntityBaseRepository<Foto, long>{}

}