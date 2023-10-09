using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_management.Dto.Actor;

namespace movie_management.Dto.Biography
{
    public class AddBiographDto
    {
        public string Description { get; set; } = string.Empty;
        public AddActorDto? Actor { get; set; }
        public int ActorId { get; set; }
    }
}