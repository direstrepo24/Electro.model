using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class CiudadRepository:EntityBaseRepository<Ciudad,long, MyAppContext>, ICiudadRepository
    {
        public CiudadRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}