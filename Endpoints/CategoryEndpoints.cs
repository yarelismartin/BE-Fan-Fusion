using System;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Endpoints
{
    public static class CategoryEndpoint
    {
        public static void MapCategoryEndpoints(this  IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("").WithTags(nameof(Category));
        }
    }
}
