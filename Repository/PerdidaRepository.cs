using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class PerdidaRepository:EntityBaseRepository<Perdida,long, MyAppContext>, IPerdidaRepository
    {
        public PerdidaRepository(MyAppContext context)
            : base(context)
        { }
    }
}