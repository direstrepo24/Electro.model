using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class TipoNovedadRepository:EntityBaseRepository<TipoNovedad,long, MyAppContext>, ITipoNovedadRepository
    {
        public TipoNovedadRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}