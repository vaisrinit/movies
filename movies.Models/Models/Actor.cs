using System.ComponentModel.DataAnnotations;

namespace movies.Models;

public class Actor
{
    [Key]
    public int ActorId { get; set; }
    [Display(Name ="Profile Picture URL")]

    public string ProfilePictureUrl { get; set; }
    
    [Display(Name ="Full Name")]

    public string FullName { get; set; }

    [Display(Name ="Biography")]

    public string Bio { get; set; }
    //Relationships
    public List<Actor_Movie>Actor_Movie {get;set;}

}