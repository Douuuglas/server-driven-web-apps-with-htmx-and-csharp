using chapter_01.Cats.Features;
using Microsoft.AspNetCore.Http.HttpResults;

namespace chapter_01.Cats;

public static partial class CatsEndpoints
{
    // Grouping the cats functionality and endpoints
    public static void MapCatsEndpoints(this WebApplication app)
    {
        // Returning the home page directly to make things simple
        app.MapGet("/cats", () => new RazorComponentResult<HomePage>());

        // Isolating each functionality into its own class so they don't interfere on each other
        app.MapPost("/cats", AddCat.Handle)
            /*
             * Anti-forgery token validation is a recommended security precaution for APIs that consume data from a form.
             * Disabled in order to make this app simpler.
             * More: https://learn.microsoft.com/en-us/aspnet/core/security/anti-request-forgery?view=aspnetcore-9.0
             */
            .DisableAntiforgery();

        // Returning the home page directly to make things simple
        app.MapGet("/cats/table-rows", ShowCats.Handle);

        app.MapDelete("/cats/{id:guid}", DeleteCat.Handle);
    }
}
