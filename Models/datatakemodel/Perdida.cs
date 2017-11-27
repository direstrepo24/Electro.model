using datamakerslib.Repository;
using Electro.model.Models.datatakemodel;

namespace Electro.model.datatakemodel
{
    public class Perdida:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Concepto {get; set;}
        public long Cantidad {get; set;}
        public string Descripcion {get; set;}
        public double Valor {get; set;} 
        public bool Response_Checked {get; set;} 
        
        //Relaciones
        public long Elemento_Id {get;set;}
        public long Tipo_Perdida_Id {get;set;}
        public virtual Elemento elemento {get;set;}
        public virtual Tipo_Perdida Tipo_Perdida {get;set;}
    }
}