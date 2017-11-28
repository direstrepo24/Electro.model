using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class ElementoCableRepository:EntityBaseRepository<ElementoCable,long, MyAppContext>, IElementoCableRepository
    {
        public ElementoCableRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}