using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;


namespace Electro.model.Repository
{
    public class DispositivoRepository:EntityBaseRepository<Dispositivo,long, MyAppContext>, IDispositivoRepository
    {
        public DispositivoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}