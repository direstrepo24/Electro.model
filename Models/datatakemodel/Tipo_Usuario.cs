using System.Collections.Generic;
using datamakerslib.Repository;

namespace Electro.model.datatakemodel
{
    public class Tipo_Usuario: IEntityBase<int>
    {
        
             public int  Id{get;set;}
             public string Nombre {get;set;}

             public virtual ICollection<Usuario> Usuarios {get;set;}
    }
}