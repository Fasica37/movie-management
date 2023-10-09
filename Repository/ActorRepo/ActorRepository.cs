using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Data;
using movie_management.Repository.GenericRepository;

namespace movie_management.Repository.ActorRepo
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(DataContext context) : base(context)
        {

        }

        public IEnumerable<Actor> GetActorsWithMovies()
        {
            var actorsWithMovies = _context.Actors.Include(u => u.Movies).ToList();
            return actorsWithMovies;
        }
    }
}