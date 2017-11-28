using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class NovedadRepository:EntityBaseRepository<Novedad,long, MyAppContext>, INovedadRepository
    {
        public NovedadRepository(MyAppContext context)
            : base(context)
        { }
    }
}