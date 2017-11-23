using datamakerslib.Repository;

namespace Electro.model.datatakemodel
{
    public class Perdida:IEntityBase<long>
    {
        public long Id{ get; set; }
        public bool Is_Lampara_Adicional {get; set;}
        public long Cantidad_Lampara_Adicional {get; set;}
        public bool Is_Lamapara_Encendida {get; set;}
        public bool Is_Conexion_Ilicita {get; set;}
        public bool Is_Poda {get; set;}

        public virtual Elemento elemento {get;set;}
        public long element_Id {get;set;}
        
        
    }
}