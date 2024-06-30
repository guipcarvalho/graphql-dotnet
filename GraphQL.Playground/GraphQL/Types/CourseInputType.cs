using GraphQL.Playground.Model.Entities;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL.Types;

public class CourseInputType : InputObjectGraphType<Course>
{
    public CourseInputType()
    {
        Name = "CourseInput";
        
        Field(x => x.Name, type: typeof(StringGraphType))
            .Description("The name of the course.");
        
        Field(x => x.Description, type: typeof(StringGraphType))
            .Description("The description of the course.");
        
        Field(x => x.Review, type: typeof(IntGraphType))
            .Description("The review of the course.");
    }
}