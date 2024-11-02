using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Repositories
{
    public class CommentRepository : ICommentRepository
    {
     
        private readonly FanFusionDbContext dbContext;

        public CommentRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }

        public Task<Comment> CreateCommentAsync(Comment comment)
        {
            throw new NotImplementedException();
        }
        public Task<Comment> DeleteCommentAsync(int commentId)
        {
            throw new NotImplementedException();
        }

    }
}

