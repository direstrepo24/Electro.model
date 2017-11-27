using System.Collections.Generic;
using datamakerslib.Repository;
using Electro.model.datatakemodel;
using Newtonsoft.Json;

namespace Electro.model.Models.datatakemodel
{
    public class Tipo_Perdida:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Nombre{ get; set; }
   
        [JsonIgnore]
        public virtual ICollection<Perdida> Perdidas { get; set; }
    }
}