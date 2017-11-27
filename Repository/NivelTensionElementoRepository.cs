using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class NivelTensionElementoRepository:EntityBaseRepository<NivelTensionElemento,long, MyAppContext>, INivelTensionElementoRepository
    {
        public NivelTensionElementoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}