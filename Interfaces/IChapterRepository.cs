using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Interfaces
{
    public interface IChapterRepository
    {
        Task<Chapter?> GetChapterByIdAsync(int chapterId);

        Task<bool> UserExistsAsync(int userId);
        Task<bool> StoryExistsAsync(int storyId);
        Task<Chapter> CreateOrUpdateChapterAsync(Chapter chapter);
        Task<Chapter?> DeleteChapterAsync(int chapterId);
    }
}
