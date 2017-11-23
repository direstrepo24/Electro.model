using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class ProyectoUsuario:IEntityBase<long>
    {
        public long Id{ get; set; }
        public bool IsActivo{ get; set; }
        [JsonIgnore]
        public virtual Usuario usuario{ get; set; }
        [JsonIgnore]
        public virtual Proyecto proyecto{ get; set; }
    }
}