using GraphQL.Playground.GraphQL.Types;
using GraphQL.Playground.Model.Entities;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL.Queries;

public class CourseQuery : ObjectGraphType
{
    public CourseQuery()
    {
        Field<ListGraphType<CourseType>>("courses")
            .Description("Returns a list of courses.")
            .Resolve(context => new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Name = "GraphQL for .NET Developers",
                    Description = "Learn how to use GraphQL in .NET applications.",
                    Review = 5,
                    DateAdded = new DateTime(2022, 6, 10),
                    DateUpdated = new DateTime(2022, 6, 10)
                },
                new Course
                {
                    Id = 2,
                    Name = "Entity Framework Core",
                    Description = "Learn how to use Entity Framework Core in .NET applications.",
                    Review = 4,
                    DateAdded = new DateTime(2022, 6, 10),
                    DateUpdated = new DateTime(2022, 6, 10)
                }
            });
        
        Field<CourseType>("course")
            .Argument<NonNullGraphType<IdGraphType>>("id", "The id of the course.")
            .Resolve(context =>
            {
                var id = context.GetArgument<int>("id");
                return new Course
                {
                    Id = id,
                    Name = "GraphQL for .NET Developers",
                    Description = "Learn how to use GraphQL in .NET applications.",
                    Review = 5,
                    DateAdded = new DateTime(2022, 6, 10),
                    DateUpdated = new DateTime(2022, 6, 10)
                };
            });
            
    }
}