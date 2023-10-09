using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Data;
using movie_management.Repository.GenericRepository;

namespace movie_management.Repository.MovieRepo
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(DataContext context) : base(context)
        {

        }

    }
}