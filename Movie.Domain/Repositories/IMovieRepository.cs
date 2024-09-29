using Movie.Domain.Entities;
using Movie.Domain.Filters;

namespace Movie.Domain.Repositories;

public interface IMovieRepository
{   
    List<MovieEntity> GetAll(int page, int size, MovieFilter filter);
}