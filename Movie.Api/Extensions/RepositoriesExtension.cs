using Movie.Domain.Repositories;
using Movie.Infra.Repositories;

namespace Movie.Api.Extensions;

public static class RepositoriesExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddSingleton<IMovieRepository, MovieRepository>();
        return services;
    }
}