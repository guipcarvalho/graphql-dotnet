using GraphQL.Playground.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL;

public class GraphSchema : Schema
{
    public GraphSchema(CourseQuery query)
    {
        Query = query;
    }
}