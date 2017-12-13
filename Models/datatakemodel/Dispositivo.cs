using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Dispositivo:IEntityBase<long>
    {
         public long Id{ get; set; }

         public string Imei{ get; set; }

         public string Phone_Type_Device{ get; set; }

         public string Android_Id{ get; set; }

         public string Software_Version{ get; set; }

         public string Local_Ip_Address{ get; set; }

         public string Android_Version{ get; set; }

         public string MacAddr{ get; set; }

         public string Device_Name{ get; set; }

         public string Direccion_Ip{ get; set; }

         public bool Estado{ get; set; }

         [JsonIgnore]
         public virtual Usuario Usuario{get;set;}

         public long? userId {get;set;}
    }
}