using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Departamento:IEntityBase<long>
    {
        public long Id{ get; set; }
        
        public long codigodpto{ get; set; }
        public string Nombre{ get; set; }
        //[JsonIgnore]
        public virtual ICollection<Ciudad> ciudades{get;set;}
    }
}