using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Endpoints
{
    public class StoryTagEndpoints
    {
        public static void MapCategoryEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("").WithTags(nameof(StoryTag));

          
        }
    }
}