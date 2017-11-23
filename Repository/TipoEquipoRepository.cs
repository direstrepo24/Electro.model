using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class TipoEquipoRepository:EntityBaseRepository<TipoEquipo,long, MyAppContext>, ITipoEquipoRepository
    {
        public TipoEquipoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}