using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;


namespace Electro.model.Repository
{
    public class DetalleTipoNovedadRepository:EntityBaseRepository<DetalleTipoNovedad,long, MyAppContext>, IDetalleTipoNovedadRepository
    {
        public DetalleTipoNovedadRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}