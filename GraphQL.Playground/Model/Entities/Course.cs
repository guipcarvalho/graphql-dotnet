using System.ComponentModel.DataAnnotations;

namespace GraphQL.Playground.Model.Entities;

public class Course
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime DateUpdated { get; set; }
    
    public ICollection<Review> Reviews { get; set; }
}