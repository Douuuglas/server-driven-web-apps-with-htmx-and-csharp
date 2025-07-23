using chapter_01;
using chapter_01.Cats;
using chapter_01.Initial;

var builder = WebApplication.CreateBuilder(args);

// Adding the in memory db
builder.Services.AddDbContext<InMemoryDbContext>();

// Register the razor components in order to use the RazorComponentResult
builder.Services.AddRazorComponents();

var app = builder.Build();

// Necessary for serving static files in the wwwroot folder
app.MapStaticAssets();

// Initial part of the chapter
app.MapInitialEndpoints();

// Second part of the chapter (crud)
app.MapCatsEndpoints();


app.Run();
