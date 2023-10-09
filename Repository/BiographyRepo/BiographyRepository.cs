using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Data;
using movie_management.Repository.GenericRepository;

namespace movie_management.Repository.BiographyRepo
{
    public class BiographyRepository : GenericRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(DataContext context) : base(context)
        {

        }
    }
}