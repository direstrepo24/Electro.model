using datamakerslib.Repository;
using Electro.model.DataContext;
using Electro.model.datatakemodel;
//using Electrocore.DataContext;
//using Electrocore.Models.datatakemodel;

namespace Electro.model.Repository
{
    public class MaterialRepository:EntityBaseRepository<Material,long, MyAppContext>, IMaterialRepository
    {
        public MaterialRepository(MyAppContext context)
            : base(context)
        { }
    }
}