using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using movies.DataAccess.Base;
namespace movies.Models;

public class Producer:IEntityBase
{
    [Key]
    public int Id { get; set; }
    public string ProfilePictureUrl { get; set; }
    [Display(Name ="Full Name")]
    public string FullName { get; set; }
    [Display(Name ="Biography")]
    public string Bio { get; set; }
    
    //Relationships
    public List<Movie>Movies {get;set;}
}