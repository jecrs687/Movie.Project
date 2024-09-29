using Movie.Application.Movie.command;
using Movie.Domain.Entities;

namespace Movie.Application.Movie.Contracts;

public interface IListMoviesServices
{
   MovieEntity[] HandleCommand(GetAllMovies command);
}