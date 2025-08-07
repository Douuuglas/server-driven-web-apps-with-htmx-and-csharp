using chapter_03.Dogs.Components;
using chapter_03.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace chapter_03.Dogs.Features;

internal sealed class DogForm
{
    public static Results<RazorComponentResult<AddDogComponent>, RazorComponentResult<EditDogComponent>> Handle(InMemoryDbContext db, ISelectedDogService selectedDogService)
    {
        if (selectedDogService.SelectedId is not null)
        {
            var dog = db.Dogs.Single(d => d.Id == selectedDogService.SelectedId);

            return new RazorComponentResult<EditDogComponent>(new { Dog = dog });
        }


        return new RazorComponentResult<AddDogComponent>();
    }
}
