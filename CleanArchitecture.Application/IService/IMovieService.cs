using CleanArchitecture.Domain;
namespace CleanArchitecture.Application.IService
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
    }
}
