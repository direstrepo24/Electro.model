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
        [JsonIgnore]
        public virtual Empresa empresa{ get; set; }

        public long empresa_id{ get; set; }
    }
}