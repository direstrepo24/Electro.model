using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class UsuarioRepository:EntityBaseRepository<Usuario,long, MyAppContext>, IUsuarioRepository
    {
        public UsuarioRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}