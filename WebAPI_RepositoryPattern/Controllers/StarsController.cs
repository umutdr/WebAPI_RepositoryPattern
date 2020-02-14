using WebAPI_RepositoryPattern.Data.EFCore;
using WebAPI_RepositoryPattern.Models;

namespace WebAPI_RepositoryPattern.Controllers
{
    public class StarsController : DataController<Star, EfCoreStarRepository>
    {
        public StarsController(EfCoreStarRepository repository) : base(repository)
        {

        }
    }
}
