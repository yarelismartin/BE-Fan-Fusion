using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Repositories;

namespace BE_Fan_Fusion.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public async Task<Comment> CreateCommentAsync(Comment comment)
        {
            return await _commentRepository.CreateCommentAsync(comment);
        }
        public async Task<Comment> DeleteCommentAsync(int commentId)
        {
            return await _commentRepository.DeleteCommentAsync(commentId);
        }
    }
}
