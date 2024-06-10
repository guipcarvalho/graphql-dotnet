using GraphQL.Playground.Model.Entities;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL.Types;

public class CourseType : ObjectGraphType<Course>
{
    public CourseType()
    {
        Field(x => x.Id, type: typeof(IdGraphType))
            .Description("The id of the course.");
        
        Field(x => x.Name, type: typeof(StringGraphType))
            .Description("The name of the course.");
        
        Field(x => x.Description, type: typeof(StringGraphType))
            .Description("The description of the course.");
        
        Field(x => x.Review, type: typeof(IntGraphType))
            .Description("The review of the course.");
        
        Field(x => x.DateAdded, type: typeof(DateTimeGraphType))
            .Description("The date the course was added.");
        
        Field(x => x.DateUpdated, type: typeof(DateTimeGraphType))
            .Description("The date the course was updated.");
    }
}