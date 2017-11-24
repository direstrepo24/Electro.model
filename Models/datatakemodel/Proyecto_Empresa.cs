using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Proyecto_Empresa:IEntityBase<long>
    {
        public long Id{ get; set; }
        public bool IsOperadora{ get; set; }
        public bool IsPropietaria{ get; set; }
        public bool IsInterventora{ get; set; }
        //Relaciones
        public long Empresa_Id{ get; set; }
        public long Proyecto_Id{ get; set; }

        [JsonIgnore]
        public virtual Empresa Empresa{ get; set; }
         [JsonIgnore]
        public virtual Proyecto Proyecto{ get; set; }

    }
}