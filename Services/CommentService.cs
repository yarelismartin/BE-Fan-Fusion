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
        public async Task<Comment> CreateCommentAsync(Comment newComment)
        {
            if(! await _commentRepository.UserExistsAsync(newComment.UserId)) 
            {
                throw new ArgumentException($"There is no user with the following id: {newComment.UserId}");
            }

            if (!await _commentRepository.ChapterExistsAsync(newComment.ChapterId))
            {
                throw new ArgumentException($"There are no chapters with the following id: {newComment.ChapterId}");
            }

            Comment comment = new()
            {
                Content = newComment.Content,
                CreatedOn = DateTime.Now,
                UserId = newComment.UserId,
                ChapterId = newComment.ChapterId,
            };

            return await _commentRepository.CreateCommentAsync(comment);
        }
        public async Task<Comment?> DeleteCommentAsync(int commentId)
        {
            return await _commentRepository.DeleteCommentAsync(commentId);
        }
    }
}
