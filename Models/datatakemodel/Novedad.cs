using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Novedad:IEntityBase<long>
    {
         public long Id { get; set; }
        public string Descripcion { get; set; }
        public string Ruta_Foto { get; set; }
        public long Detalle_Tipo_Novedad_Id { get; set; }   
        public long Elemento_Id { get; set; }   

        [JsonIgnore]
        public virtual Elemento Elemento{ get; set; }

        [JsonIgnore]
        public virtual DetalleTipoNovedad DetalleTipoNovedad{ get; set; }
    }
}