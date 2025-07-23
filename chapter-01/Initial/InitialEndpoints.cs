using Microsoft.AspNetCore.Http.HttpResults;
using System.Runtime.InteropServices;

namespace chapter_01.Initial;

public static partial class InitialEndpoints
{
    // Grouping the initial example functionality and endpoints
    public static void MapInitialEndpoints(this WebApplication app)
    {
        app.MapGet("/", () => new RazorComponentResult<HomePage>());
        app.MapGet("/version", () => RuntimeInformation.FrameworkDescription);
    }
}
