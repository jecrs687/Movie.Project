using Movie.Domain.Entities;
namespace Movie.Domain.Filters;

public class MovieFilter
{

    public int? Year { get; set; }
    public string? Title { get; set; }
    public string? Genre { get; set; }
    public string? Director { get; set; }
    public string? Actor { get; set; }
    public double? Rating { get; set; }
    
    public MovieFilter(int? year, string? title, string? genre, string? director, string? actor, double? rating)
    {
        this.Year = year;
        this.Title = title?.ToLower();
        this.Genre = genre?.ToLower();
        this.Director = director?.ToLower();
        this.Actor = actor?.ToLower();
        this.Rating = rating;
    }
    
    public MovieEntity[] Filter(MovieEntity[] movies)
    {
        return movies.Where(x =>
            (Title == null || x.Title.ToLower().Contains(Title)) &&
            (Year == null || x.Year >= Year) &&
            (Genre == null || x.Genre.Any(x=> x.ToLower().Contains(Genre))) &&
            (Director == null || x.Director.ToLower().Contains(Director)) &&
            (Actor == null || x.Actors.Any(x=>x.ToLower().Contains(Actor))) &&
            (Rating == null || x.Rating >= Rating)
        ).ToArray();
    }

}