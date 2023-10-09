using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_management.Model
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Movie>? Movies { get; set; }
        public Biography? Biography { get; set; }
    }
}