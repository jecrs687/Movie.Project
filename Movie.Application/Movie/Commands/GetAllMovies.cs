using Movie.Domain.Filters;

namespace Movie.Application.Movie.command;

public class GetAllMovies
{
    public MovieFilter Filter;
    public int Page;
    public int Size;

    public GetAllMovies WithFilter(MovieFilter filter)
    {
        Filter = filter;
        return this;
    }
    public GetAllMovies WithPage(int page)
    {
        Page = page;
        return this;
    }
    public GetAllMovies WithPageSize(int size)
    {
        Size = size;
        return this;
    }
}