using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;

namespace Electro.model.Repository
{
    public class ProyectoEmpresaRepository:EntityBaseRepository<Proyecto_Empresa,long, MyAppContext>, IProyectoEmpresaRepository
    {
        public ProyectoEmpresaRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}