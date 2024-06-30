using GraphQL.Playground.GraphQL.Mutations;
using GraphQL.Playground.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL;

public class GraphSchema : Schema
{
    public GraphSchema(CourseQuery query, CourseMutation mutation)
    {
        Query = query;
        Mutation = mutation;
    }
}