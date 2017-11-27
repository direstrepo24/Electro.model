using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.Models.datatakemodel;

namespace Electro.model.Repository
{
    public class Tipo_PerdidaRepository:EntityBaseRepository<Tipo_Perdida,long, MyAppContext>, ITipo_PerdidaRepository
    {
        public Tipo_PerdidaRepository(MyAppContext context)
            : base(context)
        { }
    
        
    }
}