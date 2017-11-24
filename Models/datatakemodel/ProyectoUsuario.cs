using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class ProyectoUsuario:IEntityBase<long>
    {
        public long Id{ get; set; }
        public bool IsActivo{ get; set; }
        public long  Usuario_Id{ get; set; }
        public long Proyecto_Id{ get; set; }

        [JsonIgnore]
        public virtual Usuario Usuario{ get; set; }
        [JsonIgnore]
        public virtual Proyecto proyecto{ get; set; }
    }
}