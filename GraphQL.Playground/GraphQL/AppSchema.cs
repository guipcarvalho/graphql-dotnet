using GraphQL.Playground.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL;

public class AppSchema : Schema
{
    public AppSchema(CourseQuery query)
    {
        Query = query;
    }
}