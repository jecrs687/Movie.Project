using Movie.Application.Movie.command;
using Movie.Application.Movie.Contracts;
using Movie.Domain.Entities;
using Movie.Domain.Repositories;

namespace Movie.Application.Movie.Services;

public class ListMoviesServices(IMovieRepository movieRepository) :IListMoviesServices
{
    public MovieEntity[] HandleCommand(GetAllMovies command)
    {
        var movies= movieRepository.GetAll(command.Page, command.Size, command.Filter);
        if (movies is null)
        {
            throw new EntryPointNotFoundException("Movies not found");
        }

        return movies;
    }
}