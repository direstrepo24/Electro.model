using System.ComponentModel.DataAnnotations.Schema;
//using System.Spatial;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    [Table("Project_locationcable")]
    public class LocalizacionCable:IEntityBase<long>
    {
         public long Id{ get; set; }
         public string LineaCable{ get; set; }
         public string Color{ get; set; }
         public string Altitud{ get; set; }


         //Relaciones
        public long ElementoCable_Id{ get; set; }

         [JsonIgnore]   
         public virtual ElementoCable ElementoCable{ get; set; }
        
    }
}