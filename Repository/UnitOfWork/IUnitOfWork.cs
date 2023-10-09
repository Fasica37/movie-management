using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Repository.ActorRepo;
using movie_management.Repository.BiographyRepo;
using movie_management.Repository.GenreRepo;
using movie_management.Repository.MovieRepo;

namespace movie_management.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepository Actor { get; }
        IMovieRepository Movie { get; }
        IGenreRepository Genre { get; }
        IBiographyRepository Biography { get; }

        int Save();

    }
}