using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Dispositivo:IEntityBase<long>
    {
         public long Id{ get; set; }
         public string Imei{ get; set; }

         public bool Estado{ get; set; }
         [JsonIgnore]
         public virtual Usuario Usuario{get;set;}
         public long userId{get;set;}
        
    }
}