using CleanArchitecture.Application.IRepository;
using CleanArchitecture.Application.IService;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository _movieRepository)
        {
            movieRepository = _movieRepository;
        }
        public List<Movie> GetAllMovies()
        {
            var movies = movieRepository.GetAllMovies();

            return movies;
        }
    }
}
