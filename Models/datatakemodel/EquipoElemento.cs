using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class EquipoElemento:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Codigo{ get; set; }
        public string Descripcion{ get; set; }
        public long Cantidad{ get; set; }
        public long EmpresaId{ get; set; }
        public bool ConectadoRbt{ get; set; }
        public bool MedidorBt{ get; set; }
        public long Consumo{ get; set; }
        public string UnidadMedida{ get; set; }

        [JsonIgnore]
        public virtual TipoEquipo tipoEquipo{ get; set; }

        public long tipoequipo_id{ get; set; }
    }
}