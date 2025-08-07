using Microsoft.AspNetCore.Http.HttpResults;

namespace chapter_03.Initial;

public static partial class InitialEndpoints
{
    // Grouping the initial example functionality and endpoints
    public static void MapInitialEndpoints(this WebApplication app)
    {
        app.MapGet("/", () => new RazorComponentResult<HomePage>());
    }
}
