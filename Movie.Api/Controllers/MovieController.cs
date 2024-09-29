using Microsoft.AspNetCore.Mvc;
using Movie.Application.Movie.command;
using Movie.Application.Movie.Contracts;
using Movie.Application.Movie.QueriesParams;
using Movie.Application.Movie.Services;
using Movie.Domain.Entities;
using Movie.Domain.Filters;

namespace Movie.Api.Controllers;

[ApiController]
[Route("api")]
public class MovieController(IListMoviesServices listMoviesServices) : ControllerBase
{
    [HttpGet("movies")]
    public MovieEntity[] Get([FromQuery] GetAllQueryParams queryParams)
    {
        var command = new GetAllMovies().WithFilter(queryParams.ToMovieFilter())
            .WithPage( queryParams.Page)
            .WithPageSize(queryParams.PageSize);

        return listMoviesServices.HandleCommand(command);
    }
}