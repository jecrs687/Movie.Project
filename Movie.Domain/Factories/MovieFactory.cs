using Bogus;
using Movie.Domain.Entities;

namespace Movie.Domain.Factories;

public  class MovieFactory
{
    public static MovieEntity Create(string title, int year, string[] genre, string director, string[] actors, double rating)
    {
        return new MovieEntity(title, year, genre, director, actors, rating);
    }
    public static MovieEntity[] CreateMany(string[] titles, int[] years, string[][] genres, string[] directors, string[][] actors, double[] ratings)
    {
        var movies = new MovieEntity[titles.Length];
        for (int i = 0; i < titles.Length; i++)
        {
            movies[i] = new MovieEntity(titles[i], years[i], genres[i], directors[i], actors[i], ratings[i]);
        }
        return movies;
    }
    
    public static MovieEntity[] CreateMock(int numberOfMovies)
    {
        var faker = new Faker<MovieEntity>().Rules(
            (f, e) =>
            {
                e.Year = f.Date.Past(20).Year;
                e.Title = f.Lorem.Sentence();
                e.Genre = f.PickRandom(new string[] { "Action", "Comedy", "Drama", "Horror", "Romance" }, 
                    f.Random.Number(1, 3)
                    ).ToArray();
                e.Director = f.Person.FullName;
                e.Actors = f.Lorem.Words(3).ToArray();
                e.Rating = f.Random.Double(1, 10);
            }
            );
        return faker.Generate(numberOfMovies).ToArray();
    }
}