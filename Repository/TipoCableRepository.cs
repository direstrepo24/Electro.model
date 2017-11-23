using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class TipoCableRepository:EntityBaseRepository<TipoCable,long, MyAppContext>, ITipoCableRepository
    {
        public TipoCableRepository(MyAppContext context)
            : base(context)
        { }
        
    }
}