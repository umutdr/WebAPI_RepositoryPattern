using WebAPI_RepositoryPattern.Models;

namespace WebAPI_RepositoryPattern.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, DataContext>
    {
        public EfCoreMovieRepository(DataContext context) : base(context)
        {

        }
    }
}
