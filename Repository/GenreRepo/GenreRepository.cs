using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Data;
using movie_management.Repository.GenericRepository;

namespace movie_management.Repository.GenreRepo
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(DataContext context) : base(context)
        {

        }
    }
}