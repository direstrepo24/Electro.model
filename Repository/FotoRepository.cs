using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class FotoRepository:EntityBaseRepository<Foto,long, MyAppContext>, IFotoRepository
    {
        public FotoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}