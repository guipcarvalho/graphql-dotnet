using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL.Playground.Model.Entities;

public class Review
{
    [Key]
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    
    public int CourseId { get; set; }
    [ForeignKey(nameof(CourseId))]
    public Course Course { get; set; }
}