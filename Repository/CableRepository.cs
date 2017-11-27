using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class CableRepository:EntityBaseRepository<Cable,long, MyAppContext>, ICableRepository
    {
        public CableRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}