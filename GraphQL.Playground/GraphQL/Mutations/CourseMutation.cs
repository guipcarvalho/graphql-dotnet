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

        Field<CourseType>("updateCourse")
            .Description("Update a course.")
            .Argument<NonNullGraphType<IdGraphType>>("id", "The id of the course.")
            .Argument<NonNullGraphType<CourseInputType>>("course", "Course to be updated")
            .ResolveAsync(async context =>
            {
                var id = context.GetArgument<int>("id");
                var course = context.GetArgument<Course>("course");

                course.Id = id;

                return await repository.UpdateCourseAsync(course);
            });

        Field<CourseType>("deleteCourse")
            .Argument<NonNullGraphType<IdGraphType>>("id")
            .ResolveAsync(async context =>
            {
                var id = context.GetArgument<int>("id");

                await repository.DeleteCourseAsync(id);

                return true;
            });
    }
}