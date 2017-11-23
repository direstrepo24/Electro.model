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
        [JsonIgnore]
        public virtual Elemento elemento{ get; set; }
    }
}