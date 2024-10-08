using System.ComponentModel.DataAnnotations;
using Movie.Domain.Filters;

namespace Movie.Application.Movie.QueriesParams;

public class GetAllQueryParams
{
    [StringLength(250)]
    public string? Title { get; set; }
    [Range(1900,2024)]
    public  int? Year { get; set; }
    [StringLength(250)]
    public string? Genre { get; set; }
    [StringLength(250)]
    public  string? Director { get; set; }
    [StringLength(250)]
    public string? Actor { get; set; }
    
    [Range(0, 10)]
    public  double? Rating { get; set; }
    
    
    [Required] 
    [Range(0, int.MaxValue)] 
    public  int Page { get; set; }
    
    [Required]
    [Range(1, int.MaxValue)]
    public  int PageSize { get; set; }
    
    public MovieFilter ToMovieFilter()
    {
        return new  MovieFilter(
            year:  Year,
            title: Title,
            genre: Genre,
            director: Director,
            actor: Actor,
            rating: Rating
         );
    }
}