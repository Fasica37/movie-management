using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie_management.Repository.UnitOfWork;

namespace movie_management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        [HttpGet]
        public ActionResult Get()
        {
            var actors = _unitOfWork.Actor.GetAll();
            return Ok(actors);
        }

        [HttpGet("movies")]
        public ActionResult GetWithMovies()
        {
            var actorsFromRepo = _unitOfWork.Actor.GetActorsWithMovies();
            return Ok(actorsFromRepo);
        }
    }
}