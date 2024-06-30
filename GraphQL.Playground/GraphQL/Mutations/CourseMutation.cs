using GraphQL.Playground.Data.Repositories.Contracts;
using GraphQL.Playground.GraphQL.Types;
using GraphQL.Playground.Model.Entities;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL.Mutations;

public sealed class CourseMutation : ObjectGraphType
{
    public CourseMutation(ICourseRepository repository)
    {
        Field<CourseType>("addCourse")
            .Description("Add a new course.")
            .Argument<NonNullGraphType<CourseInputType>>("course", "Course input parameter.")
            .ResolveAsync(async context =>
            {
                var course = context.GetArgument<Course>("course");
                
                return await repository.AddCourseAsync(course);
            });   
    }
}