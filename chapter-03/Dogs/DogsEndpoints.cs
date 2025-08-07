using chapter_03.Dogs.Features;

namespace chapter_03.Dogs;

public static partial class DogsEndpoints
{
    // Grouping the cats functionality and endpoints
    public static void MapDogsEndpoints(this WebApplication app)
    {
        // Map a group so all other endpoints will have "dogs" at the begining
        var group = app.MapGroup("/dogs");

        group.MapGet("/form", DogForm.Handle);
        group.MapGet("/table-rows", ShowDogs.Handle);
        group.MapPut("/{id:guid}/select", SelectDog.Handle);
        group.MapPut("/{id:guid}/deselect", DeselectDog.Handle);
        group.MapDelete("/{id:guid}", DeleteDog.Handle);
        group.MapPut("/{id:guid}", EditDog.Handle).DisableAntiforgery();
        group.MapPost("/", AddDog.Handle)
            /*
             * Anti-forgery token validation is a recommended security precaution for APIs that consume data from a form.
             * Disabled in order to make this app simpler.
             * More: https://learn.microsoft.com/en-us/aspnet/core/security/anti-request-forgery?view=aspnetcore-9.0
             */
            .DisableAntiforgery();
    }
}
