using chapter_03;
using chapter_03.Dogs;
using chapter_03.Initial;
using chapter_03.Services;

var builder = WebApplication.CreateBuilder(args);

// Add the in memory db
builder.Services.AddDbContext<InMemoryDbContext>();

// Register the razor components in order to use the RazorComponentResult
builder.Services.AddRazorComponents();

// Adding the service to hold the selected id
builder.Services.AddSingleton<ISelectedDogService, SelectedDogService>();

var app = builder.Build();

// Necessary for serving static files in the wwwroot folder
app.MapStaticAssets();

// Initial part of the chapter
app.MapInitialEndpoints();

// Add dogs endpoints
app.MapDogsEndpoints();

// Seed a few dogs just for start
app.SeedDatabase();

app.Run();
