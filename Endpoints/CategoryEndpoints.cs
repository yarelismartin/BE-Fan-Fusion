using System;
using BE_Fan_Fusion.DTO;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;


namespace BE_Fan_Fusion.Endpoints
{
    public static class CategoryEndpoint
    {
        public static void MapCategoryEndpoints(this  IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("categories").WithTags(nameof(Category));

            group.MapGet("/", async (ICategoryService categoryService) =>
            {
                var allCategories = await categoryService.GetCategoriesAsync();

                if (!allCategories.Any())
                {
                    return Results.Ok(new List<Category>());
                }
                return Results.Ok(allCategories);
            });
        }
    }
}