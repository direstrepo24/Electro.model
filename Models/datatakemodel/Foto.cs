using System;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Foto:IEntityBase<long>
    {
        public long Id { get; set; }
        public string Titulo{ get; set; }
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
        public DateTime FechaCreacion{ get; set; }
        public string Hora{ get; set; }

        //Relaciones 
        public long? Novedad_Id { get; set; }   
        public long Elemnto_Id { get; set; }   

        [JsonIgnore]
        public virtual Elemento Elemnto{ get; set; }

        [JsonIgnore]
        public virtual Novedad Novedad{ get; set; }
    }
}