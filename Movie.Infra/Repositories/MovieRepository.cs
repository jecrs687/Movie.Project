using Movie.Domain.Entities;
using Movie.Domain.Factories;
using Movie.Domain.Filters;
using Movie.Domain.Repositories;

namespace Movie.Infra.Repositories;

public class MovieRepository:IMovieRepository
{
    private readonly MovieEntity[] _movies;
    
    public MovieRepository()
    {
        _movies = MovieFactory.CreateMock(100000);
    }
    
    public MovieEntity[] GetAll(int page, int size, MovieFilter filter)
    {

        return filter.Filter(_movies).Skip(page * size).Take(size).ToArray();
    }
}