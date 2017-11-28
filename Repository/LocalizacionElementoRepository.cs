using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class LocalizacionElementoRepository:EntityBaseRepository<LocalizacionElemento,long, MyAppContext>, ILocalizacionElementoRepository
    {
        public LocalizacionElementoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}