using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_management.Model
{
    public class Biography
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public Actor? Actor { get; set; }
        public int ActorId { get; set; }

    }
}