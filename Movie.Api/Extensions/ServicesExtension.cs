using Movie.Application.Movie.Contracts;
using Movie.Application.Movie.Services;

namespace Movie.Api.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton<IListMoviesServices, ListMoviesServices>();
        return services;
    }
}