using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;



namespace Electro.model.Repository
{
    public class DetalleTipoCableRepository:EntityBaseRepository<DetalleTipoCable,long, MyAppContext>, IDetalleTipoCableRepository
    {
        public DetalleTipoCableRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}