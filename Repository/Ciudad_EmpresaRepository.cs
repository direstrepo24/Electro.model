using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.Models.datatakemodel;

namespace Electro.model.Repository
{
    public class Ciudad_EmpresaRepository:EntityBaseRepository<Ciudad_Empresa,long, MyAppContext>, ICiudad_EmpresaRepository
    {
        public Ciudad_EmpresaRepository(MyAppContext context)
            : base(context)
        { }
    }
}