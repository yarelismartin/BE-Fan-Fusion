using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;

namespace BE_Fan_Fusion.Repositories
{
    public class CommentRepository : ICommentRepository
    {
         {
        private readonly FanFusionDbContext dbContext;

        public CommentRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
    }
}
}
