using BE_Fan_Fusion.Data;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Repositories;
using BE_Fan_Fusion.Services;
using BE_Fan_Fusion.Endpoints;

var builder = WebApplication.CreateBuilder(args);


// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
//builder.Services.AddNpgsql<FanFusionDbContext>(builder.Configuration["FanFusionDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<IChapterService, ChapterService>();
builder.Services.AddScoped<IChapterRepository, ChapterRepository>();

builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();

builder.Services.AddScoped<IStoryService, StoryService>();
builder.Services.AddScoped<IStoryRepository, StoryRepository>();

builder.Services.AddScoped<ITagService, TagService>();
builder.Services.AddScoped<ITagRepository, TagRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapCategoryEndpoints();
app.MapChapterEndpoints();
app.MapCommentEndpoints();
app.MapStoryEndpoints();
app.MapTagEndpoints();
app.MapUserEndpoints();

app.Run();
