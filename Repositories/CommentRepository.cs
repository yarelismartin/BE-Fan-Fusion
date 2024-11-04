using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_Fan_Fusion.Repositories
{
    public class CommentRepository : ICommentRepository
    {
     
        private readonly FanFusionDbContext dbContext;

        public CommentRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }

        public async Task<Comment> CreateCommentAsync(Comment comment)
        {
            await dbContext.Comments.AddAsync(comment);
            await dbContext.SaveChangesAsync();
            return comment;
        }
        public async Task<bool> UserExistsAsync(int userId)
        {
            return await dbContext.Users.AnyAsync(user => user.Id == userId);
        }

        public async Task<bool> ChapterExistsAsync(int chapterId)
        {
            return await dbContext.Chapters.AnyAsync(chapter => chapter.Id == chapterId);
        }
        public async Task<Comment> DeleteCommentAsync(int commentId)
        {
            throw new NotImplementedException();
        }

    }
}

