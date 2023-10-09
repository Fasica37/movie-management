using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Dto.Movie;

namespace movie_management.Dto.Genre
{
    public class AddGenreDto
    {
        public string Name { get; set; } = string.Empty;
        public List<AddMovieDto>? Movies { get; set; }
    }
}