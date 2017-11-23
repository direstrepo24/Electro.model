using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class EstadoRepository:EntityBaseRepository<Estado,long, MyAppContext>, IEstadoRepository
    {
        public EstadoRepository(MyAppContext context)
            : base(context)
        { }
    }
}