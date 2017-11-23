using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class ProyectoRepository:EntityBaseRepository<Proyecto,long, MyAppContext>, IProyectoRepository
    {
        public ProyectoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}