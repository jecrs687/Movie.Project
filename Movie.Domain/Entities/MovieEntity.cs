namespace Movie.Domain.Entities;

public class MovieEntity
{
    public string Title { get; set; } 
    public int Year { get; set; }
    public string[] Genre { get; set; }
    public string Director { get; set; }
    public string[] Actors { get; set; }
    public double Rating { get; set; }
    
    public MovieEntity()
    {}
    public MovieEntity(string title, int year, string[] genre, string director, string[] actors, double rating)
    {
        Title = title;
        Year = year;
        Genre = genre;
        Director = director;
        Actors = actors;
        Rating = rating;
    }
};