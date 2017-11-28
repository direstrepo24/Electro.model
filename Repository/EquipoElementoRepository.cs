using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class EquipoElementoRepository:EntityBaseRepository<EquipoElemento,long, MyAppContext>, IEquipoElementoRepository
    {
        public EquipoElementoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}