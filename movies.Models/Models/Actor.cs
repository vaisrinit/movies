using System.ComponentModel.DataAnnotations;
using movies.DataAccess.Base;

namespace movies.Models;

public class Actor:IEntityBase
{
    [Key]
    public int Id { get; set; }
    [Display(Name ="Profile Picture URL")]

    public string ProfilePictureUrl { get; set; }
    
    [Display(Name ="Full Name")]

    public string FullName { get; set; }

    [Display(Name ="Biography")]

    public string Bio { get; set; }
    //Relationships
    public List<Actor_Movie>Actor_Movie {get;set;}

}