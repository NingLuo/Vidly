using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Vidly.Core.Repositories;
using Vidly.Models;

namespace Vidly.Persistence.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Movie> GetMoviesWithGenre()
        {
            return AppContext.Movies.Include(m => m.Genre).ToList();
        }

        public ApplicationDbContext AppContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}