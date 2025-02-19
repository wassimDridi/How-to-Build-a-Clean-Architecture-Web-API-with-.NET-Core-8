using CleanArchitecture.Application.IService;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("Get")]
        public IActionResult GetMovies()
        {
            var movieList = _movieService.GetAllMovies();
            return Ok(movieList);
        }
    }
}
