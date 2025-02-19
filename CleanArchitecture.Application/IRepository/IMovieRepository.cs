using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.IRepository
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();

    }
}
