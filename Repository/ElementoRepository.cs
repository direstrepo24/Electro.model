using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class ElementoRepository:EntityBaseRepository<Elemento,long, MyAppContext>, IElementoRepository
    {
        public ElementoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}