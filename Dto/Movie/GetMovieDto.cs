using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Dto.Actor;
using movie_management.Dto.Genre;

namespace movie_management.Dto.Movie
{
    public class GetMovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int ActorId { get; set; }
        public GetActorDto? Actor { get; set; }

        public List<GetGenreDto>? Genre { get; set; }
    }
}