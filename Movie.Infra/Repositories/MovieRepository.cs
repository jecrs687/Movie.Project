using Movie.Domain.Entities;
using Movie.Domain.Factories;
using Movie.Domain.Filters;

namespace Movie.Infra.Repositories;

public class MovieRepository
{
    private MovieEntity[] movies = [];
    
    public MovieRepository()
    {
        this.movies = MovieFactory.CreateMock(1000);
    }
    
    public MovieEntity[] GetAll(int page, int size, MovieFilter filter)
    {

        return filter.Filter(movies).Skip(page * size).Take(size).ToArray();
    }
}