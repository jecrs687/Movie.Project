using Movie.Domain.Entities;
namespace Movie.Domain.Filters;

public class MovieFilter(int Year, string Title, string Genre, string Director, string Actor, double Rating)
{

    public int Year { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public string Actor { get; set; }
    public double Rating { get; set; }
    
    public MovieEntity[] Filter(MovieEntity[] movies)
    {
        return movies.Where(x =>
            (Title != null && x.Title.Contains(Title)) ||
            (Year != 0 && x.Year >= Year) ||
            (Genre != null && x.Genre.Contains(Genre)) ||
            (Director != null && x.Director.Contains(Director)) ||
            (Actor != null && x.Actors.Any(x=>x.Contains(Actor))) ||
            (Rating != 0 && x.Rating >= Rating)
        ).ToArray();
    }


}