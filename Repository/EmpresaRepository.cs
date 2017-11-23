using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;


namespace Electro.model.Repository
{
    public class EmpresaRepository:EntityBaseRepository<Empresa,long, MyAppContext>, IEmpresaRepository
    {
        public EmpresaRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}