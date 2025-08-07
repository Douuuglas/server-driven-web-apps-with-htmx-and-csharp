using chapter_03.Services;

namespace chapter_03.Dogs.Features;

internal sealed class DeselectDog
{
    public static Task Handle(HttpContext context, ISelectedDogService selectedDogService, Guid id)
    {
        selectedDogService.SelectedId = null;
        context.Response.Headers["HX-Trigger"] = "selection-change";

        return Task.CompletedTask;
    }
}
