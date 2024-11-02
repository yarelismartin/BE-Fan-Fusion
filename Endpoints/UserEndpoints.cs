using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Endpoints
{
    public static class UserEndpoints
    {
        public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("").WithTags(nameof(User));

            group.MapGet("/checkUser/{uid}", (FanFusionDbContext db, string uir) =>
            {
                User? userCheck = db.Users.FirstOrDefault(u => u.Uid == uid);

                if (userCheck == null)
                {
                    return Results.NotFound("User is not registered");
                }
                return Results.Ok(new
                {
                    userCheck.Id,
                    userCheck.FirstName,
                    userCheck.LastName,
                    userCheck.Email,
                    userCheck.Image,
                    userCheck.Uid
                });
            });
        }


    }
}
