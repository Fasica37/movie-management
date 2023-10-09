using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Dto.Biography;
using movie_management.Dto.Movie;

namespace movie_management.Dto.Actor
{
    public class AddActorDto
    {
        public string Name { get; set; } = string.Empty;
        public List<AddMovieDto>? Movies { get; set; }
        public AddBiographDto? Biography { get; set; }
    }
}