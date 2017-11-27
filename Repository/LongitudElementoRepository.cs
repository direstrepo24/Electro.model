using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class LongitudElementoRepository:EntityBaseRepository<LongitudElemento,long, MyAppContext>, ILongitudElementoRepository
    {
        public LongitudElementoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}