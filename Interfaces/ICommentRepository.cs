using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface ICommentRepository
    {
        Task<Comment> CreateCommentAsync(Comment comment);
        Task<bool> UserExistsAsync(int userId);
        Task<bool> ChapterExistsAsync(int chapterId);
        Task<Comment> DeleteCommentAsync(int commentId);
    }
}
