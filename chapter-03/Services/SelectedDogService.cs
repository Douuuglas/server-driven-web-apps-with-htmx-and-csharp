namespace chapter_03.Services;

internal interface ISelectedDogService
{
    public Guid? SelectedId { get; set; }
}

public class SelectedDogService : ISelectedDogService
{
    public Guid? SelectedId { get; set; }
}
