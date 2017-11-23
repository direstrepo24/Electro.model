using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class DepartamentoRepository:EntityBaseRepository<Departamento,long, MyAppContext>, IDepartamentoRepository
    {
        public DepartamentoRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}