using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Dto.Biography;
using movie_management.Dto.Movie;

namespace movie_management.Dto.Actor
{
    public class GetActorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<GetMovieDto>? Movies { get; set; }
        public GetBiographyDto? Biography { get; set; }
    }
}