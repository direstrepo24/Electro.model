using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class NivelTensionElemento:IEntityBase<long>
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public long Valor { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Elemento> Elemento { get; set; }
   
        
    }
}