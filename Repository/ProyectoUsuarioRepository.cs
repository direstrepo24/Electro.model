using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class ProyectoUsuarioRepository:EntityBaseRepository<ProyectoUsuario,long, MyAppContext>, IProyectoUsuarioRepository
    {
        public ProyectoUsuarioRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}