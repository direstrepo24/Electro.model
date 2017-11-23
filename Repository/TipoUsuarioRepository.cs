using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class TipoUsuarioRepository:EntityBaseRepository<Tipo_Usuario,int, MyAppContext>, ITipoUsuarioRepository
    {
        public TipoUsuarioRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}