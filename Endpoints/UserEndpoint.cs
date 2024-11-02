using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Endpoints
{
    public static class UserEndpoint
    {
        public static void MapUserEndpoint(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("").WithTags(nameof(User));
        }
    }
}
