using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Repository.GenericRepository;

namespace movie_management.Repository.ActorRepo
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        IEnumerable<Actor> GetActorsWithMovies();

    }
}