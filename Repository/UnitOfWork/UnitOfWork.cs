using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Data;
using movie_management.Repository.ActorRepo;
using movie_management.Repository.BiographyRepo;
using movie_management.Repository.GenreRepo;
using movie_management.Repository.MovieRepo;

namespace movie_management.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            _context = context;

            Actor = new ActorRepository(_context);
            Movie = new MovieRepository(_context);
            Biography = new BiographyRepository(_context);
            Genre = new GenreRepository(_context);
        }

        public IActorRepository Actor { get; private set; }
        public IMovieRepository Movie { get; private set; }
        public IBiographyRepository Biography { get; private set; }
        public IGenreRepository Genre { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}