using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface ICommentService
    {
        Task<Comment> CreateCommentAsync(Comment newComment);
        Task<Comment?> DeleteCommentAsync(int commentId);
    }
}
