using datamakerslib.Repository;
using Electro.model.Models.datatakemodel;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class EquipoElemento:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Codigo{ get; set; }
        public string Descripcion{ get; set; }
        public long Cantidad{ get; set; }
    
        public bool ConectadoRbt{ get; set; }
        public bool MedidorBt{ get; set; }
        public long Consumo{ get; set; }
        public string UnidadMedida{ get; set; }

        //Relaciones
        public long EmpresaId{ get; set; }
        public long Ciudad_Id{ get; set; }
        public long? Ciudad_Empresa_Id{ get; set; }
        public long TipoEquipo_Id{ get; set; }
        public long Elemento_Id {get; set;}
        
        [JsonIgnore]
        public virtual TipoEquipo TipoEquipo{ get; set; }
        
         [JsonIgnore]
        public virtual Elemento Elemento{ get; set; }

        [JsonIgnore]
        public virtual Ciudad_Empresa Ciudad_Empresa{ get; set; }
        
    }
}