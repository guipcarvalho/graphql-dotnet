using GraphQL.Playground.Data.Repositories.Contracts;
using GraphQL.Playground.GraphQL.Types;
using GraphQL.Playground.Model.Entities;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL.Queries;

public sealed class CourseQuery : ObjectGraphType
{
    public CourseQuery(ICourseRepository repository)
    {
        Field<ListGraphType<CourseType>>("courses")
            .Description("Returns a list of courses.")
            .ResolveAsync(async _ => await repository.GetCoursesAsync());
        
        Field<CourseType>("course")
            .Argument<NonNullGraphType<IdGraphType>>("id", "The id of the course.")
            .ResolveAsync(async context => await repository.GetCourseByIdAsync(context.GetArgument<int>("id")));
            
    }
}