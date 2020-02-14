using WebAPI_RepositoryPattern.Models;

namespace WebAPI_RepositoryPattern.Data.EFCore
{
    public class EfCoreStarRepository : EfCoreRepository<Star, DataContext>
    {
        public EfCoreStarRepository(DataContext context) : base(context)
        {

        }
    }
}
