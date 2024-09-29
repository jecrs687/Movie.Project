namespace Movie.Domain.Entities;

public class MovieEntity(string Title, int Year, string[] Genre, string Director, string[] Actors, double Rating)
{
    public string Title { get; set; } 
    public int Year { get; set; }
    public string[] Genre { get; set; }
    public string Director { get; set; }
    public string[] Actors { get; set; }
    public double Rating { get; set; }
};